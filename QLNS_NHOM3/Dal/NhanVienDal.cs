using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class NhanVienDal
    {
        ConnectDb _connectDb = new ConnectDb();
        public SqlDataAdapter Da;
        public SqlCommand Cmd;
        public DataTable Dt;
        public SqlConnection Conn = new SqlConnection(@"Data Source=TRAM-2;Initial Catalog=QLNS_TRAM2;Integrated Security=True");
        public DataTable GetAllNhanVien()
        {
           
            const string sqlSelect = @"SELECT NV.MaNV, NV.MaCM, NV.MaPB, NV.MaCN, NV.MaTDHV, NV.HoTen, NV.GioiTinh, NV.QueQuan, NV.NgaySinh, NV.SDT  FROM NHANVIEN NV";
            Da = new SqlDataAdapter(sqlSelect, Conn);
            Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable GetTenChuyenMonById()
        {

            string sql = @"SELECT * FROM dbo.CHUYENMON";
            Da = new SqlDataAdapter(sql, Conn);
            Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

      /*  public void DongBo()
        {
            Conn.Open();
            string sql = @"EXEC msdb.dbo.sp_start_job 'XUANTRUONG-QLNS-Rep1-TRAM-2-22';";
            Cmd = new SqlCommand(sql,Conn);
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }*/
    }
}
