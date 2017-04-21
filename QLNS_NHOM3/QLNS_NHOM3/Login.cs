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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            

        }
        private void DangNhap()
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show(@"Bạn chưa nhập thông tin tài khoản! ");
                txtTaiKhoan.Focus();
            }
            else
            {
                if (this.txtTaiKhoan.Text.Length == 0)
                {
                    MessageBox.Show(@"Bạn chưa nhập tài khoản");
                    txtTaiKhoan.Focus();
                }
                    
                else if (this.txtMatKhau.Text.Length == 0)
                {
                    MessageBox.Show(@"Bạn chưa nhập mật khẩu");
                    txtMatKhau.Focus();
                }
                   
                else if (this.txtTaiKhoan.Text == @"admin" && this.txtMatKhau.Text == @"admin")
                    MessageBox.Show(@"Đăng nhập thành công !");
                else

                {
                    MessageBox.Show(@"Đăng nhập thất bại! Tài khoản không tồn tại ");
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }

         }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
            frmQuanLyNhanSu f1 = new frmQuanLyNhanSu();
            
            if (this.txtTaiKhoan.Text == @"admin" && this.txtMatKhau.Text == @"admin")
            {
                f1.Show();
                this.Hide();
                

            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
