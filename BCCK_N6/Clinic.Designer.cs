
namespace BCCK_N6
{
    partial class Clinic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clinic));
            this.lbD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNamSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiagnose = new System.Windows.Forms.TextBox();
            this.ckbPhysicsExam = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnMedicine = new System.Windows.Forms.Panel();
            this.btnPaid = new System.Windows.Forms.Button();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.BtMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumberMedicine = new System.Windows.Forms.TextBox();
            this.lstViewMed = new System.Windows.Forms.ListView();
            this.columnMName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errBirth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbDateExam = new System.Windows.Forms.Label();
            this.txtdateExam = new System.Windows.Forms.DateTimePicker();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.Btclear = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbSelection = new System.Windows.Forms.Label();
            this.cmbSelection = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.errAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.pnMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.BackColor = System.Drawing.SystemColors.Control;
            this.lbD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbD.Location = new System.Drawing.Point(48, 182);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(220, 26);
            this.lbD.TabIndex = 9;
            this.lbD.Text = "NHẬP THÔNG TIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(588, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(969, 106);
            this.label1.TabIndex = 10;
            this.label1.Text = "DOUBLE L MANAGEMENT";
            // 
            // lstDisplay
            // 
            this.lstDisplay.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 22;
            this.lstDisplay.Location = new System.Drawing.Point(910, 183);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.ScrollAlwaysVisible = true;
            this.lstDisplay.Size = new System.Drawing.Size(982, 158);
            this.lstDisplay.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMa,
            this.columnDate,
            this.columnHoTen,
            this.columnNamSinh,
            this.columnDC,
            this.columnSDT,
            this.columnCD,
            this.columnDT});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(910, 525);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(982, 442);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnMa
            // 
            this.columnMa.Text = "STT";
            this.columnMa.Width = 51;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Ngày Khám";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 100;
            // 
            // columnHoTen
            // 
            this.columnHoTen.Text = "Họ Tên";
            this.columnHoTen.Width = 175;
            // 
            // columnNamSinh
            // 
            this.columnNamSinh.Text = "Năm Sinh";
            this.columnNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNamSinh.Width = 90;
            // 
            // columnDC
            // 
            this.columnDC.Text = "Địa Chỉ";
            this.columnDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDC.Width = 100;
            // 
            // columnSDT
            // 
            this.columnSDT.Text = "Số Điện Thoại";
            this.columnSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSDT.Width = 120;
            // 
            // columnCD
            // 
            this.columnCD.Text = "Chẩn Đoán";
            this.columnCD.Width = 150;
            // 
            // columnDT
            // 
            this.columnDT.Text = "Đơn Thuốc";
            this.columnDT.Width = 1000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(49, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Bác Sĩ:";
            // 
            // txtDName
            // 
            this.txtDName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtDName.Location = new System.Drawing.Point(216, 238);
            this.txtDName.Name = "txtDName";
            this.txtDName.ReadOnly = true;
            this.txtDName.Size = new System.Drawing.Size(355, 29);
            this.txtDName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(49, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Bệnh Nhân:";
            // 
            // txtPName
            // 
            this.txtPName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtPName.Location = new System.Drawing.Point(216, 294);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(355, 29);
            this.txtPName.TabIndex = 1;
            // 
            // txtBirth
            // 
            this.txtBirth.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtBirth.Location = new System.Drawing.Point(216, 353);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(141, 29);
            this.txtBirth.TabIndex = 2;
            this.txtBirth.Validating += new System.ComponentModel.CancelEventHandler(this.txtBirth_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(49, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Năm Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(49, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(49, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Điện Thoại:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtPhoneNumber.Location = new System.Drawing.Point(216, 475);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 29);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtAddress.Location = new System.Drawing.Point(216, 410);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(355, 29);
            this.txtAddress.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(49, 583);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Chẩn Đoán:";
            // 
            // txtDiagnose
            // 
            this.txtDiagnose.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtDiagnose.Location = new System.Drawing.Point(216, 583);
            this.txtDiagnose.Name = "txtDiagnose";
            this.txtDiagnose.Size = new System.Drawing.Size(355, 29);
            this.txtDiagnose.TabIndex = 6;
            // 
            // ckbPhysicsExam
            // 
            this.ckbPhysicsExam.AutoSize = true;
            this.ckbPhysicsExam.BackColor = System.Drawing.SystemColors.Control;
            this.ckbPhysicsExam.Checked = true;
            this.ckbPhysicsExam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPhysicsExam.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ckbPhysicsExam.Location = new System.Drawing.Point(87, 689);
            this.ckbPhysicsExam.Name = "ckbPhysicsExam";
            this.ckbPhysicsExam.Size = new System.Drawing.Size(247, 26);
            this.ckbPhysicsExam.TabIndex = 8;
            this.ckbPhysicsExam.Text = "Khám Tổng Quát: 150.000";
            this.ckbPhysicsExam.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(49, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Toa Thuốc:";
            // 
            // pnMedicine
            // 
            this.pnMedicine.BackColor = System.Drawing.SystemColors.Control;
            this.pnMedicine.Controls.Add(this.btnPaid);
            this.pnMedicine.Controls.Add(this.txtMedicine);
            this.pnMedicine.Controls.Add(this.BtMinus);
            this.pnMedicine.Controls.Add(this.btnAdd);
            this.pnMedicine.Controls.Add(this.label10);
            this.pnMedicine.Controls.Add(this.cmbMedicine);
            this.pnMedicine.Controls.Add(this.label9);
            this.pnMedicine.Controls.Add(this.txtNumberMedicine);
            this.pnMedicine.Controls.Add(this.lstViewMed);
            this.pnMedicine.Location = new System.Drawing.Point(340, 628);
            this.pnMedicine.Name = "pnMedicine";
            this.pnMedicine.Size = new System.Drawing.Size(488, 421);
            this.pnMedicine.TabIndex = 10;
            // 
            // btnPaid
            // 
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaid.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPaid.Image = global::BCCK_N6.Properties.Resources.PaidIcon;
            this.btnPaid.Location = new System.Drawing.Point(414, 264);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(45, 45);
            this.btnPaid.TabIndex = 49;
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // txtMedicine
            // 
            this.txtMedicine.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtMedicine.Location = new System.Drawing.Point(13, 332);
            this.txtMedicine.Multiline = true;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(459, 86);
            this.txtMedicine.TabIndex = 48;
            // 
            // BtMinus
            // 
            this.BtMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtMinus.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMinus.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtMinus.Image = global::BCCK_N6.Properties.Resources.MinusIcon;
            this.BtMinus.Location = new System.Drawing.Point(414, 162);
            this.BtMinus.Name = "BtMinus";
            this.BtMinus.Size = new System.Drawing.Size(45, 45);
            this.BtMinus.TabIndex = 40;
            this.BtMinus.UseVisualStyleBackColor = true;
            this.BtMinus.Click += new System.EventHandler(this.BtMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Image = global::BCCK_N6.Properties.Resources.PlusIcon;
            this.btnAdd.Location = new System.Drawing.Point(414, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Location = new System.Drawing.Point(21, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Loại Thuốc:";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(25, 40);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(242, 30);
            this.cmbMedicine.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(302, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Số Lượng:";
            // 
            // txtNumberMedicine
            // 
            this.txtNumberMedicine.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtNumberMedicine.Location = new System.Drawing.Point(306, 40);
            this.txtNumberMedicine.Name = "txtNumberMedicine";
            this.txtNumberMedicine.Size = new System.Drawing.Size(83, 29);
            this.txtNumberMedicine.TabIndex = 36;
            this.txtNumberMedicine.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberMedicine_Validating);
            // 
            // lstViewMed
            // 
            this.lstViewMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMName,
            this.columnAmount,
            this.columnPrice});
            this.lstViewMed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewMed.GridLines = true;
            this.lstViewMed.HideSelection = false;
            this.lstViewMed.Location = new System.Drawing.Point(13, 100);
            this.lstViewMed.Name = "lstViewMed";
            this.lstViewMed.Size = new System.Drawing.Size(395, 209);
            this.lstViewMed.TabIndex = 0;
            this.lstViewMed.UseCompatibleStateImageBehavior = false;
            this.lstViewMed.View = System.Windows.Forms.View.Details;
            // 
            // columnMName
            // 
            this.columnMName.Text = "Tên Thuốc";
            this.columnMName.Width = 153;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Số Lượng";
            this.columnAmount.Width = 98;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Giá Tiền";
            this.columnPrice.Width = 135;
            // 
            // errBirth
            // 
            this.errBirth.ContainerControl = this;
            // 
            // errPhone
            // 
            this.errPhone.ContainerControl = this;
            // 
            // lbDateExam
            // 
            this.lbDateExam.AutoSize = true;
            this.lbDateExam.BackColor = System.Drawing.SystemColors.Control;
            this.lbDateExam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateExam.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbDateExam.Location = new System.Drawing.Point(49, 528);
            this.lbDateExam.Name = "lbDateExam";
            this.lbDateExam.Size = new System.Drawing.Size(119, 24);
            this.lbDateExam.TabIndex = 40;
            this.lbDateExam.Text = "Ngày khám:";
            // 
            // txtdateExam
            // 
            this.txtdateExam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdateExam.Location = new System.Drawing.Point(219, 527);
            this.txtdateExam.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.txtdateExam.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtdateExam.Name = "txtdateExam";
            this.txtdateExam.Size = new System.Drawing.Size(150, 29);
            this.txtdateExam.TabIndex = 5;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.SystemColors.Control;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbID.Location = new System.Drawing.Point(403, 528);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(53, 24);
            this.lbID.TabIndex = 45;
            this.lbID.Text = "STT:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtID.Location = new System.Drawing.Point(476, 527);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(95, 29);
            this.txtID.TabIndex = 46;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = global::BCCK_N6.Properties.Resources.LoadingIcon;
            this.btnLoad.Location = new System.Drawing.Point(1842, 398);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(50, 50);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "c";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::BCCK_N6.Properties.Resources.SaveIcon;
            this.btnSave.Location = new System.Drawing.Point(1612, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::BCCK_N6.Properties.Resources.PrintIcon;
            this.btnPrint.Location = new System.Drawing.Point(659, 332);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 50);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.BackColor = System.Drawing.Color.White;
            this.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.ForeColor = System.Drawing.Color.White;
            this.btnNewRecord.Image = global::BCCK_N6.Properties.Resources.SignUpIcon;
            this.btnNewRecord.Location = new System.Drawing.Point(659, 239);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(50, 50);
            this.btnNewRecord.TabIndex = 12;
            this.btnNewRecord.UseVisualStyleBackColor = false;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::BCCK_N6.Properties.Resources.CloseIcon;
            this.btnClose.Location = new System.Drawing.Point(1868, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackColor = System.Drawing.Color.White;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedicine.Image = global::BCCK_N6.Properties.Resources.ScrollIcon;
            this.btnMedicine.Location = new System.Drawing.Point(216, 628);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(50, 50);
            this.btnMedicine.TabIndex = 7;
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btMedicine_Click);
            // 
            // Btclear
            // 
            this.Btclear.BackColor = System.Drawing.Color.White;
            this.Btclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btclear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btclear.ForeColor = System.Drawing.Color.White;
            this.Btclear.Image = global::BCCK_N6.Properties.Resources.CancelIcon;
            this.Btclear.Location = new System.Drawing.Point(53, 745);
            this.Btclear.Name = "Btclear";
            this.Btclear.Size = new System.Drawing.Size(50, 50);
            this.Btclear.TabIndex = 9;
            this.Btclear.UseVisualStyleBackColor = false;
            this.Btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::BCCK_N6.Properties.Resources._61802;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1920, 1061);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // lbSelection
            // 
            this.lbSelection.AutoSize = true;
            this.lbSelection.BackColor = System.Drawing.SystemColors.Control;
            this.lbSelection.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelection.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbSelection.Location = new System.Drawing.Point(1084, 396);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(131, 24);
            this.lbSelection.TabIndex = 48;
            this.lbSelection.Text = "Sắp xếp theo:";
            // 
            // cmbSelection
            // 
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Items.AddRange(new object[] {
            "Họ Tên",
            "Ngày Khám"});
            this.cmbSelection.Location = new System.Drawing.Point(1231, 390);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(212, 30);
            this.cmbSelection.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtSearch.Location = new System.Drawing.Point(1088, 439);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(355, 29);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Image = global::BCCK_N6.Properties.Resources.SortIcon;
            this.btnSort.Location = new System.Drawing.Point(1460, 398);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(50, 50);
            this.btnSort.TabIndex = 19;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // errAmount
            // 
            this.errAmount.ContainerControl = this;
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackColor = System.Drawing.Color.White;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteP.ForeColor = System.Drawing.Color.White;
            this.btnDeleteP.Image = global::BCCK_N6.Properties.Resources.DeleteIcon;
            this.btnDeleteP.Location = new System.Drawing.Point(1727, 398);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteP.TabIndex = 49;
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // Clinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSelection);
            this.Controls.Add(this.lbSelection);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNewRecord);
            this.Controls.Add(this.txtdateExam);
            this.Controls.Add(this.lbDateExam);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.Btclear);
            this.Controls.Add(this.pnMedicine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckbPhysicsExam);
            this.Controls.Add(this.txtDiagnose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Clinic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÒNG KHÁM";
            this.Load += new System.EventHandler(this.Clinic_Load);
            this.pnMedicine.ResumeLayout(false);
            this.pnMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHoTen;
        private System.Windows.Forms.ColumnHeader columnNamSinh;
        private System.Windows.Forms.ColumnHeader columnDC;
        private System.Windows.Forms.ColumnHeader columnSDT;
        private System.Windows.Forms.ColumnHeader columnCD;
        private System.Windows.Forms.ColumnHeader columnDT;
        private System.Windows.Forms.ColumnHeader columnMa;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiagnose;
        private System.Windows.Forms.CheckBox ckbPhysicsExam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnMedicine;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumberMedicine;
        private System.Windows.Forms.ListView lstViewMed;
        private System.Windows.Forms.ColumnHeader columnMName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btclear;
        private System.Windows.Forms.ErrorProvider errBirth;
        private System.Windows.Forms.ErrorProvider errPhone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker txtdateExam;
        private System.Windows.Forms.Label lbDateExam;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSelection;
        private System.Windows.Forms.Label lbSelection;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ErrorProvider errAmount;
        private System.Windows.Forms.Button btnDeleteP;
    }
}