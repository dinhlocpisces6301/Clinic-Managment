
namespace BCCK_N6
{
    partial class AccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManager));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.BtRegister = new System.Windows.Forms.Button();
            this.BtExit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtAll = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUsername,
            this.columnName,
            this.columnPass,
            this.columnBirth,
            this.columnAddress,
            this.columnPhone,
            this.columnEmail});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 234);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(1200, 516);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Tên Tài Khoản";
            this.columnUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUsername.Width = 150;
            // 
            // columnName
            // 
            this.columnName.Text = "Họ và Tên";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 175;
            // 
            // columnPass
            // 
            this.columnPass.Text = "Mật Khẩu";
            this.columnPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPass.Width = 170;
            // 
            // columnBirth
            // 
            this.columnBirth.Text = "Năm Sinh";
            this.columnBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBirth.Width = 100;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Địa Chỉ";
            this.columnAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAddress.Width = 177;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Số Điện Thoại";
            this.columnPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPhone.Width = 210;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEmail.Width = 200;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtSearch.Location = new System.Drawing.Point(437, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(395, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSelection
            // 
            this.cmbSelection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelection.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Items.AddRange(new object[] {
            "Tên Tài Khoản",
            "Họ Tên"});
            this.cmbSelection.Location = new System.Drawing.Point(571, 24);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(222, 27);
            this.cmbSelection.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(433, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search theo :";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnChangePassword.Image = global::BCCK_N6.Properties.Resources.PassChangeIcon;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(642, 113);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(190, 47);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "        Đổi Mật Khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // BtRegister
            // 
            this.BtRegister.BackColor = System.Drawing.SystemColors.Control;
            this.BtRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtRegister.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtRegister.Image = global::BCCK_N6.Properties.Resources.SignUpIcon;
            this.BtRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRegister.Location = new System.Drawing.Point(437, 113);
            this.BtRegister.Name = "BtRegister";
            this.BtRegister.Size = new System.Drawing.Size(174, 47);
            this.BtRegister.TabIndex = 15;
            this.BtRegister.Text = "   Đăng Ký";
            this.BtRegister.UseVisualStyleBackColor = false;
            this.BtRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.Color.White;
            this.BtExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtExit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtExit.Image = global::BCCK_N6.Properties.Resources.CloseIcon1;
            this.BtExit.Location = new System.Drawing.Point(1144, 10);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(41, 36);
            this.BtExit.TabIndex = 14;
            this.BtExit.UseVisualStyleBackColor = false;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::BCCK_N6.Properties.Resources.binoculars;
            this.pictureBox3.Location = new System.Drawing.Point(80, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // BtAll
            // 
            this.BtAll.BackColor = System.Drawing.SystemColors.Control;
            this.BtAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtAll.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtAll.Image = global::BCCK_N6.Properties.Resources.LoadingIcon;
            this.BtAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAll.Location = new System.Drawing.Point(876, 113);
            this.BtAll.Name = "BtAll";
            this.BtAll.Size = new System.Drawing.Size(195, 47);
            this.BtAll.TabIndex = 6;
            this.BtAll.Text = "        Tải Danh Sách";
            this.BtAll.UseVisualStyleBackColor = false;
            this.BtAll.Click += new System.EventHandler(this.BtAll_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.Control;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSort.Image = global::BCCK_N6.Properties.Resources.SortIcon;
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.Location = new System.Drawing.Point(876, 51);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(195, 47);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "       Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.BtSort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BCCK_N6.Properties.Resources._61802;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.BtRegister);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelection);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtAll);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnPass;
        private System.Windows.Forms.ColumnHeader columnBirth;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button BtAll;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Button BtRegister;
        private System.Windows.Forms.Button btnChangePassword;
    }
}