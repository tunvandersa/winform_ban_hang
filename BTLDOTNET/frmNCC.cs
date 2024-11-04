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
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void frmNCC_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            string query = "select * from NHACUNGCAP";
            DataSet ds = kn.LayDuLieu(query);
            dgvNCC.DataSource = ds.Tables[0];
        }
        public void clearText()
        {

            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }
      

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from NHACUNGCAP where TENNCC like N'%{0}%'",
                txtTimKiem.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            dgvNCC.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into NHACUNGCAP(TENNCC, DIACHI, DIENTHOAI) VALUES(N'{0}', N'{1}', '{2}')",
                txtTenNCC.Text,
                txtDiaChi.Text,
                txtDienThoai.Text
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
                "update NHACUNGCAP set TENNCC = N'{1}', DIACHI = N'{2}', DIENTHOAI = '{3}' where MANCC = '{0}'",
                txtMaNCC.Text,
                txtTenNCC.Text,
                txtDiaChi.Text,
                txtDienThoai.Text
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa NCC?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = string.Format(
               "delete from NHACUNGCAP where MANCC = '{0}'",
               txtMaNCC.Text
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
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtMaNCC.Text = dgvNCC.Rows[r].Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dgvNCC.Rows[r].Cells["TenNCC"].Value.ToString();
                txtDiaChi.Text = dgvNCC.Rows[r].Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgvNCC.Rows[r].Cells["DienThoai"].Value.ToString();
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
