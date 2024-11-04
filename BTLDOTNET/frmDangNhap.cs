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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = string.Format(
              "select * from TAIKHOAN where TAIKHOAN = '{0}' and MATKHAU = '{1}'",
              txtTaiKhoan.Text,
              txtMatKhau.Text
          );
            DataSet ds = kn.LayDuLieu(query);
            DataTable table = ds.Tables[0]; 
            try
            {
                ThongTinDN.UserName = table.Rows[0][2].ToString();
            }
            catch
            {

            }
           
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                txtMatKhau.Text = "";
                frmHeThong frm = new frmHeThong();
                Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
