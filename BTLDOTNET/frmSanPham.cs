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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            getKTSP();
            getData();

        }
        public void getData()
        {
            string query = "select * from SANPHAM";
            DataSet ds = kn.LayDuLieu(query);
            dgvSanPham.DataSource = ds.Tables[0];
        }
        public void getKTSP()
        {
            string query = "select * from KICHTHUOC";
            DataSet ds = kn.LayDuLieu(query);
            cmbKichThuoc.DataSource = ds.Tables[0];
            cmbKichThuoc.DisplayMember = "TENKT";
            cmbKichThuoc.ValueMember = "MAKT";

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = string.Format(
               "delete from SANPHAM where MaSP = '{0}'",
               txtMaSP.Text
           );
                if (kn.ThucThi(query) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select SANPHAM.* from SanPham inner join KICHTHUOC on SANPHAM.MAKT = KICHTHUOC.MAKT where SANPHAM.TENSP like N'%{0}%'",
                txtTimKiem.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            dgvSanPham.DataSource = ds.Tables[0];
        }
        public void clearText()
        {
         
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtTimKiem.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into SANPHAM(TENSP, MAKT,DONGIA,SOLUONG ) VALUES(N'{0}', '{1}', '{2}',0)",
                txtTenSP.Text,
                cmbKichThuoc.SelectedValue,
                txtDonGia.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update SANPHAM set TENSP = N'{1}', MAKT = '{2}', DONGIA = '{3}' where MASP = '{0}'",
                txtMaSP.Text,
                txtTenSP.Text,
                cmbKichThuoc.SelectedValue,
                txtDonGia.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaSP.Text = dgvSanPham.Rows[r].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[r].Cells["TenSP"].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[r].Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = dgvSanPham.Rows[r].Cells["SoLuong"].Value.ToString();
                cmbKichThuoc.SelectedValue = dgvSanPham.Rows[r].Cells["MaKT"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
      
        }
    }
}
