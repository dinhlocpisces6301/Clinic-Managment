
namespace BCCK_N6
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowInfo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowInfo.Location = new System.Drawing.Point(97, 20);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(248, 54);
            this.btnShowInfo.TabIndex = 0;
            this.btnShowInfo.Text = "Xem thông tin cá nhân";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnChangePassword.Location = new System.Drawing.Point(97, 92);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(248, 54);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnShowInfo);
            this.panel1.Location = new System.Drawing.Point(32, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 171);
            this.panel1.TabIndex = 1;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.Turquoise;
            this.pnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfo.Controls.Add(this.btnCancel);
            this.pnInfo.Controls.Add(this.btnOk);
            this.pnInfo.Controls.Add(this.btnEdit);
            this.pnInfo.Controls.Add(this.txtEmail);
            this.pnInfo.Controls.Add(this.lbEmail);
            this.pnInfo.Controls.Add(this.txtPhone);
            this.pnInfo.Controls.Add(this.lbPhone);
            this.pnInfo.Controls.Add(this.txtAddress);
            this.pnInfo.Controls.Add(this.lbAddress);
            this.pnInfo.Controls.Add(this.txtBirth);
            this.pnInfo.Controls.Add(this.lbBirth);
            this.pnInfo.Controls.Add(this.txtFullname);
            this.pnInfo.Controls.Add(this.lbFullname);
            this.pnInfo.Location = new System.Drawing.Point(16, 250);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(468, 332);
            this.pnInfo.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::BCCK_N6.Properties.Resources.CancelIcon;
            this.btnCancel.Location = new System.Drawing.Point(388, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 70);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Enabled = false;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Image = global::BCCK_N6.Properties.Resources.ConfirmIcon;
            this.btnOk.Location = new System.Drawing.Point(312, 259);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 70);
            this.btnOk.TabIndex = 11;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = global::BCCK_N6.Properties.Resources.EditIcon;
            this.btnEdit.Location = new System.Drawing.Point(7, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 70);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(141, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 29);
            this.txtEmail.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lbEmail.Location = new System.Drawing.Point(19, 211);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 22);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(141, 166);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lbPhone.Location = new System.Drawing.Point(16, 169);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(121, 22);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "Số điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(141, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(314, 29);
            this.txtAddress.TabIndex = 5;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lbAddress.Location = new System.Drawing.Point(16, 123);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(73, 22);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // txtBirth
            // 
            this.txtBirth.Enabled = false;
            this.txtBirth.Location = new System.Drawing.Point(141, 77);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(96, 29);
            this.txtBirth.TabIndex = 3;
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.BackColor = System.Drawing.SystemColors.Control;
            this.lbBirth.Location = new System.Drawing.Point(16, 80);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(92, 22);
            this.lbBirth.TabIndex = 2;
            this.lbBirth.Text = "Năm sinh:";
            // 
            // txtFullname
            // 
            this.txtFullname.Enabled = false;
            this.txtFullname.Location = new System.Drawing.Point(141, 34);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(292, 29);
            this.txtFullname.TabIndex = 1;
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.BackColor = System.Drawing.SystemColors.Control;
            this.lbFullname.Location = new System.Drawing.Point(16, 37);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(100, 22);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "Họ và Tên:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::BCCK_N6.Properties.Resources.CloseIcon;
            this.btnClose.Location = new System.Drawing.Point(448, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BCCK_N6.Properties.Resources._61802;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Setting";
            this.Text = "CÀI ĐẶT";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Button btnClose;
    }
}