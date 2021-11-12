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
    public partial class ResetPassword : Form
    {
        public static Account Account = new Account();

        public static bool needComfirm;

        public ResetPassword(Account _account, bool _needComfirm = true)
        {
            InitializeComponent();
            Account = _account;
            needComfirm = _needComfirm;
        }

        #region Method
        public bool ChangePassword(string userName, string passWord)
        {
            string HashedpassWord = MD5Hashing.Instance.GetMD5(passWord);
            return AccountDAO.Instance.ChangePassword(userName, HashedpassWord);
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            if (needComfirm)
                pnNewPass.Enabled = false;
            else
                pnCheck.Enabled = false;
        }
        #endregion

        #region Event
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string passWord = MD5Hashing.Instance.GetMD5(TxtPassword.Text);
            if (string.Equals(passWord, Account.passWord))
            {
                pnCheck.Enabled = false;
                pnNewPass.Enabled = true;
            }
            else
                alert.Show("Mật Khẩu Không Đúng!", alert.AlertType.error);
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "" || txtNewPassword.Text == "")
                return;
            else
                if (string.Equals(txtNewPassword.Text, txtConfirm.Text))
            {
                string userName = Account.userName;
                string passWord = txtNewPassword.Text;
                ChangePassword(userName, passWord);
                alert.Show("Thay Đổi Mật Khẩu Thành Công!", alert.AlertType.success);
                this.Close();
            }
            else
                alert.Show("Mật Khẩu Xác Nhận Không Đúng!", alert.AlertType.error);

        }
        #endregion
    }
}
