
namespace BTLDOTNET
{
    partial class frmHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new MetroFramework.Controls.MetroTextBox();
            this.txtTenKH = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayBan = new MetroFramework.Controls.MetroTextBox();
            this.txtMaHD = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemHD = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.cmbKichThuoc = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenHang = new MetroFramework.Controls.MetroTextBox();
            this.txtDonGia = new MetroFramework.Controls.MetroTextBox();
            this.txtMaHang = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelTT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(120, 86);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(245, 21);
            this.cmbMaNV.TabIndex = 28;
            
            // 
            // txtDienThoai
            // 
            // 
            // 
            // 
            this.txtDienThoai.CustomButton.Image = null;
            this.txtDienThoai.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtDienThoai.CustomButton.Name = "";
            this.txtDienThoai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDienThoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDienThoai.CustomButton.TabIndex = 1;
            this.txtDienThoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDienThoai.CustomButton.UseSelectable = true;
            this.txtDienThoai.CustomButton.Visible = false;
            this.txtDienThoai.Lines = new string[0];
            this.txtDienThoai.Location = new System.Drawing.Point(585, 55);
            this.txtDienThoai.MaxLength = 32767;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.PasswordChar = '\0';
            this.txtDienThoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDienThoai.SelectedText = "";
            this.txtDienThoai.SelectionLength = 0;
            this.txtDienThoai.SelectionStart = 0;
            this.txtDienThoai.ShortcutsEnabled = true;
            this.txtDienThoai.Size = new System.Drawing.Size(245, 23);
            this.txtDienThoai.TabIndex = 27;
            this.txtDienThoai.UseSelectable = true;
            this.txtDienThoai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDienThoai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenKH
            // 
            // 
            // 
            // 
            this.txtTenKH.CustomButton.Image = null;
            this.txtTenKH.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtTenKH.CustomButton.Name = "";
            this.txtTenKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenKH.CustomButton.TabIndex = 1;
            this.txtTenKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenKH.CustomButton.UseSelectable = true;
            this.txtTenKH.CustomButton.Visible = false;
            this.txtTenKH.Lines = new string[0];
            this.txtTenKH.Location = new System.Drawing.Point(585, 19);
            this.txtTenKH.MaxLength = 32767;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.SelectionLength = 0;
            this.txtTenKH.SelectionStart = 0;
            this.txtTenKH.ShortcutsEnabled = true;
            this.txtTenKH.Size = new System.Drawing.Size(245, 23);
            this.txtTenKH.TabIndex = 26;
            this.txtTenKH.UseSelectable = true;
            this.txtTenKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên khách hàng";
            // 
            // txtNgayBan
            // 
            // 
            // 
            // 
            this.txtNgayBan.CustomButton.Image = null;
            this.txtNgayBan.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtNgayBan.CustomButton.Name = "";
            this.txtNgayBan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNgayBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNgayBan.CustomButton.TabIndex = 1;
            this.txtNgayBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNgayBan.CustomButton.UseSelectable = true;
            this.txtNgayBan.CustomButton.Visible = false;
            this.txtNgayBan.Enabled = false;
            this.txtNgayBan.Lines = new string[0];
            this.txtNgayBan.Location = new System.Drawing.Point(120, 55);
            this.txtNgayBan.MaxLength = 32767;
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.PasswordChar = '\0';
            this.txtNgayBan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNgayBan.SelectedText = "";
            this.txtNgayBan.SelectionLength = 0;
            this.txtNgayBan.SelectionStart = 0;
            this.txtNgayBan.ShortcutsEnabled = true;
            this.txtNgayBan.Size = new System.Drawing.Size(245, 23);
            this.txtNgayBan.TabIndex = 11;
            this.txtNgayBan.UseSelectable = true;
            this.txtNgayBan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNgayBan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaHD
            // 
            // 
            // 
            // 
            this.txtMaHD.CustomButton.Image = null;
            this.txtMaHD.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtMaHD.CustomButton.Name = "";
            this.txtMaHD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaHD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaHD.CustomButton.TabIndex = 1;
            this.txtMaHD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaHD.CustomButton.UseSelectable = true;
            this.txtMaHD.CustomButton.Visible = false;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Lines = new string[0];
            this.txtMaHD.Location = new System.Drawing.Point(120, 19);
            this.txtMaHD.MaxLength = 32767;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.SelectionLength = 0;
            this.txtMaHD.SelectionStart = 0;
            this.txtMaHD.ShortcutsEnabled = true;
            this.txtMaHD.Size = new System.Drawing.Size(245, 23);
            this.txtMaHD.TabIndex = 6;
            this.txtMaHD.UseSelectable = true;
            this.txtMaHD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaHD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // btnThemHD
            // 
            this.btnThemHD.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemHD.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnThemHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHD.IconSize = 30;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThemHD.Location = new System.Drawing.Point(806, 168);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(97, 34);
            this.btnThemHD.TabIndex = 24;
            this.btnThemHD.Text = "Thêm mới hóa đơn";
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cmbKichThuoc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtMaHang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 104);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(380, 51);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 31);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.CustomButton.Image = null;
            this.txtSoLuong.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtSoLuong.CustomButton.Name = "";
            this.txtSoLuong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoLuong.CustomButton.TabIndex = 1;
            this.txtSoLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoLuong.CustomButton.UseSelectable = true;
            this.txtSoLuong.CustomButton.Visible = false;
            this.txtSoLuong.Lines = new string[0];
            this.txtSoLuong.Location = new System.Drawing.Point(648, 19);
            this.txtSoLuong.MaxLength = 32767;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.SelectionLength = 0;
            this.txtSoLuong.SelectionStart = 0;
            this.txtSoLuong.ShortcutsEnabled = true;
            this.txtSoLuong.Size = new System.Drawing.Size(132, 23);
            this.txtSoLuong.TabIndex = 14;
            this.txtSoLuong.UseSelectable = true;
            this.txtSoLuong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoLuong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbKichThuoc
            // 
            this.cmbKichThuoc.FormattingEnabled = true;
            this.cmbKichThuoc.ItemHeight = 23;
            this.cmbKichThuoc.Location = new System.Drawing.Point(448, 16);
            this.cmbKichThuoc.Name = "cmbKichThuoc";
            this.cmbKichThuoc.Size = new System.Drawing.Size(132, 29);
            this.cmbKichThuoc.TabIndex = 13;
            this.cmbKichThuoc.UseSelectable = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số lượng";
            // 
            // txtTenHang
            // 
            // 
            // 
            // 
            this.txtTenHang.CustomButton.Image = null;
            this.txtTenHang.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtTenHang.CustomButton.Name = "";
            this.txtTenHang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenHang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenHang.CustomButton.TabIndex = 1;
            this.txtTenHang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenHang.CustomButton.UseSelectable = true;
            this.txtTenHang.CustomButton.Visible = false;
            this.txtTenHang.Lines = new string[0];
            this.txtTenHang.Location = new System.Drawing.Point(111, 56);
            this.txtTenHang.MaxLength = 32767;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.PasswordChar = '\0';
            this.txtTenHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenHang.SelectedText = "";
            this.txtTenHang.SelectionLength = 0;
            this.txtTenHang.SelectionStart = 0;
            this.txtTenHang.ShortcutsEnabled = true;
            this.txtTenHang.Size = new System.Drawing.Size(245, 23);
            this.txtTenHang.TabIndex = 11;
            this.txtTenHang.UseSelectable = true;
            this.txtTenHang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenHang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.CustomButton.Image = null;
            this.txtDonGia.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtDonGia.CustomButton.Name = "";
            this.txtDonGia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDonGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDonGia.CustomButton.TabIndex = 1;
            this.txtDonGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDonGia.CustomButton.UseSelectable = true;
            this.txtDonGia.CustomButton.Visible = false;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Lines = new string[0];
            this.txtDonGia.Location = new System.Drawing.Point(648, 57);
            this.txtDonGia.MaxLength = 32767;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.SelectionLength = 0;
            this.txtDonGia.SelectionStart = 0;
            this.txtDonGia.ShortcutsEnabled = true;
            this.txtDonGia.Size = new System.Drawing.Size(132, 23);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.UseSelectable = true;
            this.txtDonGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDonGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaHang
            // 
            // 
            // 
            // 
            this.txtMaHang.CustomButton.Image = null;
            this.txtMaHang.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtMaHang.CustomButton.Name = "";
            this.txtMaHang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaHang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaHang.CustomButton.TabIndex = 1;
            this.txtMaHang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaHang.CustomButton.UseSelectable = true;
            this.txtMaHang.CustomButton.Visible = false;
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Lines = new string[0];
            this.txtMaHang.Location = new System.Drawing.Point(111, 16);
            this.txtMaHang.MaxLength = 32767;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.PasswordChar = '\0';
            this.txtMaHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaHang.SelectedText = "";
            this.txtMaHang.SelectionLength = 0;
            this.txtMaHang.SelectionStart = 0;
            this.txtMaHang.ShortcutsEnabled = true;
            this.txtMaHang.Size = new System.Drawing.Size(245, 23);
            this.txtMaHang.TabIndex = 6;
            this.txtMaHang.UseSelectable = true;
            this.txtMaHang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaHang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kích thước";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã hàng";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(16, 37);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(520, 193);
            this.dgvHoaDon.TabIndex = 12;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 535);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 34);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm mới sản phẩm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnXoa.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.Location = new System.Drawing.Point(132, 535);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 34);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSua.Location = new System.Drawing.Point(240, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnThanhToan.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 30;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(819, 535);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(97, 34);
            this.btnThanhToan.TabIndex = 17;
            this.btnThanhToan.Text = "Thanh toán ";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(470, 535);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 34);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát\r\n";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.btnLamMoi.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 30;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(355, 535);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 34);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSanPham);
            this.groupBox3.Location = new System.Drawing.Point(3, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 230);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(9, 37);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(343, 193);
            this.dgvSanPham.TabIndex = 13;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(367, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 236);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(583, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 22);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tổng tiền:";
            // 
            // LabelTT
            // 
            this.LabelTT.AutoSize = true;
            this.LabelTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelTT.Location = new System.Drawing.Point(682, 540);
            this.LabelTT.Name = "LabelTT";
            this.LabelTT.Size = new System.Drawing.Size(20, 22);
            this.LabelTT.TabIndex = 23;
            this.LabelTT.Text = "0";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 590);
            this.Controls.Add(this.LabelTT);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtMaHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtTenHang;
        private MetroFramework.Controls.MetroTextBox txtDonGia;
        private MetroFramework.Controls.MetroTextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private MetroFramework.Controls.MetroTextBox txtSoLuong;
        private MetroFramework.Controls.MetroComboBox cmbKichThuoc;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelTT;
        private MetroFramework.Controls.MetroTextBox txtNgayBan;
        private FontAwesome.Sharp.IconButton btnThemHD;
        private MetroFramework.Controls.MetroTextBox txtDienThoai;
        private MetroFramework.Controls.MetroTextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaNV;
    }
}