using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;

namespace Dal
{
    public class PhongBanDal
    {
       
        ConnectDb _connectDb = new ConnectDb();
        public SqlDataAdapter Da;
        public SqlCommand Cmd;
        public DataTable Dt;
        public SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLNS_TRAM2;User ID=sa;Password=123");



        public DataTable GetAllPhongBan()
        {

            const string sqlSelect = @"SELECT PB.MaPB, PB.TenPB  FROM PHONGBAN PB";
            Da = new SqlDataAdapter(sqlSelect, Conn);
            Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }
        public void themPhongBan(PhongBanDao pbd)
        {
           // const string strConn = @"Data Source=TRAM-2;Initial Catalog=QLNS_TRAM2;Integrated Security=True";
           // Conn = new SqlConnection(strConn);
            Conn.Open();
            string sql = "insert into PHONGBAN(MaPB,TenPB) values (@MaPB, @TenPB)";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("MaPB", pbd.MaPB);
            Cmd.Parameters.AddWithValue("TenPB", pbd.TenPB);
  
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void suaPhongBan(PhongBanDao pbd)
        {
            Conn.Open();
            string sql = "update PhongBan set MaPB=@MaPB, TenPB=@TenPB where MaPB=@MaPB";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("MaPB", pbd.MaPB);
            Cmd.Parameters.AddWithValue("TenPB", pbd.TenPB);
      
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void xoaPhongBan(string MaPB)
        {

            Conn.Open();
            string sql = "delete from PhongBan where MaPB=@MaPB";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("MaPB", MaPB);
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public PhongBanDao timKiem(string sid)
        {
            PhongBanDao pdb = new PhongBanDao();
            Conn.Open();
            string sql = "select * from PhongBan where MaPB=@MaPB";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("MaPB", sid);
            Cmd.Parameters.AddWithValue("TenPB", sid);
            SqlDataReader rd = Cmd.ExecuteReader();
            if (rd != null)
            {
                rd.Read();
                pdb = new PhongBanDao();
                pdb.MaPB = Convert.ToString(rd["MaPB"]);
                pdb.TenPB = Convert.ToString(rd["TenPB"]);

            }
            return pdb;
        }
    }
}
