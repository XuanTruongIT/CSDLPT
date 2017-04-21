using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dao;

namespace Bll
{
    public class NhanVienBll
    {
         NhanVienDal _nhanVienDal = new NhanVienDal();
         //NhanVienDao _nhanVienDao = new NhanVienDao();
        public DataTable GetAllNhanVien()
        {
            return _nhanVienDal.GetAllNhanVien();
        }

       

        /*public void DongBo()
        {
            _nhanVienDal.DongBo();
        }*/

        public void ThemNv(NhanVienDao nhanVienDao)
        {
            _nhanVienDal.ThemNv(nhanVienDao);
        }

        public void SuaNv(NhanVienDao nhanVienDao)
        {
            _nhanVienDal.SuaNv(nhanVienDao);
        }
        public void XoaNv(string maNv)
        {
            _nhanVienDal.XoaNv(maNv);
        }

        public DataTable TimKiem(string sql)
        {
            return _nhanVienDal.TimKiem(sql);
        }

        public void Sync(string sql)
        {
            _nhanVienDal.Sync(sql);
        }
    }
}
