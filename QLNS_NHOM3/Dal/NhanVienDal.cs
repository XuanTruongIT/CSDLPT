using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dao;

namespace Dal
{
    public class NhanVienDal
    {
        ConnectDb _connectDb = new ConnectDb();
        public SqlDataAdapter Da;
        public SqlCommand Cmd;
        public DataTable Dt;
        public SqlConnection Conn = new SqlConnection(@"Data Source=XUANTRUONG;Initial Catalog=QLNS;Persist Security Info=True;User ID=sa;Password=123");
        public DataTable GetAllNhanVien()
        {
           
            const string sqlSelect = @"SELECT NV.MaNV, NV.MaCM, NV.MaPB, NV.MaCN, NV.MaTDHV, NV.HoTen, NV.GioiTinh, NV.QueQuan, NV.NgaySinh, NV.SDT  FROM NHANVIEN NV";
            Da = new SqlDataAdapter(sqlSelect, Conn);
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

        public void ThemNv(NhanVienDao nhanVienDao)
        {
            
            Conn.Open();
            const string sqlInsert = @"INSERT INTO dbo.NHANVIEN(MaNV,MaCM,MaPB,MaCN,MaTDHV,HoTen,GioiTinh,QueQuan,NgaySinh,SDT) VALUES (@MaNV,@MaCM,@MaPB,@MaCN,@MaTDHV,@HoTen,@GioiTinh,@QueQuan,@NgaySinh,@SDT)";
            Cmd = new SqlCommand(sqlInsert,Conn);
            Cmd.Parameters.AddWithValue("MaNV", nhanVienDao.MaNv);
            Cmd.Parameters.AddWithValue("MaCM", nhanVienDao.MaCm);
            Cmd.Parameters.AddWithValue("MaPB", nhanVienDao.MaPb);
            Cmd.Parameters.AddWithValue("MaCN", nhanVienDao.MaCn);
            Cmd.Parameters.AddWithValue("MaTDHV", nhanVienDao.MaTdhv);
            Cmd.Parameters.AddWithValue("HoTen", nhanVienDao.HoTen);
            Cmd.Parameters.AddWithValue("GioiTinh", nhanVienDao.GioiTinh);
            Cmd.Parameters.AddWithValue("QueQuan", nhanVienDao.QueQuan);
            Cmd.Parameters.AddWithValue("NgaySinh", nhanVienDao.NgaySinh);
            Cmd.Parameters.AddWithValue("SDT", nhanVienDao.Sdt);
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public void SuaNv(NhanVienDao nhanVienDao)
        {
            Conn.Open();
            const string sqlUpdate = @"UPDATE dbo.NHANVIEN SET MaCM = @MaCM, MaPB = @MaPB, MaCN = @MaCN, MaTDHV = @MaTDHV, HoTen = @HoTen, GioiTinh = @GioiTinh, QueQuan = @QueQuan, NgaySinh = @NgaySinh, SDT = @SDT  WHERE MaNV = @MaNV";
            Cmd = new SqlCommand(sqlUpdate,Conn);
            Cmd.Parameters.AddWithValue("MaNV", nhanVienDao.MaNv);
            Cmd.Parameters.AddWithValue("MaCM", nhanVienDao.MaCm);
            Cmd.Parameters.AddWithValue("MaPB", nhanVienDao.MaPb);
            Cmd.Parameters.AddWithValue("MaCN", nhanVienDao.MaCn);
            Cmd.Parameters.AddWithValue("MaTDHV", nhanVienDao.MaTdhv);
            Cmd.Parameters.AddWithValue("HoTen", nhanVienDao.HoTen);
            Cmd.Parameters.AddWithValue("GioiTinh", nhanVienDao.GioiTinh);
            Cmd.Parameters.AddWithValue("QueQuan", nhanVienDao.QueQuan);
            Cmd.Parameters.AddWithValue("NgaySinh", nhanVienDao.NgaySinh);
            Cmd.Parameters.AddWithValue("SDT", nhanVienDao.Sdt);
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public void XoaNv(string maNv)
        {
            Conn.Open();
            const string sqlDel = @"DELETE FROM dbo.NHANVIEN WHERE MaNV = @MaNV";
            Cmd = new SqlCommand(sqlDel, Conn);
            Cmd.Parameters.AddWithValue("MaNV", maNv);
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }
        
    }
}
