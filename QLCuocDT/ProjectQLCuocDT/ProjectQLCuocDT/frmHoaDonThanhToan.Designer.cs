﻿namespace ProjectQLCuocDT
{
    partial class frmHoaDonThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuiEmail = new System.Windows.Forms.Button();
            this.dgvHoaDonThanhToan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoSim = new System.Windows.Forms.TextBox();
            this.numericThanhTien = new System.Windows.Forms.NumericUpDown();
            this.numericCuocThueBao = new System.Windows.Forms.NumericUpDown();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbThanhToan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.cbbFilterThanhToan = new System.Windows.Forms.ComboBox();
            this.cbbFilterTinhTrang = new System.Windows.Forms.ComboBox();
            this.dtpFilterNgayBDTao = new System.Windows.Forms.DateTimePicker();
            this.dtpFilterNgayKTTao = new System.Windows.Forms.DateTimePicker();
            this.numericFilterThanhTienMin = new System.Windows.Forms.NumericUpDown();
            this.numericFilterThanhTienMax = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCuocThueBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterThanhTienMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterThanhTienMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(450, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 30);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(300, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(240, 58);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(200, 24);
            this.txtMaHoaDon.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã hoá đơn";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpNgayTao.Enabled = false;
            this.dtpNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(675, 57);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(200, 24);
            this.dtpNgayTao.TabIndex = 38;
            this.dtpNgayTao.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuiEmail);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 70);
            this.panel1.TabIndex = 34;
            // 
            // btnGuiEmail
            // 
            this.btnGuiEmail.Location = new System.Drawing.Point(600, 15);
            this.btnGuiEmail.Name = "btnGuiEmail";
            this.btnGuiEmail.Size = new System.Drawing.Size(85, 30);
            this.btnGuiEmail.TabIndex = 3;
            this.btnGuiEmail.Text = "Gửi Email";
            this.btnGuiEmail.UseVisualStyleBackColor = true;
            this.btnGuiEmail.Click += new System.EventHandler(this.btnGuiEmail_Click);
            // 
            // dgvHoaDonThanhToan
            // 
            this.dgvHoaDonThanhToan.AllowUserToAddRows = false;
            this.dgvHoaDonThanhToan.AllowUserToResizeRows = false;
            this.dgvHoaDonThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonThanhToan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonThanhToan.Location = new System.Drawing.Point(0, 362);
            this.dgvHoaDonThanhToan.MultiSelect = false;
            this.dgvHoaDonThanhToan.Name = "dgvHoaDonThanhToan";
            this.dgvHoaDonThanhToan.ReadOnly = true;
            this.dgvHoaDonThanhToan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHoaDonThanhToan.RowHeadersVisible = false;
            this.dgvHoaDonThanhToan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHoaDonThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonThanhToan.Size = new System.Drawing.Size(1008, 291);
            this.dgvHoaDonThanhToan.TabIndex = 33;
            this.dgvHoaDonThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonThanhToan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hoá đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoSim";
            this.Column3.HeaderText = "Số sim";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CuocThueBao";
            this.Column4.HeaderText = "Cước thuê bao";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayHD";
            this.Column5.HeaderText = "Ngày tạo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThanhToan";
            this.Column6.HeaderText = "Thanh toán";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThanhTien";
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TinhTrang";
            this.Column8.HeaderText = "Tình trạng";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cước thuê bao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số sim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ngày tạo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(430, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 25);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "HOÁ ĐƠN";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(240, 117);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(200, 24);
            this.txtTenKhachHang.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên khách hàng";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Khoá",
            "Không khoá"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(675, 239);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(200, 24);
            this.cbbTinhTrang.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(550, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tình trạng";
            // 
            // txtSoSim
            // 
            this.txtSoSim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoSim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSim.Location = new System.Drawing.Point(240, 178);
            this.txtSoSim.Name = "txtSoSim";
            this.txtSoSim.ReadOnly = true;
            this.txtSoSim.Size = new System.Drawing.Size(200, 24);
            this.txtSoSim.TabIndex = 43;
            // 
            // numericThanhTien
            // 
            this.numericThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericThanhTien.Location = new System.Drawing.Point(675, 178);
            this.numericThanhTien.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericThanhTien.Name = "numericThanhTien";
            this.numericThanhTien.ReadOnly = true;
            this.numericThanhTien.Size = new System.Drawing.Size(200, 24);
            this.numericThanhTien.TabIndex = 44;
            // 
            // numericCuocThueBao
            // 
            this.numericCuocThueBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCuocThueBao.Location = new System.Drawing.Point(240, 238);
            this.numericCuocThueBao.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericCuocThueBao.Name = "numericCuocThueBao";
            this.numericCuocThueBao.ReadOnly = true;
            this.numericCuocThueBao.Size = new System.Drawing.Size(200, 24);
            this.numericCuocThueBao.TabIndex = 45;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(230, 318);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tìm kiếm";
            // 
            // cbbThanhToan
            // 
            this.cbbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThanhToan.FormattingEnabled = true;
            this.cbbThanhToan.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbThanhToan.Location = new System.Drawing.Point(675, 117);
            this.cbbThanhToan.Name = "cbbThanhToan";
            this.cbbThanhToan.Size = new System.Drawing.Size(200, 24);
            this.cbbThanhToan.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 18);
            this.label10.TabIndex = 50;
            this.label10.Text = "Lọc";
            // 
            // cbbFilter
            // 
            this.cbbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "Ngày tạo",
            "Thanh toán",
            "Thành tiền",
            "Tình trạng"});
            this.cbbFilter.Location = new System.Drawing.Point(542, 318);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(100, 24);
            this.cbbFilter.TabIndex = 51;
            this.cbbFilter.SelectedValueChanged += new System.EventHandler(this.cbbFilter_SelectedValueChanged);
            // 
            // cbbFilterThanhToan
            // 
            this.cbbFilterThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilterThanhToan.FormattingEnabled = true;
            this.cbbFilterThanhToan.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbFilterThanhToan.Location = new System.Drawing.Point(648, 318);
            this.cbbFilterThanhToan.Name = "cbbFilterThanhToan";
            this.cbbFilterThanhToan.Size = new System.Drawing.Size(206, 24);
            this.cbbFilterThanhToan.TabIndex = 52;
            this.cbbFilterThanhToan.Visible = false;
            // 
            // cbbFilterTinhTrang
            // 
            this.cbbFilterTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilterTinhTrang.FormattingEnabled = true;
            this.cbbFilterTinhTrang.Items.AddRange(new object[] {
            "Khoá",
            "Không khoá"});
            this.cbbFilterTinhTrang.Location = new System.Drawing.Point(648, 318);
            this.cbbFilterTinhTrang.Name = "cbbFilterTinhTrang";
            this.cbbFilterTinhTrang.Size = new System.Drawing.Size(206, 24);
            this.cbbFilterTinhTrang.TabIndex = 53;
            // 
            // dtpFilterNgayBDTao
            // 
            this.dtpFilterNgayBDTao.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterNgayBDTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilterNgayBDTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterNgayBDTao.Location = new System.Drawing.Point(648, 318);
            this.dtpFilterNgayBDTao.Name = "dtpFilterNgayBDTao";
            this.dtpFilterNgayBDTao.Size = new System.Drawing.Size(100, 24);
            this.dtpFilterNgayBDTao.TabIndex = 55;
            this.dtpFilterNgayBDTao.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            this.dtpFilterNgayBDTao.Visible = false;
            // 
            // dtpFilterNgayKTTao
            // 
            this.dtpFilterNgayKTTao.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterNgayKTTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilterNgayKTTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterNgayKTTao.Location = new System.Drawing.Point(754, 318);
            this.dtpFilterNgayKTTao.Name = "dtpFilterNgayKTTao";
            this.dtpFilterNgayKTTao.Size = new System.Drawing.Size(100, 24);
            this.dtpFilterNgayKTTao.TabIndex = 56;
            this.dtpFilterNgayKTTao.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            this.dtpFilterNgayKTTao.Visible = false;
            // 
            // numericFilterThanhTienMin
            // 
            this.numericFilterThanhTienMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFilterThanhTienMin.Location = new System.Drawing.Point(648, 318);
            this.numericFilterThanhTienMin.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericFilterThanhTienMin.Name = "numericFilterThanhTienMin";
            this.numericFilterThanhTienMin.Size = new System.Drawing.Size(100, 24);
            this.numericFilterThanhTienMin.TabIndex = 57;
            this.numericFilterThanhTienMin.Visible = false;
            // 
            // numericFilterThanhTienMax
            // 
            this.numericFilterThanhTienMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFilterThanhTienMax.Location = new System.Drawing.Point(754, 318);
            this.numericFilterThanhTienMax.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericFilterThanhTienMax.Name = "numericFilterThanhTienMax";
            this.numericFilterThanhTienMax.Size = new System.Drawing.Size(100, 24);
            this.numericFilterThanhTienMax.TabIndex = 58;
            this.numericFilterThanhTienMax.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::ProjectQLCuocDT.Properties.Resources.icons8_filter_40;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.Location = new System.Drawing.Point(860, 318);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(24, 24);
            this.btnFilter.TabIndex = 54;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::ProjectQLCuocDT.Properties.Resources.icons8_search_40;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(436, 318);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(24, 24);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.numericFilterThanhTienMax);
            this.Controls.Add(this.numericFilterThanhTienMin);
            this.Controls.Add(this.dtpFilterNgayKTTao);
            this.Controls.Add(this.dtpFilterNgayBDTao);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbbFilterTinhTrang);
            this.Controls.Add(this.cbbFilterThanhToan);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbThanhToan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericCuocThueBao);
            this.Controls.Add(this.numericThanhTien);
            this.Controls.Add(this.txtSoSim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHoaDonThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn thanh toán";
            this.Load += new System.EventHandler(this.frmHoaDonThanhToan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCuocThueBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterThanhTienMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterThanhTienMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHoaDonThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoSim;
        private System.Windows.Forms.NumericUpDown numericThanhTien;
        private System.Windows.Forms.NumericUpDown numericCuocThueBao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cbbThanhToan;
        private System.Windows.Forms.Button btnGuiEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.ComboBox cbbFilterThanhToan;
        private System.Windows.Forms.ComboBox cbbFilterTinhTrang;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterNgayBDTao;
        private System.Windows.Forms.DateTimePicker dtpFilterNgayKTTao;
        private System.Windows.Forms.NumericUpDown numericFilterThanhTienMin;
        private System.Windows.Forms.NumericUpDown numericFilterThanhTienMax;
    }
}