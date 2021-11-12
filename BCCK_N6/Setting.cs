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
    public partial class Setting : Form
    {
        public static Account Account = new Account();
        public static User User = new User();
        public Setting(Account account)
        {
            InitializeComponent();
            Account = account;
            GetUserInfo();
        }

        #region Method
        public static bool IsClicked;
        public void GetUserInfo()
        {
            User = UserDAO.Instance.GetUserInfo(Account.userName);
        }

        //delete Users where Username = 'dinhlocpisces'
        //delete Account where Username = 'dinhlocpisces'
        public void Info()
        {
            txtFullname.Text = User.fullName;

            txtBirth.Text = Checking.Instance.CheckBirth(User.birth);

            txtAddress.Text = User.address;

            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            string tmp1 = User.phone;
            txtPhone.Text = AesOperation.Instance.DecryptString(key, tmp1);

            string tmp2 = User.email;
            txtEmail.Text = AesOperation.Instance.DecryptString(key, tmp2);
        }

        public void Enable()
        {
            txtFullname.Enabled = true;
            txtBirth.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            btnCancel.Enabled = true;
            btnOk.Enabled = true;
            btnOk.Show();
            btnCancel.Show();
        }

        public void Disable()
        {
            txtFullname.Enabled = false;
            txtBirth.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            btnCancel.Enabled = false;
            btnOk.Enabled = false;
            btnOk.Hide();
            btnCancel.Hide();
        }
        public void ReplacetmpValues(string userName)
        {
            UserDAO.Instance.ReplaceAtmpValues(userName);
        }
        public bool ExistsEmail(string email)
        {
            return UserDAO.Instance.ExistsEmail(email);
        }

        public bool ExesitsPhone(string phone)
        {
            return UserDAO.Instance.ExistsPhone(phone);
        }
        #endregion

        #region Event
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Info();
            if (!IsClicked)
            {
                this.pnInfo.Show();
                this.Size = new System.Drawing.Size(500, 650);
                IsClicked = !IsClicked;
            }
            else
            {
                this.pnInfo.Hide();
                this.Size = new System.Drawing.Size(500, 250);
                Disable();
                IsClicked = !IsClicked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Info();
            Disable();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string userName = Account.userName;

            string fullName = txtFullname.Text;

            string birth = Checking.Instance.CheckBirth(txtBirth.Text);

            string address = txtAddress.Text;

            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            ReplacetmpValues(userName);
            string phone = AesOperation.Instance.EncryptString(key, txtPhone.Text);
            if (ExesitsPhone(phone))
            {
                alert.Show("Số điện thoại đã được sử dụng! \nVui lòng thử lại!", alert.AlertType.error);
                return;
            }

            Checking.Instance.CheckEmail(txtEmail.Text);
            if (string.Equals(txtEmail.Text, "Example@gmail.com"))
            {
                alert.Show("Email của bạn không đúng! \nVui lòng thử lại!", alert.AlertType.error);
                return;
            }
            string tmp = txtEmail.Text;
            string email = AesOperation.Instance.EncryptString(key, tmp);
            if (ExistsEmail(email))
            {
                alert.Show("Email đã được sử dụng! \nVui lòng thử lại!", alert.AlertType.error);
                return;
            }

            bool Done = UserDAO.Instance.UpdateInfo(userName, fullName, birth, address, phone, email);
            if (Done)
            {
                GetUserInfo();
                Info();
                Disable();
                alert.Show("Thay đổi thành công!", alert.AlertType.success);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            IsClicked = false;
            Disable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ResetPassword tmp = new ResetPassword(Account, true);
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
