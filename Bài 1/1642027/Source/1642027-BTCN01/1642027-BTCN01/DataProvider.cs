using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace _1642027_BTCN01
{
    class DataProvider
    {
        public DataTable HienThiHocSinh()
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=DemoHocSinh;Trusted_Connection=True; ");
            DataTable dt = new DataTable();
            string sql = "select * from HocSinh ";
            SqlDataAdapter da;
            da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public  int ThemHocSinh(String Ten, String NgaySinh, String Lop)
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=DemoHocSinh;Trusted_Connection=True; ");
            cn.Open();
            string sql = string.Format("Insert into HocSinh(TenHocSinh,NgaySinh,Lop) values('{0}','{1}','{2}')",Ten,NgaySinh,Lop);
            SqlCommand cm = new SqlCommand(sql, cn);
            int rs = -1;
            rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs;
        }
        public  int XoaHocSinh(String Ma)
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=DemoHocSinh;Trusted_Connection=True;");
            cn.Open();
            string sql = string.Format("delete from HocSinh where MaHocSinh='{0}'", Ma);
            SqlCommand cm = new SqlCommand(sql, cn);
            int rs = -1;
            rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs;
        }
        public  int UpdateHocSinh(String Ma,String Ten,String NgaySinh,String Lop)
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=DemoHocSinh;Trusted_Connection=True;");
            cn.Open();
            string sql = string.Format("update HocSinh Set TenHocSinh=N'{0}', NgaySinh='{1}', Lop='{2}' where MaHocSinh='{3}' ",Ten,NgaySinh,Lop,Ma);
            SqlCommand cm = new SqlCommand(sql, cn);
            int rs = -1;
            rs = cm.ExecuteNonQuery();
            cn.Close();
            return rs;
        }
        public DataTable TimKiemTheoTen(String Ten)
        {
            SqlConnection cn = new SqlConnection("Server=.;Database=DemoHocSinh;Trusted_Connection=True; ");
            DataTable dt = new DataTable();
            string sql = "select * from HocSinh WHERE TenHocSInh LIKE '%"+ Ten +"%'; ";
            SqlDataAdapter da;
            da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
    }
}
