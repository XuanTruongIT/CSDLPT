using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;

namespace QLNS_NHOM3
{
    public partial class frmQuanLyNhanSu : Form
    {
        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Dispose();

        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            frmPhongBan frmPhongBan = new frmPhongBan();
            frmPhongBan.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNV frmQlnv = new frmQLNV();
            frmQlnv.Show();
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            frmChiNhanh frmChiNhanh = new frmChiNhanh();
            frmChiNhanh.Show();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu frmChucVu = new frmChucVu();
            frmChucVu.Show();
        }

        private void btnChuyenMon_Click(object sender, EventArgs e)
        {
            frmChuyenMon frmChuyenMon = new frmChuyenMon();
            frmChuyenMon.Show();
        }
        public int i = 0;
        private void btnSync_Click(object sender, EventArgs e)
        {
            NhanVienBll nhanVienBll = new NhanVienBll();
            string sql1 = @"EXEC msdb.dbo.sp_start_job 'XUANTRUONG-QLNS-Rep1-TRAM-1-8'";
            string sql2 = @"EXEC msdb.dbo.sp_start_job 'XUANTRUONG-QLNS-Rep1-TRAM-2-9'";
            string sql3 = @"EXEC msdb.dbo.sp_start_job 'XUANTRUONG-QLNS-Rep1-TRAM-3-10'";
            nhanVienBll.Sync(sql1);
            nhanVienBll.Sync(sql2);
            nhanVienBll.Sync(sql3);
            frmSync frmSync = new frmSync();
            frmSync.Show();


        }


        
    }
}
