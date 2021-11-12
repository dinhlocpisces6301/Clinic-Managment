using BCCK_N6.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCCK_N6
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        #region Method
        public static User user = new User();

        public bool CheckAccount(string check)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            string tmp = AesOperation.Instance.EncryptString(key, check);
            try
            {
                if (rbtnEmail.Checked == true)
                    user = UserDAO.Instance.CheckAccount(tmp, 0);
                if (rbtnPhone.Checked == true)
                    user = UserDAO.Instance.CheckAccount(tmp, 1);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                alert.Show("Email hoặc Số điện thoại chưa được đăng kí!", alert.AlertType.error);
                return false;
            }
        }

        public bool ChangePassword(string userName, string passWord)
        {
            string HashedPass = MD5Hashing.Instance.GetMD5(passWord);
            return AccountDAO.Instance.ChangePassword(userName, HashedPass);
        }
        #endregion

        #region Event
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            pnNewPass.Hide();
        }

        private void BtExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtEmailorPhone.Text == "")
                return;
            else
            {
                if (CheckAccount(txtEmailorPhone.Text))
                {
                    pnNewPass.Show();
                    pnCheck.Enabled = false;
                }
            }
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtConfirm.Text == "")
                return;
            else
                if (string.Equals(txtNewPassword.Text, txtConfirm.Text))
            {
                string userName = user.userName;
                string passWord = txtNewPassword.Text;
                ChangePassword(userName, passWord);
                alert.Show("Thay Đổi Thành Công!", alert.AlertType.success);
                this.Close();
            }
            else
                alert.Show("Mật Khẩu Xác Nhận Sai!", alert.AlertType.error);
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
