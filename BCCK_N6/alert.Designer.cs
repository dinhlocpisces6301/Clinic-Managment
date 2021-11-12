
namespace BCCK_N6
{
    partial class alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert));
            this.Message = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.Transparent;
            this.Message.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(96, 38);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(128, 19);
            this.Message.TabIndex = 1;
            this.Message.Text = "Success Message";
            // 
            // timeout
            // 
            this.timeout.Enabled = true;
            this.timeout.Interval = 5000;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // show
            // 
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_ok_50px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_error_50px.png");
            // 
            // icon
            // 
            this.icon.Image = global::BCCK_N6.Properties.Resources.icons8_ok_50px;
            this.icon.Location = new System.Drawing.Point(40, 21);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BCCK_N6.Properties.Resources.icons8_cancel_25px_2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(362, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(411, 94);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alert";
            this.Text = "alert";
            this.Load += new System.EventHandler(this.alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Timer close;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox icon;
    }
}