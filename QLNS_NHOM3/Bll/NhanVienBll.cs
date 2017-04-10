using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bll
{
    public class NhanVienBll
    {
        NhanVienDal _nhanVienDal = new NhanVienDal();
        public DataTable GetAllNhanVien()
        {
            return _nhanVienDal.GetAllNhanVien();
        }

        public DataTable GetTenChuyenMonById()
        {
            return _nhanVienDal.GetTenChuyenMonById();
        }

        /*public void DongBo()
        {
            _nhanVienDal.DongBo();
        }*/
    }
}
