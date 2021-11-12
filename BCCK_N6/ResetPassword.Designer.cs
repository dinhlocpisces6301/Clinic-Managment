
namespace BCCK_N6
{
    partial class ResetPassword
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.pnNewPass = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ptbComfirm = new System.Windows.Forms.PictureBox();
            this.lbComfirm = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.ptbNewPassword = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.lbEmailorPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTilte = new System.Windows.Forms.Label();
            this.pnCheck = new System.Windows.Forms.Panel();
            this.ptbEmailorPhone = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbTilte = new System.Windows.Forms.PictureBox();
            this.BtExit = new System.Windows.Forms.Button();
            this.pnNewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNewPassword)).BeginInit();
            this.pnCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmailorPhone)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTilte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Turquoise;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(12, 109);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 51);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Kiểm Tra";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.Turquoise;
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnNewPassword.Location = new System.Drawing.Point(146, 241);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(134, 51);
            this.btnNewPassword.TabIndex = 2;
            this.btnNewPassword.Text = "Đổi Mật khẩu";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // pnNewPass
            // 
            this.pnNewPass.Controls.Add(this.btnNewPassword);
            this.pnNewPass.Controls.Add(this.txtConfirm);
            this.pnNewPass.Controls.Add(this.panel4);
            this.pnNewPass.Controls.Add(this.ptbComfirm);
            this.pnNewPass.Controls.Add(this.lbComfirm);
            this.pnNewPass.Controls.Add(this.lbNewPassword);
            this.pnNewPass.Controls.Add(this.txtNewPassword);
            this.pnNewPass.Controls.Add(this.ptbNewPassword);
            this.pnNewPass.Controls.Add(this.panel3);
            this.pnNewPass.Location = new System.Drawing.Point(541, 302);
            this.pnNewPass.Name = "pnNewPass";
            this.pnNewPass.Size = new System.Drawing.Size(453, 306);
            this.pnNewPass.TabIndex = 50;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtConfirm.Location = new System.Drawing.Point(13, 193);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(350, 22);
            this.txtConfirm.TabIndex = 1;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Turquoise;
            this.panel4.Location = new System.Drawing.Point(13, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 5);
            this.panel4.TabIndex = 42;
            // 
            // ptbComfirm
            // 
            this.ptbComfirm.Image = global::BCCK_N6.Properties.Resources.login;
            this.ptbComfirm.Location = new System.Drawing.Point(13, 143);
            this.ptbComfirm.Name = "ptbComfirm";
            this.ptbComfirm.Size = new System.Drawing.Size(44, 42);
            this.ptbComfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbComfirm.TabIndex = 44;
            this.ptbComfirm.TabStop = false;
            // 
            // lbComfirm
            // 
            this.lbComfirm.AutoSize = true;
            this.lbComfirm.BackColor = System.Drawing.SystemColors.Control;
            this.lbComfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComfirm.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbComfirm.Location = new System.Drawing.Point(63, 163);
            this.lbComfirm.Name = "lbComfirm";
            this.lbComfirm.Size = new System.Drawing.Size(184, 22);
            this.lbComfirm.TabIndex = 43;
            this.lbComfirm.Text = "Xác Nhận Mật Khẩu:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbNewPassword.Location = new System.Drawing.Point(63, 42);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(186, 22);
            this.lbNewPassword.TabIndex = 41;
            this.lbNewPassword.Text = "Nhập Mật Khẩu Mới:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtNewPassword.Location = new System.Drawing.Point(13, 73);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(350, 22);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // ptbNewPassword
            // 
            this.ptbNewPassword.Image = global::BCCK_N6.Properties.Resources.ec2b84e77ab4151cc544d99c61d75c63;
            this.ptbNewPassword.Location = new System.Drawing.Point(13, 22);
            this.ptbNewPassword.Name = "ptbNewPassword";
            this.ptbNewPassword.Size = new System.Drawing.Size(44, 42);
            this.ptbNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNewPassword.TabIndex = 39;
            this.ptbNewPassword.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Location = new System.Drawing.Point(13, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 5);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Location = new System.Drawing.Point(12, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 5);
            this.panel2.TabIndex = 36;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TxtPassword.Location = new System.Drawing.Point(12, 62);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(350, 22);
            this.TxtPassword.TabIndex = 0;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // lbEmailorPhone
            // 
            this.lbEmailorPhone.AutoSize = true;
            this.lbEmailorPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lbEmailorPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailorPhone.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbEmailorPhone.Location = new System.Drawing.Point(62, 31);
            this.lbEmailorPhone.Name = "lbEmailorPhone";
            this.lbEmailorPhone.Size = new System.Drawing.Size(223, 22);
            this.lbEmailorPhone.TabIndex = 36;
            this.lbEmailorPhone.Text = "Nhập Mật Khẩu Hiện Tại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(548, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "Đổi Mật Khẩu";
            // 
            // lbTilte
            // 
            this.lbTilte.AutoSize = true;
            this.lbTilte.BackColor = System.Drawing.Color.Turquoise;
            this.lbTilte.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTilte.ForeColor = System.Drawing.Color.White;
            this.lbTilte.Location = new System.Drawing.Point(18, 69);
            this.lbTilte.Name = "lbTilte";
            this.lbTilte.Size = new System.Drawing.Size(469, 42);
            this.lbTilte.TabIndex = 3;
            this.lbTilte.Text = "PHÒNG KHÁM ĐA KHOA";
            // 
            // pnCheck
            // 
            this.pnCheck.Controls.Add(this.btnCheck);
            this.pnCheck.Controls.Add(this.panel2);
            this.pnCheck.Controls.Add(this.TxtPassword);
            this.pnCheck.Controls.Add(this.lbEmailorPhone);
            this.pnCheck.Controls.Add(this.ptbEmailorPhone);
            this.pnCheck.Location = new System.Drawing.Point(541, 119);
            this.pnCheck.Name = "pnCheck";
            this.pnCheck.Size = new System.Drawing.Size(452, 173);
            this.pnCheck.TabIndex = 48;
            // 
            // ptbEmailorPhone
            // 
            this.ptbEmailorPhone.Image = global::BCCK_N6.Properties.Resources.icons8_keepass_50;
            this.ptbEmailorPhone.Location = new System.Drawing.Point(12, 11);
            this.ptbEmailorPhone.Name = "ptbEmailorPhone";
            this.ptbEmailorPhone.Size = new System.Drawing.Size(44, 42);
            this.ptbEmailorPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEmailorPhone.TabIndex = 32;
            this.ptbEmailorPhone.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.ptbTilte);
            this.panel1.Controls.Add(this.lbTilte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 608);
            this.panel1.TabIndex = 49;
            // 
            // ptbTilte
            // 
            this.ptbTilte.BackColor = System.Drawing.Color.Turquoise;
            this.ptbTilte.Image = global::BCCK_N6.Properties.Resources.twitter_profile_image;
            this.ptbTilte.Location = new System.Drawing.Point(92, 151);
            this.ptbTilte.Name = "ptbTilte";
            this.ptbTilte.Size = new System.Drawing.Size(326, 308);
            this.ptbTilte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTilte.TabIndex = 5;
            this.ptbTilte.TabStop = false;
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.Color.White;
            this.BtExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtExit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtExit.Image = global::BCCK_N6.Properties.Resources.CloseIcon2;
            this.BtExit.Location = new System.Drawing.Point(945, 12);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(40, 40);
            this.BtExit.TabIndex = 52;
            this.BtExit.UseVisualStyleBackColor = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 608);
            this.Controls.Add(this.pnNewPass);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnCheck);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.pnNewPass.ResumeLayout(false);
            this.pnNewPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNewPassword)).EndInit();
            this.pnCheck.ResumeLayout(false);
            this.pnCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmailorPhone)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTilte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Panel pnNewPass;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ptbComfirm;
        private System.Windows.Forms.Label lbComfirm;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox ptbNewPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label lbEmailorPhone;
        private System.Windows.Forms.PictureBox ptbEmailorPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbTilte;
        private System.Windows.Forms.Label lbTilte;
        private System.Windows.Forms.Panel pnCheck;
        private System.Windows.Forms.Panel panel1;
    }
}