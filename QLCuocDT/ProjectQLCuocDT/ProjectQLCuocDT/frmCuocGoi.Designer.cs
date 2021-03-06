﻿namespace ProjectQLCuocDT
{
    partial class frmCuocGoi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMaCuocGoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoFile = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvCuocGoi = new System.Windows.Forms.DataGridView();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSoPhut = new System.Windows.Forms.NumericUpDown();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericFilterSoPhutMax = new System.Windows.Forms.NumericUpDown();
            this.numericFilterSoPhutMin = new System.Windows.Forms.NumericUpDown();
            this.dtpFilterTGKT = new System.Windows.Forms.DateTimePicker();
            this.dtpFilterTGBD = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbbFilterTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericFilterPhiCuocGoiMin = new System.Windows.Forms.NumericUpDown();
            this.numericFilterPhiCuocGoiMax = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuocGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterSoPhutMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterSoPhutMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterPhiCuocGoiMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterPhiCuocGoiMax)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaCuocGoi
            // 
            this.txtMaCuocGoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCuocGoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCuocGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuocGoi.Location = new System.Drawing.Point(240, 78);
            this.txtMaCuocGoi.Name = "txtMaCuocGoi";
            this.txtMaCuocGoi.ReadOnly = true;
            this.txtMaCuocGoi.Size = new System.Drawing.Size(200, 24);
            this.txtMaCuocGoi.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã cuộc gọi";
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpTGBD.Enabled = false;
            this.dtpTGBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpTGBD.Location = new System.Drawing.Point(675, 77);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.Size = new System.Drawing.Size(200, 24);
            this.dtpTGBD.TabIndex = 38;
            this.dtpTGBD.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaoFile);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 70);
            this.panel1.TabIndex = 34;
            // 
            // btnTaoFile
            // 
            this.btnTaoFile.Location = new System.Drawing.Point(700, 15);
            this.btnTaoFile.Name = "btnTaoFile";
            this.btnTaoFile.Size = new System.Drawing.Size(85, 30);
            this.btnTaoFile.TabIndex = 6;
            this.btnTaoFile.Text = "Tạo file";
            this.btnTaoFile.UseVisualStyleBackColor = true;
            this.btnTaoFile.Click += new System.EventHandler(this.btnTaoFile_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(550, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 30);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(250, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvCuocGoi
            // 
            this.dgvCuocGoi.AllowUserToAddRows = false;
            this.dgvCuocGoi.AllowUserToResizeRows = false;
            this.dgvCuocGoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuocGoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuocGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuocGoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuocGoi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCuocGoi.Location = new System.Drawing.Point(0, 307);
            this.dgvCuocGoi.MultiSelect = false;
            this.dgvCuocGoi.Name = "dgvCuocGoi";
            this.dgvCuocGoi.ReadOnly = true;
            this.dgvCuocGoi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCuocGoi.RowHeadersVisible = false;
            this.dgvCuocGoi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCuocGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuocGoi.Size = new System.Drawing.Size(1008, 320);
            this.dgvCuocGoi.TabIndex = 33;
            this.dgvCuocGoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuocGoi_CellClick);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Khoá",
            "Không khoá"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(675, 197);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(200, 24);
            this.cbbTinhTrang.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thời gian kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số phút sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(430, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 25);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "CUỘC GỌI";
            // 
            // txtMaSim
            // 
            this.txtMaSim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSim.Location = new System.Drawing.Point(240, 137);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.ReadOnly = true;
            this.txtMaSim.Size = new System.Drawing.Size(200, 24);
            this.txtMaSim.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã sim";
            // 
            // numericSoPhut
            // 
            this.numericSoPhut.Enabled = false;
            this.numericSoPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSoPhut.Location = new System.Drawing.Point(240, 198);
            this.numericSoPhut.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericSoPhut.Name = "numericSoPhut";
            this.numericSoPhut.Size = new System.Drawing.Size(200, 24);
            this.numericSoPhut.TabIndex = 41;
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpTGKT.Enabled = false;
            this.dtpTGKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGKT.Location = new System.Drawing.Point(675, 137);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.Size = new System.Drawing.Size(200, 24);
            this.dtpTGKT.TabIndex = 42;
            this.dtpTGKT.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::ProjectQLCuocDT.Properties.Resources.icons8_search_40;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(423, 258);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(24, 24);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(217, 258);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tìm kiếm";
            // 
            // numericFilterSoPhutMax
            // 
            this.numericFilterSoPhutMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFilterSoPhutMax.Location = new System.Drawing.Point(718, 258);
            this.numericFilterSoPhutMax.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericFilterSoPhutMax.Name = "numericFilterSoPhutMax";
            this.numericFilterSoPhutMax.Size = new System.Drawing.Size(100, 24);
            this.numericFilterSoPhutMax.TabIndex = 75;
            this.numericFilterSoPhutMax.Visible = false;
            // 
            // numericFilterSoPhutMin
            // 
            this.numericFilterSoPhutMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFilterSoPhutMin.Location = new System.Drawing.Point(612, 258);
            this.numericFilterSoPhutMin.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericFilterSoPhutMin.Name = "numericFilterSoPhutMin";
            this.numericFilterSoPhutMin.Size = new System.Drawing.Size(100, 24);
            this.numericFilterSoPhutMin.TabIndex = 74;
            this.numericFilterSoPhutMin.Visible = false;
            // 
            // dtpFilterTGKT
            // 
            this.dtpFilterTGKT.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterTGKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilterTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterTGKT.Location = new System.Drawing.Point(718, 258);
            this.dtpFilterTGKT.Name = "dtpFilterTGKT";
            this.dtpFilterTGKT.Size = new System.Drawing.Size(100, 24);
            this.dtpFilterTGKT.TabIndex = 73;
            this.dtpFilterTGKT.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            this.dtpFilterTGKT.Visible = false;
            // 
            // dtpFilterTGBD
            // 
            this.dtpFilterTGBD.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterTGBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilterTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterTGBD.Location = new System.Drawing.Point(612, 258);
            this.dtpFilterTGBD.Name = "dtpFilterTGBD";
            this.dtpFilterTGBD.Size = new System.Drawing.Size(100, 24);
            this.dtpFilterTGBD.TabIndex = 72;
            this.dtpFilterTGBD.Value = new System.DateTime(2018, 11, 26, 13, 34, 23, 0);
            this.dtpFilterTGBD.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::ProjectQLCuocDT.Properties.Resources.icons8_filter_40;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.Location = new System.Drawing.Point(824, 258);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(24, 24);
            this.btnFilter.TabIndex = 71;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbbFilterTinhTrang
            // 
            this.cbbFilterTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilterTinhTrang.FormattingEnabled = true;
            this.cbbFilterTinhTrang.Items.AddRange(new object[] {
            "Khoá",
            "Không khoá"});
            this.cbbFilterTinhTrang.Location = new System.Drawing.Point(612, 258);
            this.cbbFilterTinhTrang.Name = "cbbFilterTinhTrang";
            this.cbbFilterTinhTrang.Size = new System.Drawing.Size(206, 24);
            this.cbbFilterTinhTrang.TabIndex = 70;
            // 
            // cbbFilter
            // 
            this.cbbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "Thời gian gọi",
            "Số phút gọi",
            "Phí cuộc gọi",
            "Tình trạng"});
            this.cbbFilter.Location = new System.Drawing.Point(506, 258);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(100, 24);
            this.cbbFilter.TabIndex = 69;
            this.cbbFilter.SelectedValueChanged += new System.EventHandler(this.cbbFilter_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(467, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "Lọc";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCuocGoi";
            this.Column1.HeaderText = "Mã cuộc gọi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSim";
            this.Column2.HeaderText = "Mã sim";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TG_BatDau";
            this.Column3.HeaderText = "Thời gian bắt đầu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TG_KetThuc";
            this.Column4.HeaderText = "Thời gian kết thúc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoPhutSD";
            this.Column5.HeaderText = "Số phút sử dụng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "PhiCuocGoi";
            this.Column7.HeaderText = "Phí cuộc gọi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "trangthai";
            this.Column6.HeaderText = "Tình trạng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // numericFilterPhiCuocGoiMin
            // 
            this.numericFilterPhiCuocGoiMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFilterPhiCuocGoiMin.Location = new System.Drawing.Point(612, 258);
            this.numericFilterPhiCuocGoiMin.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericFilterPhiCuocGoiMin.Name = "numericFilterPhiCuocGoiMin";
            this.numericFilterPhiCuocGoiMin.Size = new System.Drawing.Size(100, 24);
            this.numericFilterPhiCuocGoiMin.TabIndex = 76;
            this.numericFilterPhiCuocGoiMin.Visible = false;
            // 
            // numericFilterPhiCuocGoiMax
            // 
            this.numericFilterPhiCuocGoiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFilterPhiCuocGoiMax.Location = new System.Drawing.Point(718, 258);
            this.numericFilterPhiCuocGoiMax.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericFilterPhiCuocGoiMax.Name = "numericFilterPhiCuocGoiMax";
            this.numericFilterPhiCuocGoiMax.Size = new System.Drawing.Size(100, 24);
            this.numericFilterPhiCuocGoiMax.TabIndex = 77;
            this.numericFilterPhiCuocGoiMax.Visible = false;
            // 
            // frmCuocGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.numericFilterPhiCuocGoiMax);
            this.Controls.Add(this.numericFilterPhiCuocGoiMin);
            this.Controls.Add(this.numericFilterSoPhutMax);
            this.Controls.Add(this.numericFilterSoPhutMin);
            this.Controls.Add(this.dtpFilterTGKT);
            this.Controls.Add(this.dtpFilterTGBD);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbbFilterTinhTrang);
            this.Controls.Add(this.cbbFilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpTGKT);
            this.Controls.Add(this.numericSoPhut);
            this.Controls.Add(this.txtMaCuocGoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTGBD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCuocGoi);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMaSim);
            this.Controls.Add(this.label1);
            this.Name = "frmCuocGoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCuocGoi";
            this.Load += new System.EventHandler(this.frmCuocGoi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuocGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterSoPhutMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterSoPhutMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterPhiCuocGoiMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilterPhiCuocGoiMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaCuocGoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCuocGoi;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSoPhut;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoFile;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericFilterSoPhutMax;
        private System.Windows.Forms.NumericUpDown numericFilterSoPhutMin;
        private System.Windows.Forms.DateTimePicker dtpFilterTGKT;
        private System.Windows.Forms.DateTimePicker dtpFilterTGBD;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbbFilterTinhTrang;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown numericFilterPhiCuocGoiMin;
        private System.Windows.Forms.NumericUpDown numericFilterPhiCuocGoiMax;
    }
}