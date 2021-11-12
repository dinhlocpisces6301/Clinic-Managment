
namespace BCCK_N6
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.BtExit = new System.Windows.Forms.Button();
            this.lbClinic = new System.Windows.Forms.Label();
            this.lbDrug = new System.Windows.Forms.Label();
            this.lbFinance = new System.Windows.Forms.Label();
            this.lbSetting = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnDrug = new System.Windows.Forms.Button();
            this.btnClinic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.Color.White;
            this.BtExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtExit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtExit.Image = global::BCCK_N6.Properties.Resources.CloseIcon;
            this.BtExit.Location = new System.Drawing.Point(658, 12);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(41, 36);
            this.BtExit.TabIndex = 12;
            this.BtExit.UseVisualStyleBackColor = false;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // lbClinic
            // 
            this.lbClinic.AutoSize = true;
            this.lbClinic.Location = new System.Drawing.Point(145, 328);
            this.lbClinic.Name = "lbClinic";
            this.lbClinic.Size = new System.Drawing.Size(113, 22);
            this.lbClinic.TabIndex = 7;
            this.lbClinic.Text = "Phòng khám";
            // 
            // lbDrug
            // 
            this.lbDrug.AutoSize = true;
            this.lbDrug.Location = new System.Drawing.Point(452, 328);
            this.lbDrug.Name = "lbDrug";
            this.lbDrug.Size = new System.Drawing.Size(94, 22);
            this.lbDrug.TabIndex = 15;
            this.lbDrug.Text = "Kho thuốc";
            // 
            // lbFinance
            // 
            this.lbFinance.AutoSize = true;
            this.lbFinance.Location = new System.Drawing.Point(128, 630);
            this.lbFinance.Name = "lbFinance";
            this.lbFinance.Size = new System.Drawing.Size(152, 22);
            this.lbFinance.TabIndex = 17;
            this.lbFinance.Text = "Quản lí Tài chính";
            // 
            // lbSetting
            // 
            this.lbSetting.AutoSize = true;
            this.lbSetting.Location = new System.Drawing.Point(429, 630);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(152, 22);
            this.lbSetting.TabIndex = 19;
            this.lbSetting.Text = "Quản lí tài khoản";
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Image = global::BCCK_N6.Properties.Resources.UserIcon;
            this.btnSetting.Location = new System.Drawing.Point(361, 384);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(280, 280);
            this.btnSetting.TabIndex = 18;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseLeave += new System.EventHandler(this.Setting_MouseLeave);
            this.btnSetting.MouseHover += new System.EventHandler(this.Setting_MouseHover);
            // 
            // btnFinance
            // 
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinance.Image = global::BCCK_N6.Properties.Resources.Finance;
            this.btnFinance.Location = new System.Drawing.Point(61, 384);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(280, 280);
            this.btnFinance.TabIndex = 16;
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            this.btnFinance.MouseLeave += new System.EventHandler(this.Finance_MouseLeave);
            this.btnFinance.MouseHover += new System.EventHandler(this.Finance_MouseHover);
            // 
            // btnDrug
            // 
            this.btnDrug.FlatAppearance.BorderSize = 0;
            this.btnDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrug.Image = ((System.Drawing.Image)(resources.GetObject("btnDrug.Image")));
            this.btnDrug.Location = new System.Drawing.Point(361, 86);
            this.btnDrug.Name = "btnDrug";
            this.btnDrug.Size = new System.Drawing.Size(280, 280);
            this.btnDrug.TabIndex = 14;
            this.btnDrug.UseVisualStyleBackColor = true;
            this.btnDrug.Click += new System.EventHandler(this.btnDrug_Click);
            this.btnDrug.MouseLeave += new System.EventHandler(this.Drug_MouseLeave);
            this.btnDrug.MouseHover += new System.EventHandler(this.Drug_MouseHover);
            // 
            // btnClinic
            // 
            this.btnClinic.FlatAppearance.BorderSize = 0;
            this.btnClinic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClinic.Image = ((System.Drawing.Image)(resources.GetObject("btnClinic.Image")));
            this.btnClinic.Location = new System.Drawing.Point(61, 86);
            this.btnClinic.Name = "btnClinic";
            this.btnClinic.Size = new System.Drawing.Size(280, 280);
            this.btnClinic.TabIndex = 4;
            this.btnClinic.UseVisualStyleBackColor = true;
            this.btnClinic.Click += new System.EventHandler(this.btnClinic_Click);
            this.btnClinic.MouseLeave += new System.EventHandler(this.Record_MouseLeave);
            this.btnClinic.MouseHover += new System.EventHandler(this.Record_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BCCK_N6.Properties.Resources._61802;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 718);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMenu
            // 
            this.AcceptButton = this.btnClinic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BtExit;
            this.ClientSize = new System.Drawing.Size(711, 704);
            this.Controls.Add(this.lbSetting);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lbFinance);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.lbDrug);
            this.Controls.Add(this.btnDrug);
            this.Controls.Add(this.lbClinic);
            this.Controls.Add(this.btnClinic);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClinic;
        private System.Windows.Forms.Label lbClinic;
        private System.Windows.Forms.Button btnDrug;
        private System.Windows.Forms.Label lbDrug;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Label lbFinance;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lbSetting;
    }
}