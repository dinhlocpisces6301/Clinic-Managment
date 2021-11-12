using BCCK_N6.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;

namespace BCCK_N6
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public static List<Account> accountList = new List<Account>();

        #region Method
        public void GetAccountList()
        {
            accountList.Clear();
            accountList = AccountDAO.Instance.mergeSort<Account>(AccountDAO.Instance.GetAccountList());
        }
        #endregion

        #region Event
        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassword.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void lbForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword tmp = new ForgetPassword();
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                return;
            else
            {
                GetAccountList();

                string username = txtUsername.Text;
                string password = MD5Hashing.Instance.GetMD5(txtPassword.Text);

                int pos = AccountDAO.Instance.binarySearch<Account>(accountList, 0, accountList.Count - 1, new Account(username));

                if (pos >= 0)
                {
                    Account tmpacc = accountList[pos];
                    if (String.Equals(password, tmpacc.passWord))
                    {
                        alert.Show("Đăng Nhập Thành Công!", alert.AlertType.success);
                        if (tmpacc.typeAcc == 0)
                        {
                            AdminMenu tmp = new AdminMenu(tmpacc);
                            this.Hide();
                            tmp.ShowDialog();
                             this.Show();
                            
                        }
                        else
                        {
                            Menu tmp = new Menu(tmpacc);
                            
                            this.Hide();
                            tmp.ShowDialog();
                            this.Show();
                        }
                    }
                    else alert.Show("Sai Mật Khẩu!", alert.AlertType.error);
                }
                else alert.Show("Tài Khoản Không Tồn Tại", alert.AlertType.error);
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword tmp = new ForgetPassword();
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
