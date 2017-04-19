namespace QLNS_NHOM3
{
    partial class frmQLNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cHUYENMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet_ChuyenMon = new QLNS_NHOM3.QLNSDataSet_ChuyenMon();
            this.MaPB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet_PhongBan = new QLNS_NHOM3.QLNSDataSet_PhongBan();
            this.MaCN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cHINHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet_ChiNhanh = new QLNS_NHOM3.QLNSDataSet_ChiNhanh();
            this.MaTDHV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tDHVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet_TDHV = new QLNS_NHOM3.QLNSDataSet_TDHV();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.cboTrinhDoHV = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboChuyenMon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cHUYENMONTableAdapter = new QLNS_NHOM3.QLNSDataSet_ChuyenMonTableAdapters.CHUYENMONTableAdapter();
            this.pHONGBANTableAdapter = new QLNS_NHOM3.QLNSDataSet_PhongBanTableAdapters.PHONGBANTableAdapter();
            this.cHINHANHTableAdapter = new QLNS_NHOM3.QLNSDataSet_ChiNhanhTableAdapters.CHINHANHTableAdapter();
            this.tDHVTableAdapter = new QLNS_NHOM3.QLNSDataSet_TDHVTableAdapters.TDHVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_ChuyenMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_PhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHINHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_ChiNhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDHVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_TDHV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.MaCM,
            this.MaPB,
            this.MaCN,
            this.MaTDHV,
            this.HoTen,
            this.GioiTinh,
            this.QueQuan,
            this.NgaySinh,
            this.SDT});
            this.dataGridView1.Location = new System.Drawing.Point(0, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 279.1878F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.FillWeight = 82.08122F;
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 130;
            // 
            // MaCM
            // 
            this.MaCM.DataPropertyName = "MaCM";
            this.MaCM.DataSource = this.cHUYENMONBindingSource;
            this.MaCM.DisplayMember = "TenCM";
            this.MaCM.FillWeight = 82.08122F;
            this.MaCM.HeaderText = "Chuyên môn";
            this.MaCM.Name = "MaCM";
            this.MaCM.ReadOnly = true;
            this.MaCM.ValueMember = "MaCM";
            // 
            // cHUYENMONBindingSource
            // 
            this.cHUYENMONBindingSource.DataMember = "CHUYENMON";
            this.cHUYENMONBindingSource.DataSource = this.qLNSDataSet_ChuyenMon;
            // 
            // qLNSDataSet_ChuyenMon
            // 
            this.qLNSDataSet_ChuyenMon.DataSetName = "QLNSDataSet_ChuyenMon";
            this.qLNSDataSet_ChuyenMon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.DataSource = this.pHONGBANBindingSource;
            this.MaPB.DisplayMember = "TenPB";
            this.MaPB.FillWeight = 82.08122F;
            this.MaPB.HeaderText = "Phòng ban";
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            this.MaPB.ValueMember = "MaPB";
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.qLNSDataSet_PhongBan;
            // 
            // qLNSDataSet_PhongBan
            // 
            this.qLNSDataSet_PhongBan.DataSetName = "QLNSDataSet_PhongBan";
            this.qLNSDataSet_PhongBan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MaCN
            // 
            this.MaCN.DataPropertyName = "MaCN";
            this.MaCN.DataSource = this.cHINHANHBindingSource;
            this.MaCN.DisplayMember = "TenCN";
            this.MaCN.FillWeight = 82.08122F;
            this.MaCN.HeaderText = "Chi nhánh";
            this.MaCN.Name = "MaCN";
            this.MaCN.ReadOnly = true;
            this.MaCN.ValueMember = "MaCN";
            // 
            // cHINHANHBindingSource
            // 
            this.cHINHANHBindingSource.DataMember = "CHINHANH";
            this.cHINHANHBindingSource.DataSource = this.qLNSDataSet_ChiNhanh;
            // 
            // qLNSDataSet_ChiNhanh
            // 
            this.qLNSDataSet_ChiNhanh.DataSetName = "QLNSDataSet_ChiNhanh";
            this.qLNSDataSet_ChiNhanh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MaTDHV
            // 
            this.MaTDHV.DataPropertyName = "MaTDHV";
            this.MaTDHV.DataSource = this.tDHVBindingSource;
            this.MaTDHV.DisplayMember = "TenTDHV";
            this.MaTDHV.FillWeight = 82.08122F;
            this.MaTDHV.HeaderText = "Trình độ học vấn";
            this.MaTDHV.Name = "MaTDHV";
            this.MaTDHV.ReadOnly = true;
            this.MaTDHV.ValueMember = "MaTDHV";
            this.MaTDHV.Width = 130;
            // 
            // tDHVBindingSource
            // 
            this.tDHVBindingSource.DataMember = "TDHV";
            this.tDHVBindingSource.DataSource = this.qLNSDataSet_TDHV;
            // 
            // qLNSDataSet_TDHV
            // 
            this.qLNSDataSet_TDHV.DataSetName = "QLNSDataSet_TDHV";
            this.qLNSDataSet_TDHV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 82.08122F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FillWeight = 82.08122F;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.FillWeight = 82.08122F;
            this.QueQuan.HeaderText = "Quê quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 82.08122F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 82.08122F;
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 130;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(8, 475);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(83, 16);
            this.lblRowCount.TabIndex = 1;
            this.lblRowCount.Text = "lblRowCount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Mã nhân viên:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Chuyên môn:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "&Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Phòng ban:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "&Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "&Quê quán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Chi nhánh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "&Ngày sinh:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "&Trình độ học vấn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "&Số điện thoại:";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(91, 227);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(84, 31);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(180, 227);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 31);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(662, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 31);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(269, 227);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 31);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(751, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(840, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 31);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(358, 227);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(84, 31);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(929, 227);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 31);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1018, 227);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 31);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(258, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(166, 22);
            this.txtMaNV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(830, 35);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(830, 98);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(166, 22);
            this.txtQueQuan.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(830, 171);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 22);
            this.txtSDT.TabIndex = 4;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DataSource = this.pHONGBANBindingSource;
            this.cboPhongBan.DisplayMember = "TenPB";
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(258, 101);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(166, 24);
            this.cboPhongBan.TabIndex = 5;
            this.cboPhongBan.ValueMember = "MaPB";
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.DataSource = this.cHINHANHBindingSource;
            this.cboChiNhanh.DisplayMember = "TenCN";
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(258, 137);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(166, 24);
            this.cboChiNhanh.TabIndex = 5;
            this.cboChiNhanh.ValueMember = "MaCN";
            // 
            // cboTrinhDoHV
            // 
            this.cboTrinhDoHV.DataSource = this.tDHVBindingSource;
            this.cboTrinhDoHV.DisplayMember = "TenTDHV";
            this.cboTrinhDoHV.FormattingEnabled = true;
            this.cboTrinhDoHV.Location = new System.Drawing.Point(258, 174);
            this.cboTrinhDoHV.Name = "cboTrinhDoHV";
            this.cboTrinhDoHV.Size = new System.Drawing.Size(166, 24);
            this.cboTrinhDoHV.TabIndex = 5;
            this.cboTrinhDoHV.ValueMember = "MaTDHV";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(830, 140);
            this.dtpNgaySinh.MaxDate = new System.DateTime(1994, 12, 12, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(166, 22);
            this.dtpNgaySinh.TabIndex = 6;
            this.dtpNgaySinh.Value = new System.DateTime(1994, 12, 12, 0, 0, 0, 0);
            // 
            // cboChuyenMon
            // 
            this.cboChuyenMon.DataSource = this.cHUYENMONBindingSource;
            this.cboChuyenMon.DisplayMember = "TenCM";
            this.cboChuyenMon.FormattingEnabled = true;
            this.cboChuyenMon.Location = new System.Drawing.Point(258, 65);
            this.cboChuyenMon.Name = "cboChuyenMon";
            this.cboChuyenMon.Size = new System.Drawing.Size(166, 24);
            this.cboChuyenMon.TabIndex = 7;
            this.cboChuyenMon.ValueMember = "MaCM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.cboChuyenMon);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.cboTrinhDoHV);
            this.groupBox1.Controls.Add(this.cboChiNhanh);
            this.groupBox1.Controls.Add(this.cboPhongBan);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRowCount);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1202, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Danh sách nhân viên";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(891, 67);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(43, 20);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(830, 66);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(55, 20);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // cHUYENMONTableAdapter
            // 
            this.cHUYENMONTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // cHINHANHTableAdapter
            // 
            this.cHINHANHTableAdapter.ClearBeforeFill = true;
            // 
            // tDHVTableAdapter
            // 
            this.tDHVTableAdapter.ClearBeforeFill = true;
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 515);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_ChuyenMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_PhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHINHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_ChiNhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDHVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet_TDHV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.ComboBox cboTrinhDoHV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboChuyenMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private QLNSDataSet_ChuyenMon qLNSDataSet_ChuyenMon;
        private System.Windows.Forms.BindingSource cHUYENMONBindingSource;
        private QLNSDataSet_ChuyenMonTableAdapters.CHUYENMONTableAdapter cHUYENMONTableAdapter;
        private QLNSDataSet_PhongBan qLNSDataSet_PhongBan;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private QLNSDataSet_PhongBanTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private QLNSDataSet_ChiNhanh qLNSDataSet_ChiNhanh;
        private System.Windows.Forms.BindingSource cHINHANHBindingSource;
        private QLNSDataSet_ChiNhanhTableAdapters.CHINHANHTableAdapter cHINHANHTableAdapter;
        private QLNSDataSet_TDHV qLNSDataSet_TDHV;
        private System.Windows.Forms.BindingSource tDHVBindingSource;
        private QLNSDataSet_TDHVTableAdapters.TDHVTableAdapter tDHVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaCM;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaCN;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTDHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
    }
}

