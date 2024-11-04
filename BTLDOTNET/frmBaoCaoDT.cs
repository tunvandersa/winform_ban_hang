using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTLDOTNET
{
    public partial class frmBaoCaoDT : Form
    {
        public frmBaoCaoDT()
        {
            InitializeComponent();
           
        }

        KetNoi kn = new KetNoi();
        //Tìm hóa đơn
        private void btnTimHD_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaybd = dtDayBD.Value.Date.ToString("yyy/MM/dd") + " " + txtTimeBD.Text;
                string ngaykt = dtDayKT.Value.Date.ToString("yyy/MM/dd") + " " + txtTimeKT.Text;
                string query = string.Format("SELECT * FROM HOADON WHERE NGAYBAN BETWEEN '{0}' AND '{1}'",
                   ngaybd,
                   ngaykt);
                DataSet ds = kn.LayDuLieu(query);
                dgvHoaDon.DataSource = ds.Tables[0];
            }
            catch
            {
            }
            double doanhthu = 0;
            int r = dgvHoaDon.Rows.Count;
            if (r > 1)
            {
                for (int i = 0; i < r - 1; i++)
                {
                    doanhthu = doanhthu + Convert.ToDouble(dgvHoaDon.Rows[i].Cells["THANHTIEN"].Value.ToString());
                }
                txtDoanhThu.Text = string.Format("{0:#,##0}", doanhthu);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                if (r >=0)
                {
                    string mahoadon = dgvHoaDon.Rows[r].Cells["MAHD"].Value.ToString();
                    string query1 = string.Format("SELECT * FROM CHITIETHOADON WHERE MAHD='{0}'", mahoadon);
                    DataSet ds = kn.LayDuLieu(query1);
                    dgvChiTietHD.DataSource = ds.Tables[0];
                }
            }
            catch
            {

            }
            
        }


        //Tìm phiếu nhập
        private void btnTimPN_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaybdpn = NgayPNBD.Value.Date.ToString("yyy/MM/dd");
                string ngayktpn = NgayPNKT.Value.Date.ToString("yyy/MM/dd");
                string query = string.Format("SELECT * FROM PHIEUNHAP WHERE NGAYNHAP BETWEEN '{0}' AND '{1}'",
                   ngaybdpn,
                   ngayktpn);
                DataSet ds = kn.LayDuLieu(query);
                dgvPhieuNhap.DataSource = ds.Tables[0];
            }
            catch
            {
            }
            double tongtiennhap = 0;
            int r = dgvPhieuNhap.Rows.Count;
            if (r > 1)
            {
                for (int i = 0; i < r - 1; i++)
                {
                    tongtiennhap = tongtiennhap + Convert.ToDouble(dgvPhieuNhap.Rows[i].Cells["TONGTIENNHAP"].Value.ToString());
                }
                TongTienNhap.Text = string.Format("{0:#,##0}", tongtiennhap);
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                if (r >= 0)
                {
                    string maphieunhap = dgvPhieuNhap.Rows[r].Cells["MAPN"].Value.ToString();
                    string query1 = string.Format("SELECT * FROM CHITIETPHIEUNHAP WHERE MAPN='{0}'", maphieunhap);
                    DataSet ds = kn.LayDuLieu(query1);
                    dgvCTPN.DataSource = ds.Tables[0];

                }
            }
            catch
            {

            }
        }
    }
}
