namespace frmbiosaccess
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblwin = new System.Windows.Forms.Label();
            this.btnos = new System.Windows.Forms.Button();
            this.btnuefi = new System.Windows.Forms.Button();
            this.btncommand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltitle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncommand);
            this.groupBox2.Controls.Add(this.btnuefi);
            this.groupBox2.Controls.Add(this.btnos);
            this.groupBox2.Location = new System.Drawing.Point(2, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblwin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(74, 31);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(57, 20);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "label1";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwin
            // 
            this.lblwin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblwin.AutoSize = true;
            this.lblwin.Location = new System.Drawing.Point(54, 30);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(50, 16);
            this.lblwin.TabIndex = 1;
            this.lblwin.Text = "label2";
            this.lblwin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnos
            // 
            this.btnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnos.Location = new System.Drawing.Point(162, 19);
            this.btnos.Name = "btnos";
            this.btnos.Size = new System.Drawing.Size(108, 39);
            this.btnos.TabIndex = 0;
            this.btnos.Text = "Operating System Check";
            this.btnos.UseVisualStyleBackColor = true;
            this.btnos.Click += new System.EventHandler(this.btnos_Click);
            // 
            // btnuefi
            // 
            this.btnuefi.Enabled = false;
            this.btnuefi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuefi.Location = new System.Drawing.Point(162, 64);
            this.btnuefi.Name = "btnuefi";
            this.btnuefi.Size = new System.Drawing.Size(108, 39);
            this.btnuefi.TabIndex = 1;
            this.btnuefi.Text = "UEFI Support Check";
            this.btnuefi.UseVisualStyleBackColor = true;
            this.btnuefi.Click += new System.EventHandler(this.btnuefi_Click);
            // 
            // btncommand
            // 
            this.btncommand.Enabled = false;
            this.btncommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommand.Location = new System.Drawing.Point(162, 109);
            this.btncommand.Name = "btncommand";
            this.btncommand.Size = new System.Drawing.Size(108, 39);
            this.btncommand.TabIndex = 2;
            this.btncommand.Text = "Command";
            this.btncommand.UseVisualStyleBackColor = true;
            this.btncommand.Click += new System.EventHandler(this.btncommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 323);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(482, 362);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 362);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblwin;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btncommand;
        private System.Windows.Forms.Button btnuefi;
        private System.Windows.Forms.Button btnos;
    }
}

