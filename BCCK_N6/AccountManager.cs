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
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        #region Method
        List<User> userList = new List<User>();
        public void GetUserList()
        {
            userList = UserDAO.Instance.GetUserList();
        }

        public string GetPassword(string userName)
        {
            return AccountDAO.Instance.GetPassword(userName);
        }

        public void AddItemToListview(List<User> users)
        {
            listView1.Items.Clear();
            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem();
                item.Text = user.userName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = user.fullName });
                string passWord = GetPassword(user.userName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = passWord });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = user.birth });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = user.address });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = user.phone });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = user.email });
                listView1.Items.Add(item);
            }
        }

        //public static string UnVietnamese(string text)
        //{
        //    string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
        //                                   "đ",
        //                                   "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
        //                                   "í","ì","ỉ","ĩ","ị",
        //                                   "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
        //                                   "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
        //                                   "ý","ỳ","ỷ","ỹ","ỵ",};
        //    string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
        //                                   "d",
        //                                   "e","e","e","e","e","e","e","e","e","e","e",
        //                                   "i","i","i","i","i",
        //                                   "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
        //                                   "u","u","u","u","u","u","u","u","u","u","u",
        //                                   "y","y","y","y","y",};
        //    for (int i = 0; i < arr1.Length; i++)
        //        text = text.Replace(arr1[i], arr2[i]);
        //    return text;
        //}
        #endregion

        #region Event
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp tmp = new SignUp();
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            SignUp tmp = new SignUp();
            this.Hide();
            tmp.ShowDialog();
            this.Show();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {

        }

        private void BtAll_Click(object sender, EventArgs e)
        {
            GetUserList();
            AddItemToListview(userList);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                AddItemToListview(userList);
                return;
            }

            int choice = cmbSelection.SelectedIndex;
            List<User> tmp = new List<User>();
            switch (choice)
            {
                case 0:
                    {
                        foreach (User user in userList)
                        {
                            if (user.userName.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(user);
                        }
                        break;
                    }
                case 1:
                    {
                        foreach (User user in userList)
                        {
                            if (user.fullName.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(user);
                        }
                        break;
                    }
                default:
                    {
                        foreach (User user in userList)
                        {
                            if (user.userName.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(user);
                        }
                        break;
                    }
            }
            AddItemToListview(tmp);
        }

        public static bool IsDescrease = true;
        private void BtSort_Click(object sender, EventArgs e)
        {
            IsDescrease = !IsDescrease;
            if (IsDescrease)
                this.btnSort.Image = global::BCCK_N6.Properties.Resources.descrease;
            else
                this.btnSort.Image = global::BCCK_N6.Properties.Resources.increase;
            List <User> tmp = UserDAO.Instance.mergeSort<User>(userList, IsDescrease);
            AddItemToListview(tmp);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = listView1.SelectedItems[0].Text;
                if (string.Equals(userName,"admin"))
                    return;
                ResetPassword tmp = new ResetPassword(new Account(userName), false);
                tmp.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                alert.Show("Vui lòng chọn Tài khoản cần đổi mật khẩu!", alert.AlertType.error);
            }
        }
        #endregion
    }
}
