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
    public partial class Menu : Form
    {
        public static Account Account = new Account();
        public Menu(Account account)
        {
            InitializeComponent();
            Account = account;
        }

        #region Event
        private void Menu_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => {
                this.Invoke(new Action(() => {
                    lbClinic.Hide();
                    lbDrug.Hide();
                    lbSetting.Hide();
                    lbFinance.Hide();
                }));
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void Record_MouseHover(object sender, EventArgs e)
        {
            lbClinic.Show();
        }
        private void Record_MouseLeave(object sender, EventArgs e)
        {
            lbClinic.Hide();
        }

        private void Drug_MouseHover(object sender, EventArgs e)
        {
            lbDrug.Show();
        }
        private void Drug_MouseLeave(object sender, EventArgs e)
        {
            lbDrug.Hide();
        }

        private void Finance_MouseHover(object sender, EventArgs e)
        {
            lbFinance.Show();
        }
        private void Finance_MouseLeave(object sender, EventArgs e)
        {
            lbFinance.Hide();
        }

        private void Setting_MouseHover(object sender, EventArgs e)
        {
            lbSetting.Show();
        }

        private void Setting_MouseLeave(object sender, EventArgs e)
        {
            lbSetting.Hide();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {
            Storage tmp = new Storage();
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            Clinic tmp = new Clinic(Account);
            this.Hide();
            tmp.ShowDialog();
            this.Show();

        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            Finance tmp = new Finance();
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting tmp = new Setting(Account);
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
