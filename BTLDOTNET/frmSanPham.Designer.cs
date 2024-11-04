
namespace BTLDOTNET
{
    partial class frmSanPham
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
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSP = new MetroFramework.Controls.MetroTextBox();
            this.txtTenSP = new MetroFramework.Controls.MetroTextBox();
            this.txtDonGia = new MetroFramework.Controls.MetroTextBox();
            this.txtSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.cmbKichThuoc = new System.Windows.Forms.ComboBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm \r\n";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.btnLamMoi.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.IconSize = 30;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(591, 197);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 34);
            this.btnLamMoi.TabIndex = 38;
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
            this.btnThoat.Location = new System.Drawing.Point(716, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 34);
            this.btnThoat.TabIndex = 37;
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
            this.btnSua.Location = new System.Drawing.Point(591, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 36;
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
            this.btnXoa.Location = new System.Drawing.Point(591, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 34);
            this.btnXoa.TabIndex = 35;
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
            this.btnThem.Location = new System.Drawing.Point(591, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 34);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm mới sản phẩm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kích thước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Số lượng";
            // 
            // txtMaSP
            // 
            // 
            // 
            // 
            this.txtMaSP.CustomButton.Image = null;
            this.txtMaSP.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtMaSP.CustomButton.Name = "";
            this.txtMaSP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaSP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaSP.CustomButton.TabIndex = 1;
            this.txtMaSP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaSP.CustomButton.UseSelectable = true;
            this.txtMaSP.CustomButton.Visible = false;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Lines = new string[0];
            this.txtMaSP.Location = new System.Drawing.Point(137, 59);
            this.txtMaSP.MaxLength = 32767;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.SelectionLength = 0;
            this.txtMaSP.SelectionStart = 0;
            this.txtMaSP.ShortcutsEnabled = true;
            this.txtMaSP.Size = new System.Drawing.Size(135, 23);
            this.txtMaSP.TabIndex = 44;
            this.txtMaSP.UseSelectable = true;
            this.txtMaSP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaSP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenSP
            // 
            // 
            // 
            // 
            this.txtTenSP.CustomButton.Image = null;
            this.txtTenSP.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtTenSP.CustomButton.Name = "";
            this.txtTenSP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenSP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenSP.CustomButton.TabIndex = 1;
            this.txtTenSP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenSP.CustomButton.UseSelectable = true;
            this.txtTenSP.CustomButton.Visible = false;
            this.txtTenSP.Lines = new string[0];
            this.txtTenSP.Location = new System.Drawing.Point(137, 94);
            this.txtTenSP.MaxLength = 32767;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.SelectionLength = 0;
            this.txtTenSP.SelectionStart = 0;
            this.txtTenSP.ShortcutsEnabled = true;
            this.txtTenSP.Size = new System.Drawing.Size(277, 23);
            this.txtTenSP.TabIndex = 45;
            this.txtTenSP.UseSelectable = true;
            this.txtTenSP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenSP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.CustomButton.Image = null;
            this.txtDonGia.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtDonGia.CustomButton.Name = "";
            this.txtDonGia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDonGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDonGia.CustomButton.TabIndex = 1;
            this.txtDonGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDonGia.CustomButton.UseSelectable = true;
            this.txtDonGia.CustomButton.Visible = false;
            this.txtDonGia.Lines = new string[0];
            this.txtDonGia.Location = new System.Drawing.Point(137, 163);
            this.txtDonGia.MaxLength = 32767;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.SelectionLength = 0;
            this.txtDonGia.SelectionStart = 0;
            this.txtDonGia.ShortcutsEnabled = true;
            this.txtDonGia.Size = new System.Drawing.Size(135, 23);
            this.txtDonGia.TabIndex = 47;
            this.txtDonGia.UseSelectable = true;
            this.txtDonGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDonGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.CustomButton.Image = null;
            this.txtSoLuong.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtSoLuong.CustomButton.Name = "";
            this.txtSoLuong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoLuong.CustomButton.TabIndex = 1;
            this.txtSoLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoLuong.CustomButton.UseSelectable = true;
            this.txtSoLuong.CustomButton.Visible = false;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Lines = new string[0];
            this.txtSoLuong.Location = new System.Drawing.Point(137, 197);
            this.txtSoLuong.MaxLength = 32767;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.SelectionLength = 0;
            this.txtSoLuong.SelectionStart = 0;
            this.txtSoLuong.ShortcutsEnabled = true;
            this.txtSoLuong.Size = new System.Drawing.Size(135, 23);
            this.txtSoLuong.TabIndex = 48;
            this.txtSoLuong.UseSelectable = true;
            this.txtSoLuong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoLuong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbKichThuoc
            // 
            this.cmbKichThuoc.FormattingEnabled = true;
            this.cmbKichThuoc.Location = new System.Drawing.Point(137, 129);
            this.cmbKichThuoc.Name = "cmbKichThuoc";
            this.cmbKichThuoc.Size = new System.Drawing.Size(135, 21);
            this.cmbKichThuoc.TabIndex = 49;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(46, 284);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(664, 150);
            this.dgvSanPham.TabIndex = 50;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tên sản phẩm ";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(137, 243);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(277, 23);
            this.txtTimKiem.TabIndex = 52;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(429, 240);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 31);
            this.btnTimKiem.TabIndex = 53;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 445);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.cmbKichThuoc);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Name = "frmSanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtMaSP;
        private MetroFramework.Controls.MetroTextBox txtTenSP;
        private MetroFramework.Controls.MetroTextBox txtDonGia;
        private MetroFramework.Controls.MetroTextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbKichThuoc;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnTimKiem;
    }
}