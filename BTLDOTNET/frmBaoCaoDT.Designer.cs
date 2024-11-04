
namespace BTLDOTNET
{
    partial class frmBaoCaoDT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDoanhThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTimeKT = new MetroFramework.Controls.MetroTextBox();
            this.txtTimeBD = new MetroFramework.Controls.MetroTextBox();
            this.btnTimHD = new FontAwesome.Sharp.IconButton();
            this.dtDayKT = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDayBD = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TongTienNhap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnTimPN = new FontAwesome.Sharp.IconButton();
            this.NgayPNKT = new MetroFramework.Controls.MetroDateTime();
            this.label6 = new System.Windows.Forms.Label();
            this.NgayPNBD = new MetroFramework.Controls.MetroDateTime();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 481);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtTimeKT);
            this.tabPage1.Controls.Add(this.txtTimeBD);
            this.tabPage1.Controls.Add(this.btnTimHD);
            this.tabPage1.Controls.Add(this.dtDayKT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtDayBD);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm kiếm hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietHD);
            this.groupBox2.Location = new System.Drawing.Point(10, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 185);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(54, 15);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.Size = new System.Drawing.Size(734, 152);
            this.dgvChiTietHD.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDoanhThu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 178);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.AutoSize = true;
            this.txtDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDoanhThu.Location = new System.Drawing.Point(805, 52);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(15, 16);
            this.txtDoanhThu.TabIndex = 6;
            this.txtDoanhThu.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(805, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doanh thu:";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(54, 15);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(734, 152);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // txtTimeKT
            // 
            // 
            // 
            // 
            this.txtTimeKT.CustomButton.Image = null;
            this.txtTimeKT.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtTimeKT.CustomButton.Name = "";
            this.txtTimeKT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimeKT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeKT.CustomButton.TabIndex = 1;
            this.txtTimeKT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeKT.CustomButton.UseSelectable = true;
            this.txtTimeKT.CustomButton.Visible = false;
            this.txtTimeKT.Lines = new string[0];
            this.txtTimeKT.Location = new System.Drawing.Point(648, 19);
            this.txtTimeKT.MaxLength = 32767;
            this.txtTimeKT.Name = "txtTimeKT";
            this.txtTimeKT.PasswordChar = '\0';
            this.txtTimeKT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeKT.SelectedText = "";
            this.txtTimeKT.SelectionLength = 0;
            this.txtTimeKT.SelectionStart = 0;
            this.txtTimeKT.ShortcutsEnabled = true;
            this.txtTimeKT.Size = new System.Drawing.Size(96, 23);
            this.txtTimeKT.TabIndex = 27;
            this.txtTimeKT.UseSelectable = true;
            this.txtTimeKT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeKT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTimeBD
            // 
            // 
            // 
            // 
            this.txtTimeBD.CustomButton.Image = null;
            this.txtTimeBD.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtTimeBD.CustomButton.Name = "";
            this.txtTimeBD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimeBD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeBD.CustomButton.TabIndex = 1;
            this.txtTimeBD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeBD.CustomButton.UseSelectable = true;
            this.txtTimeBD.CustomButton.Visible = false;
            this.txtTimeBD.Lines = new string[0];
            this.txtTimeBD.Location = new System.Drawing.Point(267, 18);
            this.txtTimeBD.MaxLength = 32767;
            this.txtTimeBD.Name = "txtTimeBD";
            this.txtTimeBD.PasswordChar = '\0';
            this.txtTimeBD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeBD.SelectedText = "";
            this.txtTimeBD.SelectionLength = 0;
            this.txtTimeBD.SelectionStart = 0;
            this.txtTimeBD.ShortcutsEnabled = true;
            this.txtTimeBD.Size = new System.Drawing.Size(97, 23);
            this.txtTimeBD.TabIndex = 26;
            this.txtTimeBD.UseSelectable = true;
            this.txtTimeBD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeBD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTimHD
            // 
            this.btnTimHD.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimHD.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnTimHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimHD.IconSize = 25;
            this.btnTimHD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimHD.Location = new System.Drawing.Point(756, 15);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(88, 31);
            this.btnTimHD.TabIndex = 23;
            this.btnTimHD.Text = "Tìm Kiếm";
            this.btnTimHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimHD.UseVisualStyleBackColor = true;
            this.btnTimHD.Click += new System.EventHandler(this.btnTimHD_Click);
            // 
            // dtDayKT
            // 
            this.dtDayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDayKT.Location = new System.Drawing.Point(415, 15);
            this.dtDayKT.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDayKT.Name = "dtDayKT";
            this.dtDayKT.Size = new System.Drawing.Size(218, 29);
            this.dtDayKT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến";
            // 
            // dtDayBD
            // 
            this.dtDayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDayBD.Location = new System.Drawing.Point(46, 15);
            this.dtDayBD.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDayBD.Name = "dtDayBD";
            this.dtDayBD.Size = new System.Drawing.Size(215, 29);
            this.dtDayBD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnTimPN);
            this.tabPage2.Controls.Add(this.NgayPNKT);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.NgayPNBD);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCTPN);
            this.groupBox3.Location = new System.Drawing.Point(10, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(898, 185);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu nhập";
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(54, 15);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.Size = new System.Drawing.Size(734, 152);
            this.dgvCTPN.TabIndex = 28;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TongTienNhap);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvPhieuNhap);
            this.groupBox4.Location = new System.Drawing.Point(10, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(921, 178);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phiếu nhập";
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.AutoSize = true;
            this.TongTienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTienNhap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TongTienNhap.Location = new System.Drawing.Point(805, 52);
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.Size = new System.Drawing.Size(15, 16);
            this.TongTienNhap.TabIndex = 6;
            this.TongTienNhap.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(805, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiền nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(54, 15);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(734, 152);
            this.dgvPhieuNhap.TabIndex = 4;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // btnTimPN
            // 
            this.btnTimPN.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimPN.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnTimPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimPN.IconSize = 25;
            this.btnTimPN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimPN.Location = new System.Drawing.Point(710, 10);
            this.btnTimPN.Name = "btnTimPN";
            this.btnTimPN.Size = new System.Drawing.Size(88, 31);
            this.btnTimPN.TabIndex = 35;
            this.btnTimPN.Text = "Tìm Kiếm";
            this.btnTimPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimPN.UseVisualStyleBackColor = true;
            this.btnTimPN.Click += new System.EventHandler(this.btnTimPN_Click);
            // 
            // NgayPNKT
            // 
            this.NgayPNKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayPNKT.Location = new System.Drawing.Point(415, 12);
            this.NgayPNKT.MinimumSize = new System.Drawing.Size(0, 29);
            this.NgayPNKT.Name = "NgayPNKT";
            this.NgayPNKT.Size = new System.Drawing.Size(218, 29);
            this.NgayPNKT.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "đến";
            // 
            // NgayPNBD
            // 
            this.NgayPNBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayPNBD.Location = new System.Drawing.Point(46, 12);
            this.NgayPNBD.MinimumSize = new System.Drawing.Size(0, 29);
            this.NgayPNBD.Name = "NgayPNBD";
            this.NgayPNBD.Size = new System.Drawing.Size(215, 29);
            this.NgayPNBD.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Từ";
            // 
            // frmBaoCaoDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBaoCaoDT";
            this.Text = "Tìm kiếm hóa đơn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroDateTime dtDayKT;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dtDayBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private FontAwesome.Sharp.IconButton btnTimHD;
        private MetroFramework.Controls.MetroTextBox txtTimeBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TongTienNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private FontAwesome.Sharp.IconButton btnTimPN;
        private MetroFramework.Controls.MetroDateTime NgayPNKT;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroDateTime NgayPNBD;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtTimeKT;
    }
}