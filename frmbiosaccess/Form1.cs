using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace frmbiosaccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //timer1_Tick

        private void timer1_Tick(object sender, EventArgs e)
        {
            //đồng bộ thời gian với hệ thống gồm cả ngày, giờ, phút, giây
            this.Text = DateTime.Now.ToString("NOW:" + " " + "dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tiêu đề cho label lbltitle
            lbltitle.Text = "UEFI BIOS FIRMWARE ACCESS TOOL";
            //check hệ điều hành có phải windows 7 không
            // Kiểm tra nếu phiên bản nhỏ hơn 6.2 (tức là từ Win 7 trở xuống)
            if (Environment.OSVersion.Version < new Version(6, 2))
            {
                MessageBox.Show("This version of Windows is too old and does not support '/fw' command.", "Unsupported OS Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); //thoát ứng dụng
            }
            else
            {
                btnos.Enabled = true;
                btnos.PerformClick(); //gọi sự kiện btnos_Click
            }
        
        }

        private void btnos_Click(object sender, EventArgs e)
        {
            //nếu không phải windows 7 thì tiếp tục chạy ứng dụng
            try
            {
                string r = "";
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection information = searcher.Get();
                    if (information != null)
                    {
                        foreach (ManagementObject obj in information)
                        {
                            r = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                        }
                    }
                    // Thay thế mã kỹ thuật bằng tên thân thiện
                    r = r.Replace("NT 5.1.2600", "XP").Replace("NT 5.2.3790", "Server 2003");
                    lblwin.Text = r;
                    btnos.Enabled = false;
                    btnuefi.Enabled = true; // Tự động chuyển sang bước check UEFI

                }
            }
            catch (Exception ex)
            {
                lblwin.Text = "Unable to retrieve OS info";
                Debug.WriteLine("WMI Error: " + ex.Message);
            }
        }

        // Hàm này dùng để gọi thư viện hệ thống Windows
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int GetFirmwareEnvironmentVariable(string lpName, string lpGuid, IntPtr pBuffer, uint nSize);

        //kiểm tra uefi hay legacy bios
        private bool IsUefiMode()
        {
            // Thử gọi một biến giả trong Firmware
            // Nếu máy là Legacy BIOS, hàm này sẽ luôn thất bại (trả về 0)
            GetFirmwareEnvironmentVariable("", "{00000000-0000-0000-0000-000000000000}", IntPtr.Zero, 0);

            int lastError = Marshal.GetLastWin32Error();

            // ERROR_INVALID_FUNCTION (1) có nghĩa là Legacy BIOS
            // ERROR_NOACCESS (998) hoặc các lỗi khác thường xuất hiện trên UEFI khi tham số truyền vào trống
            if (lastError == 1)
            {
                return false; // Legacy BIOS
            }

            return true; // UEFI
        }

        private void btnuefi_Click(object sender, EventArgs e)
        {
            if (IsUefiMode())
            {
                MessageBox.Show("Your computer supports UEFI! You can use the command to boot into BIOS.",
                                "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnuefi.Enabled = false;
                btncommand.Enabled = true;
                btncommand.PerformClick(); //gọi sự kiện btncommand_Click
            }
            else
            {
                MessageBox.Show("The computer is running Legacy BIOS. The '/fw' command will NOT work.",
                                "Hardware Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); //thoát ứng dụng
            }
        }

        private void btncommand_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra lại lần cuối xem máy có thực sự hỗ trợ UEFI không
            // (Để tránh trường hợp người dùng chưa ấn Button 2 mà đã ấn thẳng Button 3)
            if (!IsUefiMode())
            {
                MessageBox.Show(
                    "Oops! The system detected that your computer is running in Legacy BIOS mode.\n"
                    + " The command to access Firmware (/fw) will not work on this machine",
                    "Hardware not supported",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            // 2. Cảnh báo người dùng lưu dữ liệu
            DialogResult confirm = MessageBox.Show(
                "The computer will restart and enter the BIOS now.\n\n" +
                "Note: You must SAVE ALL open documents..\n" +
                "Are you sure you want to proceed?",
                "Confirm BIOS Restart",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // Mặc định chọn 'No' để an toàn

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // 3. Thực thi lệnh hệ thống một cách chuyên nghiệp
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown.exe",
                        Arguments = "/r /fw /t 1", // Khởi động lại / Vào Firmware / Sau 1 giây
                        CreateNoWindow = true,      // Không hiện cửa sổ CMD đen
                        UseShellExecute = false,    // Chạy trực tiếp tiến trình
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process.Start(startInfo);

                    // Tùy chọn: Thoát ứng dụng sau khi lệnh đã phát đi
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred while executing the command." + ex.Message,
                        "System Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
