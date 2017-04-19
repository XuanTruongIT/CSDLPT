using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
