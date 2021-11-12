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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        #region Method
        public bool CreateAccount(string userName, string passWord, string fullName, string phone, string email)
        {
            return AccountDAO.Instance.CreateAccount(userName, passWord, fullName, phone, email);
        }

        public bool ExistsEmail(string email)
        {
            return UserDAO.Instance.ExistsEmail(email);
        }

        public bool ExistsPhone(string phone)
        {
            return UserDAO.Instance.ExistsPhone(phone);
        }

        public bool ExistsUsername(string userName)
        {
            return UserDAO.Instance.ExistsUsername(userName);
        }
        #endregion

        #region Event
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtName.Text == "" || txtPNumber.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtRePassword.Text == "")
                return;
            else
            {
                string userName = txtUsername.Text;
                if (ExistsUsername(userName))
                {
                    alert.Show("Tên đăng nhập đã được sử dụng! \nVui lòng thử lại!", alert.AlertType.error);
                    return;
                }

                string passWord = MD5Hashing.Instance.GetMD5(txtPassword.Text);

                string fullName = txtName.Text;

                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                string phone = AesOperation.Instance.EncryptString(key, txtPNumber.Text);
                if (ExistsPhone(phone))
                {
                    alert.Show("Số điện thoại đã được sử dụng! \nVui lòng thử lại!", alert.AlertType.error);
                    return;
                }

                string email = Checking.Instance.CheckEmail(txtEmail.Text);
                if (string.Equals(email, "Example@gmail.com"))
                {
                    alert.Show("Email của bạn không đúng! \nVui lòng thử lại!", alert.AlertType.error);
                    return;
                }
                else
                {
                    string tmp = email;
                    email = AesOperation.Instance.EncryptString(key, tmp);
                    if (ExistsEmail(email))
                    {
                        alert.Show("Email đã được sử dụng! \nVui lòng thử lại!", alert.AlertType.error);
                        return;
                    }
                }

                bool success = false;

                if (string.Equals(txtPassword.Text, txtRePassword.Text))
                    success = CreateAccount(userName, passWord, fullName, phone, email);
                else
                {
                    alert.Show("Mật Khẩu Xác Nhận Không Đúng!", alert.AlertType.error);
                    return;
                }

                if (success)
                    alert.Show("Đăng kí thành công!", alert.AlertType.success);
                return;
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
