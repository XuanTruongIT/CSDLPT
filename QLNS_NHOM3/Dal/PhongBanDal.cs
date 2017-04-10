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
        public SqlConnection Conn = new SqlConnection(@"Data Source=TRAM-2;Initial Catalog=QLNS_TRAM2;Integrated Security=True");



        public DataTable GetAllPhongBan()
        {

            const string sqlSelect = @"SELECT PB.MaPB, PB.TenPB  FROM PHONGBAN PB";
            Da = new SqlDataAdapter(sqlSelect, Conn);
            Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }
        public void themPhongBan(PhongBaoDao pbd)
        {
           // const string strConn = @"Data Source=TRAM-2;Initial Catalog=QLNS_TRAM2;Integrated Security=True";
           // Conn = new SqlConnection(strConn);
            Conn.Open();
            string sql = "insert into PHONGBAN values (@MaPB, @TenPB)";
            Cmd = new SqlCommand(sql, Conn);
            Cmd.Parameters.AddWithValue("MaPB", pbd.MaPB);
            Cmd.Parameters.AddWithValue("TenPB", pbd.TenPB);
  
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

    }
}
