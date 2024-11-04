
namespace BTLDOTNET
{
    partial class frmPhieuNhap
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
            this.LabelTT = new System.Windows.Forms.Label();
            this.btnThemPN = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.cmbKichThuoc = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenHang = new MetroFramework.Controls.MetroTextBox();
            this.txtGiaNhap = new MetroFramework.Controls.MetroTextBox();
            this.txtMaHang = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NgayNhap = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaphieunhap = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTT
            // 
            this.LabelTT.AutoSize = true;
            this.LabelTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelTT.Location = new System.Drawing.Point(689, 540);
            this.LabelTT.Name = "LabelTT";
            this.LabelTT.Size = new System.Drawing.Size(20, 22);
            this.LabelTT.TabIndex = 37;
            this.LabelTT.Text = "0";
            // 
            // btnThemPN
            // 
            this.btnThemPN.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemPN.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnThemPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemPN.IconSize = 30;
            this.btnThemPN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThemPN.Location = new System.Drawing.Point(805, 528);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(105, 34);
            this.btnThemPN.TabIndex = 38;
            this.btnThemPN.Text = "Thêm mới phiếu nhập\r\n";
            this.btnThemPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(590, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "Tổng tiền:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPhieuNhap);
            this.groupBox4.Location = new System.Drawing.Point(374, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 236);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(16, 37);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(520, 193);
            this.dgvPhieuNhap.TabIndex = 12;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSanPham);
            this.groupBox3.Location = new System.Drawing.Point(10, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 230);
            this.groupBox3.TabIndex = 34;
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
            // btnLamMoi
            // 
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.btnLamMoi.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 30;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(362, 535);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 34);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.Location = new System.Drawing.Point(477, 535);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 34);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát\r\n";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSua.Location = new System.Drawing.Point(247, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnXoa.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.Location = new System.Drawing.Point(139, 535);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 34);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Location = new System.Drawing.Point(19, 535);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 34);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm mới sản phẩm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cmbKichThuoc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtMaHang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(10, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 104);
            this.groupBox2.TabIndex = 27;
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
            // txtGiaNhap
            // 
            // 
            // 
            // 
            this.txtGiaNhap.CustomButton.Image = null;
            this.txtGiaNhap.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtGiaNhap.CustomButton.Name = "";
            this.txtGiaNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGiaNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGiaNhap.CustomButton.TabIndex = 1;
            this.txtGiaNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGiaNhap.CustomButton.UseSelectable = true;
            this.txtGiaNhap.CustomButton.Visible = false;
            this.txtGiaNhap.Lines = new string[0];
            this.txtGiaNhap.Location = new System.Drawing.Point(648, 57);
            this.txtGiaNhap.MaxLength = 32767;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.SelectionLength = 0;
            this.txtGiaNhap.SelectionStart = 0;
            this.txtGiaNhap.ShortcutsEnabled = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(132, 23);
            this.txtGiaNhap.TabIndex = 8;
            this.txtGiaNhap.UseSelectable = true;
            this.txtGiaNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGiaNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.label9.Location = new System.Drawing.Point(592, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giá nhập";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNCC);
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(this.NgayNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaphieunhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 115);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // NgayNhap
            // 
            this.NgayNhap.Location = new System.Drawing.Point(120, 51);
            this.NgayNhap.MinimumSize = new System.Drawing.Size(0, 29);
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Size = new System.Drawing.Size(245, 29);
            this.NgayNhap.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "NCC";
            // 
            // txtMaphieunhap
            // 
            // 
            // 
            // 
            this.txtMaphieunhap.CustomButton.Image = null;
            this.txtMaphieunhap.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtMaphieunhap.CustomButton.Name = "";
            this.txtMaphieunhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaphieunhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaphieunhap.CustomButton.TabIndex = 1;
            this.txtMaphieunhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaphieunhap.CustomButton.UseSelectable = true;
            this.txtMaphieunhap.CustomButton.Visible = false;
            this.txtMaphieunhap.Enabled = false;
            this.txtMaphieunhap.Lines = new string[0];
            this.txtMaphieunhap.Location = new System.Drawing.Point(120, 19);
            this.txtMaphieunhap.MaxLength = 32767;
            this.txtMaphieunhap.Name = "txtMaphieunhap";
            this.txtMaphieunhap.PasswordChar = '\0';
            this.txtMaphieunhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaphieunhap.SelectedText = "";
            this.txtMaphieunhap.SelectionLength = 0;
            this.txtMaphieunhap.SelectionStart = 0;
            this.txtMaphieunhap.ShortcutsEnabled = true;
            this.txtMaphieunhap.Size = new System.Drawing.Size(245, 23);
            this.txtMaphieunhap.TabIndex = 6;
            this.txtMaphieunhap.UseSelectable = true;
            this.txtMaphieunhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaphieunhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ PHIẾU NHẬP\r\n";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(120, 88);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(245, 21);
            this.cmbMaNV.TabIndex = 29;
            // 
            // cmbNCC
            // 
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(562, 21);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(256, 21);
            this.cmbNCC.TabIndex = 30;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 576);
            this.Controls.Add(this.LabelTT);
            this.Controls.Add(this.btnThemPN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuNhap";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTT;
        private FontAwesome.Sharp.IconButton btnThemPN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private MetroFramework.Controls.MetroTextBox txtSoLuong;
        private MetroFramework.Controls.MetroComboBox cmbKichThuoc;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtTenHang;
        private MetroFramework.Controls.MetroTextBox txtGiaNhap;
        private MetroFramework.Controls.MetroTextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtMaphieunhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime NgayNhap;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.ComboBox cmbNCC;
    }
}