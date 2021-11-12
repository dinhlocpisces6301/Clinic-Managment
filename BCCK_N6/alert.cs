using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCCK_N6
{
    public partial class alert : Form
    {
        public alert(string message,AlertType type)
        {
            InitializeComponent();
            Message.Text = message;
            switch (type)
            {
                case AlertType.success:
                
                        this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;

                case AlertType.error:
                    this.BackColor = Color.Red;
                    icon.Image = imageList1.Images[1];
                    break;
            }
        }
        
        public enum AlertType
        { 
            success,
            error
        }

        private void alert_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {

            this.Visible = false;
        }

        int Interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += Interval;
                Interval += 2;

            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0)
            {
                this.Opacity-=0.1;
            }
            else
            {
                this.Close();
            }
        }

        public static void Show(string message, AlertType type)
        {
            new BCCK_N6.alert(message, type).Show();
        }
    }
}
