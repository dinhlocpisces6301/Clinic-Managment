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
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        #region Method
        public static List<Medicine> medicineList = new List<Medicine>();
        public void GetMedicineList()
        {
            medicineList = MedicineDAO.Intance.GetMedicineList();
        }

        public bool UpdateMedicineInfo(string ID, string medicineName, string price, int number)
        {
            return MedicineDAO.Intance.UpdateMedicineInfo(ID, medicineName, price, number);
        }

        public bool DeleteMedicine(string ID)
        {
            return MedicineDAO.Intance.DeleteMedicine(ID);
        }

        public bool AddMedicine(string ID, string medicineName, string price, int number)
        {
            return MedicineDAO.Intance.AddMedicine(ID, medicineName, price, number);
        }

        public void AddItemToListview(List<Medicine> medicines)
        {
            listView1.Items.Clear();
            foreach (Medicine medicine in medicines)
            {
                ListViewItem item = new ListViewItem();
                item.Text = medicine.ID;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = medicine.medicineName });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = medicine.price });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = medicine.number });
                listView1.Items.Add(item);
            }
        }
        #endregion

        #region Event
        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GetMedicineList();
            AddItemToListview(medicineList);
        }

        public static bool IsDescrease = true;
        private void btnSort_Click(object sender, EventArgs e)
        {
            IsDescrease = !IsDescrease;
            if (IsDescrease)
                this.btnSort.Image = global::BCCK_N6.Properties.Resources.descrease;
            else
                this.btnSort.Image = global::BCCK_N6.Properties.Resources.increase;
            List<Medicine> tmp = MedicineDAO.Intance.mergeSort<Medicine>(medicineList, IsDescrease);
            AddItemToListview(tmp);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                AddItemToListview(medicineList);
                return;
            }

            int choice = cmbSelection.SelectedIndex;
            List<Medicine> tmp = new List<Medicine>();
            switch (choice)
            {
                case 0:
                    {
                        foreach (Medicine medicine in medicineList)
                        {
                            if (medicine.ID.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(medicine);
                        }
                        break;
                    }
                case 1:
                    {
                        foreach (Medicine medicine in medicineList)
                        {
                            if (medicine.medicineName.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(medicine);
                        }
                        break;
                    }
                default:
                    {
                        foreach(Medicine medicine in medicineList)
                        {
                            if (medicine.ID.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(medicine);
                        }
                        break;
                    }
            }
            AddItemToListview(tmp);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtMName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtAmount.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            catch(ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtMName.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = "";
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtMName.Text == "" || txtPrice.Text == "" || txtAmount.Text == "")
            {
                return;
            }
            else
            {
                string ID = txtID.Text;
                string MedName = txtMName.Text;
                string Price = txtPrice.Text;
                int Number = Int32.Parse(txtAmount.Text);
                bool success = UpdateMedicineInfo(ID, MedName, Price, Number);
                if (success)
                    alert.Show("Thay đổi thành công!", alert.AlertType.success);
                else
                    alert.Show("Thay đổi thất bại! \nLoại thuốc này không tồn tại!", alert.AlertType.error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtMName.Text == "" || txtPrice.Text == "" || txtAmount.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    string ID = txtID.Text;
                    string MedName = txtMName.Text;
                    string Price = txtPrice.Text;
                    int Number = Int32.Parse(txtAmount.Text);
                    bool success = AddMedicine(ID, MedName, Price, Number);
                    if (success)
                        alert.Show("Thêm thành công!", alert.AlertType.success);
                    else
                        alert.Show("Thêm thất bại! \nMã thuốc đã tồn tại!", alert.AlertType.error);
                }
                catch(Exception)
                {
                    alert.Show("Thêm thất bại! \nMã thuốc đã tồn tại!", alert.AlertType.error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtMName.Text == "" || txtPrice.Text == "" || txtAmount.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    string ID = listView1.SelectedItems[0].Text;

                    bool success = DeleteMedicine(ID);
                    if (success)
                        alert.Show("Xóa thành công!", alert.AlertType.success);
                    else
                        alert.Show("Xóa thất bại!", alert.AlertType.error);
                }
                catch(ArgumentOutOfRangeException)
                {
                    alert.Show("Vui lòng chọn loại thuốc muốn xóa!", alert.AlertType.error);
                }
            }
        }
        #endregion
    }
}
