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
    public class PhongBanBll
    {
        PhongBanDal _phongBanDal = new PhongBanDal();

        public DataTable GetAllPhongBan()
        {
            return _phongBanDal.GetAllPhongBan();
        }
       /* public void ThemPhongBan()
        {
             _phongBanDal.themPhongBan();
        }*/
    }
}
