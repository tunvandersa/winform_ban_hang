using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BTLDOTNET
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoaddgvHoaDon();
            getKichThuoc();
            LoaddgvSanpham();
            LoadDateTimePicker();
            getMaNV();
        }
        public void getKichThuoc()
        {
            string query = "select * from KICHTHUOC";
            DataSet ds = kn.LayDuLieu(query);
            cmbKichThuoc.DataSource = ds.Tables[0];
            cmbKichThuoc.DisplayMember = "TENKT";
            cmbKichThuoc.ValueMember = "MAKT";
        }
        private DataTable TableCTDH = new DataTable();

        private void LoaddgvHoaDon()
        {
            TableCTDH.Columns.Add("MaHang", typeof(int));
            TableCTDH.Columns.Add("TenHang", typeof(string));
            TableCTDH.Columns.Add("KichThuoc", typeof(string));
            TableCTDH.Columns.Add("SoLuong", typeof(double));
            TableCTDH.Columns.Add("DonGia", typeof(double));

            dgvHoaDon.DataSource = TableCTDH;
        }
        private void LoaddgvSanpham()
        {
            string query = "select * from SANPHAM";
            DataSet ds = kn.LayDuLieu(query);
            dgvSanPham.DataSource = ds.Tables[0];
        }
        public void clearText()
        {
            btnThem.Enabled = true;
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }
        private void TongTien()
        {
            double tongtien = 0;
            int r = dgvHoaDon.Rows.Count;
            for (int i = 0; i < r - 1; i++)
            {
                tongtien = tongtien + (Convert.ToDouble(dgvHoaDon.Rows[i].Cells["DonGia"].Value.ToString()) * Convert.ToDouble(dgvHoaDon.Rows[i].Cells["SoLuong"].Value.ToString()));
            }
            LabelTT.Text = string.Format("{0:#,##0}", tongtien);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int kt = 0;
            try
            {
                double sl = Convert.ToDouble(txtSoLuong.Text);
                int r = dgvHoaDon.Rows.Count;
                if (r == 1)
                {
                    TableCTDH.Rows.Add(txtMaHang.Text, txtTenHang.Text, cmbKichThuoc.Text, txtSoLuong.Text, txtDonGia.Text);
                    dgvHoaDon.DataSource = TableCTDH;
                    clearText();
                    TongTien();
                }
                else
                {
                    for (int i = 0; i < r - 1; i++)
                    {
                        if (dgvHoaDon.Rows[i].Cells["MaHang"].Value.ToString() == txtMaHang.Text)
                        {
                            dgvHoaDon.Rows[i].Cells["SoLuong"].Value = Convert.ToString(sl + Convert.ToDouble(dgvHoaDon.Rows[i].Cells["SoLuong"].Value.ToString()));
                            clearText();
                            TongTien();
                            kt++;
                            break;
                        }
                    }
                    if (kt == 0)
                    {
                        TableCTDH.Rows.Add(txtMaHang.Text, txtTenHang.Text, cmbKichThuoc.Text, txtSoLuong.Text, txtDonGia.Text);
                        dgvHoaDon.DataSource = TableCTDH;
                        clearText();
                        TongTien();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập lại thông tin sản phẩm");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string query = string.Format(
                "select SANPHAM.* from SANPHAM inner join KICHTHUOC on SANPHAM.MAKT = KICHTHUOC.MAKT where SANPHAM.TENSP like N'%{0}%'",
                txtTenHang.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            dgvSanPham.DataSource = ds.Tables[0];
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int r = e.RowIndex;
                if (r >= 0)
                {
                    txtMaHang.Enabled = false;
                    txtMaHang.Text = dgvSanPham.Rows[r].Cells["MASP"].Value.ToString();
                    txtTenHang.Text = dgvSanPham.Rows[r].Cells["TENSP"].Value.ToString();
                    txtDonGia.Text = dgvSanPham.Rows[r].Cells["DONGIA"].Value.ToString();
                    cmbKichThuoc.SelectedValue = dgvSanPham.Rows[r].Cells["MAKT"].Value.ToString();
                }
            }
            catch
            {
               
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            if (r >= 0)
            {
                dgvHoaDon.Rows.RemoveAt(r);
                TongTien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            try
            {
                if (r >= 0)
                {
                    dgvHoaDon.Rows[r].Cells["SoLuong"].Value = txtSoLuong.Text;
                    dgvHoaDon.Rows[r].Cells["KichThuoc"].Value = cmbKichThuoc.Text;
                    clearText();
                    TongTien();
                }
            }
            catch
            {
                MessageBox.Show("Nhập lại thông tin sản phẩm.");

            }

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaHang.Text = dgvHoaDon.Rows[r].Cells["MaHang"].Value.ToString();
                txtTenHang.Text = dgvHoaDon.Rows[r].Cells["TenHang"].Value.ToString();
                txtDonGia.Text = dgvHoaDon.Rows[r].Cells["DonGia"].Value.ToString();
                cmbKichThuoc.Text = dgvHoaDon.Rows[r].Cells["KichThuoc"].Value.ToString();
                txtSoLuong.Text = dgvHoaDon.Rows[r].Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadDateTimePicker()
        {
            DateTime now = DateTime.Now;
            string dateStr = now.ToString("yyy/ MM / dd hh:mm:ss");
            txtNgayBan.Text = dateStr;
        }
        public void getMaNV()
        {
            string query = "select * from NHANVIEN";
            DataSet ds = kn.LayDuLieu(query);
            cmbMaNV.DataSource = ds.Tables[0];
            cmbMaNV.DisplayMember = "TENNV";
            cmbMaNV.ValueMember = "MANV";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            

                string query = string.Format(
               "insert into HOADON(MANV, NGAYBAN, THANHTIEN,TENKH,DIENTHOAI) OUTPUT INSERTED.MAHD VALUES({0},'{1}',{2},'{3}','{4}')",
               cmbMaNV.SelectedValue,
               txtNgayBan.Text,
               LabelTT.Text = LabelTT.Text.Replace(",", ""),
               txtTenKH.Text,
               txtDienThoai.Text
           );
                int matrave = kn.MaTraVe(query);
                if (matrave != -1)
                {
                    MessageBox.Show("Thêm mới thành công");
                    int r = dgvHoaDon.Rows.Count;
                    for (int i = 0; i < r - 1; i++)
                    {
                        string query1 = string.Format(
                      "insert into CHITIETHOADON(MAHD, MASP, SOLUONG) VALUES({0},{1},{2})",
                        matrave,
                        Convert.ToInt32(dgvHoaDon.Rows[i].Cells["MaHang"].Value.ToString()),
                        Convert.ToInt32(dgvHoaDon.Rows[i].Cells["SoLuong"].Value.ToString())
                        );
                        kn.ThucThi(query1);
                        
                    }
                    for (int i = 0; i < r - 1; i++)
                    {
                        dgvHoaDon.Rows.RemoveAt(0);
                    }

                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại");
                }
            }
 

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            LoadDateTimePicker();        
            btnThanhToan.Enabled = true;
            
        }

      
    }
}
            
            
