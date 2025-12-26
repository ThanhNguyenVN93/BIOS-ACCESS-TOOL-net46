🚀 UEFI BIOS Firmware Access Tool (x64)
🔐 Main Features
Designed to help users boot directly into the BIOS/UEFI setup interface from the Windows environment. It eliminates the need to "spam" keys like F2, Del, Esc, or F12 during the startup process.

🌟 Other Features
Operating System Check: Automatically identifies the Windows version and architecture (optimized for Windows 8/10/11).

UEFI Support Verification: Uses Win32 API (kernel32.dll) to verify if the machine is running in UEFI mode.

Automation Flow: Streamlines the process by automatically triggering diagnostic steps via PerformClick logic.

Safety First: Includes a confirmation dialog before restarting, with the "No" button selected by default to prevent accidental reboots.

Real-time Interface: Displays a live system clock and detailed OS information on the main form.

🛠 System Requirements
Architecture: Windows x64 (64-bit).

Boot Standard: Requires UEFI; the command will not work on legacy BIOS systems.

Permissions: Must be run as an Administrator to interact with the system firmware.

📂 How to Use

Step 1: Download the tool.

Step 2: Right-click the file and select Run as Administrator.

The application will automatically:

Check if the OS supports the /fw command.

Confirm UEFI hardware support.

Present a confirmation dialog.

Click Yes to allow the computer to restart and enter the BIOS setup.

⚠️ Important Notes
If the tool displays "Hardware Error" or "Unsupported OS", your system is likely running in Legacy BIOS mode or a version of Windows older than 8.

Ensure all open documents are saved before confirming the restart.

In some virtual environments like VMware, you may see a network boot screen (DHCP) before entering the BIOS if no bootable drive is detected in UEFI mode.

📝 Technical Details
Language: C# (.NET Framework).

Core Libraries: System.Management, System.Runtime.InteropServices.

Key Command: shutdown.exe /r /fw /t 1.

Target Architecture: x64.

Developed by Thanh Nguyen - 2025
