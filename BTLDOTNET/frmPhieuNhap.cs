using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLDOTNET
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();

        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            getKichThuoc();
            LoaddgvCTPN();
            LoaddgvSanpham();
            getMaNV();
            getNCC();
        }
        KetNoi kn = new KetNoi();
        public void getKichThuoc()
        {
            string query = "select * from KICHTHUOC";
            DataSet ds = kn.LayDuLieu(query);
            cmbKichThuoc.DataSource = ds.Tables[0];
            cmbKichThuoc.DisplayMember = "TENKT";
            cmbKichThuoc.ValueMember = "MAKT";
        }
        private DataTable TableCTPN = new DataTable();
        private void LoaddgvCTPN()
        {
            TableCTPN.Columns.Add("MaHang", typeof(int));
            TableCTPN.Columns.Add("TenHang", typeof(string));
            TableCTPN.Columns.Add("KichThuoc", typeof(string));
            TableCTPN.Columns.Add("SoLuong", typeof(double));
            TableCTPN.Columns.Add("GiaNhap", typeof(double));

            dgvPhieuNhap.DataSource = TableCTPN;
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
            txtGiaNhap.Text = "";
            txtSoLuong.Text = "";
        }
        private void TongTien()
        {
            double tongtien = 0;
            int r = dgvPhieuNhap.Rows.Count;
            for (int i = 0; i < r - 1; i++)
            {
                tongtien = tongtien + (Convert.ToDouble(dgvPhieuNhap.Rows[i].Cells["GiaNhap"].Value.ToString()) * Convert.ToDouble(dgvPhieuNhap.Rows[i].Cells["SoLuong"].Value.ToString()));
            }
            LabelTT.Text = string.Format("{0:#,##0}", tongtien);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int kt = 0;
            try
            {
                double sl = Convert.ToDouble(txtSoLuong.Text);
                int r = dgvPhieuNhap.Rows.Count;
                if (r == 1)
                {
                    TableCTPN.Rows.Add(txtMaHang.Text, txtTenHang.Text, cmbKichThuoc.Text, txtSoLuong.Text, txtGiaNhap.Text);
                    dgvPhieuNhap.DataSource = TableCTPN;
                    clearText();
                    TongTien();
                }
                else
                {
                    for (int i = 0; i < r - 1; i++)
                    {
                        if (dgvPhieuNhap.Rows[i].Cells["MaHang"].Value.ToString() == txtMaHang.Text)
                        {
                            dgvPhieuNhap.Rows[i].Cells["SoLuong"].Value = Convert.ToString(sl + Convert.ToDouble(dgvPhieuNhap.Rows[i].Cells["SoLuong"].Value.ToString()));
                            clearText();
                            TongTien();
                            kt++;
                            break;
                        }
                    }
                    if (kt == 0)
                    {
                        TableCTPN.Rows.Add(txtMaHang.Text, txtTenHang.Text, cmbKichThuoc.Text, txtSoLuong.Text, txtGiaNhap.Text);
                        dgvPhieuNhap.DataSource = TableCTPN;
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
                    cmbKichThuoc.SelectedValue = dgvSanPham.Rows[r].Cells["MAKT"].Value.ToString();
                }
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvPhieuNhap.CurrentCell.RowIndex;
            if (r >= 0)
            {
                dgvPhieuNhap.Rows.RemoveAt(r);
                TongTien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvPhieuNhap.CurrentCell.RowIndex;
            try
            {
                if (r >= 0)
                {
                    dgvPhieuNhap.Rows[r].Cells["SoLuong"].Value = txtSoLuong.Text;
                    dgvPhieuNhap.Rows[r].Cells["KichThuoc"].Value = cmbKichThuoc.Text;
                    dgvPhieuNhap.Rows[r].Cells["GiaNhap"].Value = txtGiaNhap.Text;
                    clearText();
                    TongTien();
                }
            }
            catch
            {
                MessageBox.Show("Nhập lại thông tin sản phẩm.");

            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaHang.Text = dgvPhieuNhap.Rows[r].Cells["MaHang"].Value.ToString();
                txtTenHang.Text = dgvPhieuNhap.Rows[r].Cells["TenHang"].Value.ToString();
                txtGiaNhap.Text = dgvPhieuNhap.Rows[r].Cells["GiaNhap"].Value.ToString();
                cmbKichThuoc.Text = dgvPhieuNhap.Rows[r].Cells["KichThuoc"].Value.ToString();
                txtSoLuong.Text = dgvPhieuNhap.Rows[r].Cells["SoLuong"].Value.ToString();
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
        public void getMaNV()
        {
            string query = "select * from NHANVIEN";
            DataSet ds = kn.LayDuLieu(query);
            cmbMaNV.DataSource = ds.Tables[0];
            cmbMaNV.DisplayMember = "TENNV";
            cmbMaNV.ValueMember = "MANV";
        }
        public void getNCC()
        {
            string query = "select * from NHACUNGCAP";
            DataSet ds = kn.LayDuLieu(query);
            cmbNCC.DataSource = ds.Tables[0];
            cmbNCC.DisplayMember = "TENNCC";
            cmbNCC.ValueMember = "MANCC";
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaynhap = NgayNhap.Value.Date.ToString("yyy/MM/dd");
                string query = string.Format(
                "insert into PHIEUNHAP(MANV, NGAYNHAP,MANCC,TONGTIENNHAP) OUTPUT INSERTED.MAPN VALUES({0},'{1}',{2},'{3}')",
                cmbMaNV.SelectedValue,
                ngaynhap,
                cmbNCC.SelectedValue,
                LabelTT.Text = LabelTT.Text.Replace(",", "")

            );
                int matrave = kn.MaTraVe(query);
                if (matrave != -1)
                {
                    MessageBox.Show("Thêm mới thành công");
                    int r = dgvPhieuNhap.Rows.Count;
                    for (int i = 0; i < r - 1; i++)
                    {
                        string query1 = string.Format(
                      "insert into CHITIETPHIEUNHAP(MAPN, MASP, SOLUONG, GIANHAP) VALUES({0},{1},{2},{3})",
                        matrave,
                        Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells["MaHang"].Value.ToString()),
                        Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells["SoLuong"].Value.ToString()),
                        Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells["GiaNhap"].Value.ToString())
                        );
                        kn.ThucThi(query1);

                    }
                    for (int i = 0; i < r - 1; i++)
                    {
                        dgvPhieuNhap.Rows.RemoveAt(0);
                    }

                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện!");
            }


        }
    }
}
