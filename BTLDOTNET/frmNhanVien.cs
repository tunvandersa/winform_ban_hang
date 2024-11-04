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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if(ThongTinDN.UserName == "ADMIN")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThemLuong.Enabled = true;
                btnXoaLuong.Enabled = true;
                btnSuaLuong.Enabled = true;
            }

            getData();
            getMaLuong();
            getDataLuong();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = string.Format(
               "delete from NHANVIEN where MaNV = '{0}'",
               txtMaNV.Text
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
        public void getData()
        {
            string query = "select * from NHANVIEN";
            DataSet ds = kn.LayDuLieu(query);
            dgvNhanVien.DataSource = ds.Tables[0];
        }
        public void getMaLuong()
        {
            string query = "select * from LUONG";
            DataSet ds = kn.LayDuLieu(query);
            cmbLuong.DataSource = ds.Tables[0];
            cmbLuong.DisplayMember = "MUCLUONG";
            cmbLuong.ValueMember = "MALUONG";
        }
        public void clearText()
        {

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTimKiem.Text = "";
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
       }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ngaysinh = dtNgaySinh.Value.Date.ToString("yyy/MM/dd");
            string query = string.Format(
               "insert into NHANVIEN(TENNV, DIACHI, DIENTHOAI, NGAYSINH,CHUCVU, MALUONG) VALUES(N'{0}', N'{1}', '{2}','{3}',N'{4}','{5}')",
               txtTenNV.Text,
               txtDiaChi,
               txtDT.Text,
               ngaysinh,
               txtChucVu.Text,
               cmbLuong.SelectedValue
           ) ;
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
            string ngaysinh = dtNgaySinh.Value.Date.ToString("yyy/MM/dd");
            string query = string.Format(
                "update NHANVIEN set TENNV = N'{1}', DIACHI = N'{2}', DIENTHOAI = '{3}', NGAYSINH = '{4}', CHUCVU = N'{5}', MALUONG = {6} where MANV = '{0}'",
                txtMaNV.Text,
                txtTenNV.Text,
                txtDiaChi.Text,
                txtDT.Text,
                ngaysinh,
                txtChucVu.Text,
                cmbLuong.SelectedValue
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaNV.Text = dgvNhanVien.Rows[r].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[r].Cells["TenNV"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[r].Cells["DIACHI"].Value.ToString();
                txtDT.Text = dgvNhanVien.Rows[r].Cells["DIENTHOAI"].Value.ToString();
                dtNgaySinh.Text= dgvNhanVien.Rows[r].Cells["NGAYSINH"].Value.ToString();
                txtChucVu.Text = dgvNhanVien.Rows[r].Cells["CHUCVU"].Value.ToString();
                cmbLuong.SelectedValue = dgvNhanVien.Rows[r].Cells["MALUONG"].Value.ToString();
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
        public void getDataLuong()
        {
            string query = "select * from Luong";
            DataSet ds = kn.LayDuLieu(query);
            dgvLuong.DataSource = ds.Tables[0];
        }

        private void btnThemLuong_Click(object sender, EventArgs e)
        {
            string query = string.Format(
               "insert into LUONG(MUCLUONG) VALUES('{0}')",
               txtMucLuong.Text
           );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                btnLMLuong.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btnXoaLuong_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa mức lương?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = string.Format(
               "delete from LUONG where MALUONG = '{0}'",
               txtMaLuong.Text
           );
                if (kn.ThucThi(query) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    btnLMLuong.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update LUONG set MUCLUONG = N'{1}' where MALUONG = '{0}'",
                txtMaLuong.Text,
                txtMucLuong.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLMLuong.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaLuong.Text = dgvLuong.Rows[r].Cells["MaLuong"].Value.ToString();
                txtMucLuong.Text = dgvLuong.Rows[r].Cells["MucLuong"].Value.ToString();
               
            }
        }

        private void btnLMLuong_Click(object sender, EventArgs e)
        {
            getDataLuong();
            txtMaLuong.Text = "";
            txtMucLuong.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from NHANVIEN where TENNV like N'%{0}%'",
                txtTimKiem.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            dgvNhanVien.DataSource = ds.Tables[0];
        }
    }
}
