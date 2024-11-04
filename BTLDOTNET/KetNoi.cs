using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BTLDOTNET
{
    internal class KetNoi
    {
        string conStr = @"Data Source=DESKTOP-5EAAT0U\MAY1; Initial Catalog=TSport; Integrated Security=True";
        SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataSet LayDuLieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
        public int MaTraVe (string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = (int)cmd.ExecuteScalar();
                conn.Close();
                return r ;
            }
            catch
            {
                return -1;
            }
        }
    }
    public static class ThongTinDN
    {
        public static string UserName { get; set; }
    }
}
