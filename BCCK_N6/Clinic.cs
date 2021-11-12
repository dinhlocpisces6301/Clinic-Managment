using BCCK_N6.DAO;
using BCCK_N6.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace BCCK_N6
{
    public partial class Clinic : Form
    {
        public static Account Account = new Account();
        public static User User = new User();
        public Clinic(Account account)
        {
            InitializeComponent();
            Account = account;
            GetUserInfo();
        }

        public void GetUserInfo()
        {
            User = UserDAO.Instance.GetUserInfo(Account.userName);
        }

        static List<Patient> patientList = new List<Patient>();
        public void GetPatientList()
        {
            patientList = PatientDAO.Instance.GetPatientList();
        }

        public bool UpdatePatientInfo(int ID, string dateExam, string fullName, string birth, string address, string phone, string diagnose, string medicine)
        {
            return PatientDAO.Instance.UpdatePatientInfo(ID, dateExam, fullName, birth, address, phone, diagnose, medicine);
        }

        public bool AddPatient(int ID, string dateExam, string fullName, string birth, string address, string phone, string diagnose, string medicine)
        {
            return PatientDAO.Instance.AddPatient(ID, dateExam, fullName, birth, address, phone, diagnose, medicine);
        }

        public bool DeletePatient(int ID, string dateExam)
        {
            return PatientDAO.Instance.DeletePatient(ID, dateExam);
        }

        public int GetOrderOfExam(string dateExam)
        {
            return PatientDAO.Instance.GetOrderOfExam(dateExam);
        }

        public void AddItemToListview(List<Patient> patients)
        {
            listView1.Items.Clear();
            foreach (Patient patient in patients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = patient.ID.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = patient.date });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = patient.fullName });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = patient.birth });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = patient.address });

                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                string phone = AesOperation.Instance.DecryptString(key, patient.phone);

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = phone });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = patient.diagnose });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = patient.medicine });
                listView1.Items.Add(item);
            }
        }

        static double price = 0;
        public string GetMedicinePrescription()
        {
            price = 0;
            string tmp = "";
            foreach (ListViewItem item in lstViewMed.Items)
            {
                tmp += "+ " + item.SubItems[0].Text + ": " + item.SubItems[1].Text + ";" + Environment.NewLine;
                price += double.Parse(item.SubItems[2].Text);
            }
            return tmp;
        }

        public static List<Medicine> medicineList = new List<Medicine>();
        public void GetMedicineList()
        {
            medicineList = MedicineDAO.Intance.GetMedicineList();
        }

        void WordCreate()
        {
            if (ckbPhysicsExam.Checked)
                price += 150000;

            string tmp = txtdateExam.Text.Replace("/", "_") + "_" + txtID.Text + "_" + txtPName.Text.Replace(" ", "_");
            string fileName = @"D:\data\" + tmp + ".docx";

            var doc = DocX.Create(fileName);
            string Brand = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM" + Environment.NewLine
                         + "Độc lập - Tự do - Hạnh Phúc" + Environment.NewLine
                         + "-----***-----";
            Formatting brandFormat = new Formatting();
            brandFormat.FontFamily = new Xceed.Document.NET.Font("Time new roman");
            brandFormat.Size = 16D;
            brandFormat.Bold = true;

            String Tilte = "HÓA ĐƠN KHÁM BỆNH";
            Formatting tilteFormat = new Formatting();
            tilteFormat.FontFamily = new Xceed.Document.NET.Font("Time new roman");
            tilteFormat.Size = 28D;
            tilteFormat.Bold = true;

            string content = "Bác sĩ phụ trách: " + txtDName.Text + Environment.NewLine
                                                                  + Environment.NewLine
                            + "Họ tên bệnh nhân: " + txtPName.Text + Environment.NewLine
                            + "Năm sinh: " + txtBirth.Text + Environment.NewLine
                            + "Địa chỉ: " + txtAddress.Text + Environment.NewLine
                            + "Số điện thoại: " + txtPhoneNumber.Text + Environment.NewLine
                                                                      + Environment.NewLine
                            + "Ngày khám: " + txtdateExam.Text +"   STT: " + txtID.Text + Environment.NewLine
                            + "Chuẩn đoán: " + txtDiagnose.Text + Environment.NewLine
                                                                + Environment.NewLine
                            + "Toa thuốc: " + Environment.NewLine + txtMedicine.Text 
                                                               + Environment.NewLine
                            + "Tiền phải thanh toán: " + price.ToString() + Environment.NewLine
                                                                          + Environment.NewLine;
            string Notice = "Bệnh nhân khi sử dụng thuốc, nếu có các triệu chứng nặng hơn hoặc không khỏi có thể tái khám để được điều trị kịp thời!" + Environment.NewLine
                                                                                                                                          + Environment.NewLine
                          + "Cảm ơn quý khách đã tin tưởng và lựa chọn DoubleL!" + Environment.NewLine
                          + "Nếu có thắc mắc hay cần tư vấn, quý khách có thể liên với chúng tôi" + Environment.NewLine
                          + "Hotline: 1900 1080" + Environment.NewLine
                          + "Phone/Fax: 096 981 9201 " + Environment.NewLine
                          + "_______________________________________________________";
            Formatting contentFormat = new Formatting();
            contentFormat.FontFamily = new Xceed.Document.NET.Font("Time new roman");
            contentFormat.Size = 16D;
            contentFormat.Spacing = 0.1;

            Paragraph paragraphBrand = doc.InsertParagraph(Brand, false, brandFormat);
            paragraphBrand.Alignment = Alignment.center;
            doc.InsertParagraph(Environment.NewLine);
            Paragraph paragraphTilte = doc.InsertParagraph(Tilte, false, tilteFormat);
            paragraphTilte.Alignment = Alignment.center;
            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(content, false, contentFormat);
            Paragraph paragraphNotice = doc.InsertParagraph(Notice, false, contentFormat);
            paragraphNotice.Alignment = Alignment.left;

            doc.SaveAs(fileName);
            Process.Start("WINWORD.EXE", fileName);
            AddRevenue(txtdateExam.Text, price);
            price = 0;
        }

        public bool AddRevenue(string Date, double Deal)
        {
            return RevenueDAO.Instance.AddDeal(Date, Deal);
        }

        private void Btclear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPName.Text = "";
            txtBirth.Text = "";
            txtAddress.Text = "";
            txtDiagnose.Text = "";
            txtPhoneNumber.Text = "";
            txtNumberMedicine.Text = "";
            txtMedicine.Text = "";
            pnMedicine.Hide();
            pnMedicine.Enabled = false;
            btnPaid.Enabled = true;
            price = 0;
            lstViewMed.Items.Clear();
        }

        private void Clinic_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            pnMedicine.Hide();
            pnMedicine.Enabled = false;
            txtDName.Text = User.fullName;
            txtDName.Enabled = false;
        }

        private void btMedicine_Click(object sender, EventArgs e)
        {
            pnMedicine.Enabled = !pnMedicine.Enabled;
            if (pnMedicine.Enabled)
            {
                GetMedicineList();
                cmbMedicine.DataSource = medicineList;
                cmbMedicine.DisplayMember = "ID";
                pnMedicine.Show();
            }
            else
                pnMedicine.Hide();
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GetPatientList();
            AddItemToListview(patientList);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                return;
            else
            {
                try
                {
                    int ID = Int32.Parse(txtID.Text);
                    string dateExam = txtdateExam.Text;
                    string fullName = txtPName.Text;
                    string birth = txtBirth.Text;
                    string address = txtAddress.Text;
                    var key = "b14ca5898a4e4133bbce2ea2315a1916";
                    string phone = AesOperation.Instance.EncryptString(key, txtPhoneNumber.Text);
                    string diagnose = txtDiagnose.Text;
                    string medicine = txtMedicine.Text;

                    bool success = UpdatePatientInfo(ID, dateExam, fullName, birth, address, phone, diagnose, medicine);

                    if (success)
                    {
                        alert.Show("Cập Nhật Thành Công!", alert.AlertType.success);
                        lstDisplay.Items.Add("Ngày khám: " + dateExam + ", Số thứ tự: " + ID);
                        lstDisplay.Items.Add("Họ tên: " + fullName +  ", chuẩn đoán: " + diagnose);
                        lstDisplay.Items.Add("----------***----------***----------");
                        Btclear_Click(sender, e);
                    }
                    else
                        alert.Show("Cập Nhật Thất Bại!", alert.AlertType.error);
                }
                catch (Exception)
                {
                    alert.Show("Cập Nhật Thất Bại!", alert.AlertType.error);
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtdateExam.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPName.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtBirth.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtPhoneNumber.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtDiagnose.Text = listView1.SelectedItems[0].SubItems[6].Text;
                txtMedicine.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
}

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                if (txtPName.Text == "" || txtBirth.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" || txtDiagnose.Text == "")
                    return;
                else
                {
                    try
                    {
                        string dateExam = txtdateExam.Text;
                        int ID = PatientDAO.Instance.GetOrderOfExam(dateExam);
                        txtID.Text = ID.ToString();
                        string fullName = txtPName.Text;
                        string birth = txtBirth.Text;
                        string address = txtAddress.Text;
                        var key = "b14ca5898a4e4133bbce2ea2315a1916";
                        string phone = AesOperation.Instance.EncryptString(key, txtPhoneNumber.Text);
                        string diagnose = txtDiagnose.Text;
                        string medicine = txtMedicine.Text;
                        bool success = AddPatient(ID, dateExam, fullName, birth, address, phone, diagnose, medicine);
                        if (success)
                        {
                            alert.Show("Thêm Thành Công!", alert.AlertType.success);
                            lstDisplay.Items.Add("Ngày khám: " + dateExam + ", Số thứ tự: " + ID);
                            lstDisplay.Items.Add("Họ tên: " + fullName + ", chuẩn đoán: " + diagnose);
                            lstDisplay.Items.Add("----------***----------***----------");
                        }
                        else
                            alert.Show("Thêm Thất Bại!", alert.AlertType.error);
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
            else
                return;
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            txtMedicine.Text = GetMedicinePrescription();
            btnPaid.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                AddItemToListview(patientList);
                return;
            }

            int choice = cmbSelection.SelectedIndex;
            List<Patient> tmp = new List<Patient>();
            switch (choice)
            {
                case 0:
                    {
                        foreach (Patient patient in patientList)
                        {
                            if (patient.fullName.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(patient);
                        }
                        break;
                    }
                case 1:
                    {
                        foreach (Patient patient in patientList)
                        {
                            if (patient.date.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(patient);
                        }
                        break;
                    }
                default:
                    {
                        foreach (Patient patient in patientList)
                        {
                            if (patient.fullName.ToLower().Contains(txtSearch.Text.ToLower()))
                                tmp.Add(patient);
                        }
                        break;
                    }
            }
            AddItemToListview(tmp);
        }

        public static bool IsDescrease = true;
        private void btnSort_Click(object sender, EventArgs e)
        {
            IsDescrease = !IsDescrease;
            if (IsDescrease)
                this.btnSort.Image = global::BCCK_N6.Properties.Resources.descrease;
            else
                this.btnSort.Image = global::BCCK_N6.Properties.Resources.increase;
            List<Patient> tmp = PatientDAO.Instance.mergeSort<Patient>(patientList, IsDescrease);
            AddItemToListview(tmp);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
                return;
            else
                WordCreate();
        }

        public static int count = 0;
        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (txtNumberMedicine.Text == "")
                alert.Show("Vui lòng nhập số lượng!", alert.AlertType.error);
            else
            {
                Medicine medicine = medicineList[cmbMedicine.SelectedIndex];
                ListViewItem item = new ListViewItem();
                item.Text = medicine.medicineName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtNumberMedicine.Text });
                double price = double.Parse(medicine.price) * double.Parse(txtNumberMedicine.Text);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = price.ToString() });
                lstViewMed.Items.Add(item);
                count++;
            }
        }

        private void BtMinus_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                lstViewMed.Items.RemoveAt(count - 1);
                count--;
            }
            else
                alert.Show("Danh sách rỗng!", alert.AlertType.error);
        }

        private void txtBirth_Validating(object sender, CancelEventArgs e)
        {
            Control ctrBirth = (Control)sender;
            if (ctrBirth.Text.Length > 0)
                if (!char.IsDigit(ctrBirth.Text[ctrBirth.Text.Length - 1]))
                {
                    e.Cancel = true;
                    this.errBirth.SetError(ctrBirth, "Năm sinh không hợp lệ!");
                }
                else
                {
                    e.Cancel = false;
                    this.errBirth.Clear();
                }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            Control ctrSdt = (Control)sender;
            if (ctrSdt.Text.Length > 0)
                if (!char.IsDigit(ctrSdt.Text[ctrSdt.Text.Length - 1]))
                {
                    this.errPhone.SetError(ctrSdt, "Số điện thoại không hợp lệ!");
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    this.errPhone.Clear();
                }
        }

        private void txtNumberMedicine_Validating(object sender, CancelEventArgs e)
        {
            Control ctrSdt = (Control)sender;
            if (ctrSdt.Text.Length > 0)
                if (!char.IsDigit(ctrSdt.Text[ctrSdt.Text.Length - 1]))
                {
                    this.errAmount.SetError(ctrSdt, "Số lượng không hợp lệ!");
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    this.errAmount.Clear();
                }
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                return;
            }
            else
            {
                int ID = Int32.Parse(txtID.Text);
                string dateExam = txtdateExam.Text;
                bool success = DeletePatient(ID, dateExam);
                if (success)
                {
                    Btclear_Click(sender, e);
                    alert.Show("Xóa thành công!", alert.AlertType.success);
                }
                else
                    alert.Show("Xóa thất bại!", alert.AlertType.error);
            }
        }
    }
}
