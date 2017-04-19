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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private PHONGBAN _pb;
        
        
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            
            DataDataContext db = new DataDataContext();
            var lst = (from s in db.PHONGBANs select s).ToList();
            dgv_phongban.DataSource = lst;
            txtMaPB.DataBindings.Clear();
            txtTenPB.DataBindings.Clear();
            txtMaPB.DataBindings.Add("text", lst, "MaPB");
            txtTenPB.DataBindings.Add("text", lst, "TenPB");
        }

       

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var lst = (from s in db.PHONGBANs where s.MaPB.Contains(txtTimkiem.Text) || s.TenPB.Contains(txtTimkiem.Text) select s).ToList();
            dgv_phongban.DataSource = lst;
            txtMaPB.DataBindings.Clear();
            txtTenPB.DataBindings.Clear();
            txtMaPB.DataBindings.Add("text", lst, "MaPB");
            txtTenPB.DataBindings.Add("text", lst, "TenPB");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Are you sure?", @"Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (dr == DialogResult.Yes)
            {
                DataDataContext db = new DataDataContext();
                _pb = new PHONGBAN();

                _pb = db.PHONGBANs.Single(s => s.MaPB == txtMaPB.Text);
                _pb.MaPB = txtMaPB.Text;
                _pb.TenPB = txtTenPB.Text;
                db.PHONGBANs.DeleteOnSubmit(_pb);
                db.SubmitChanges();
                frmPhongBan_Load(sender, e);
            }
            
        }

        private bool check;
        private void btnThem_Click(object sender, EventArgs e)
        {
            check = true;
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtMaPB.Focus();
            
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check)
            {
                try
                {
                    DataDataContext db = new DataDataContext();
                    _pb = new PHONGBAN();
                    _pb.MaPB = txtMaPB.Text;
                    _pb.TenPB = txtTenPB.Text;

                    db.PHONGBANs.InsertOnSubmit(_pb);
                    db.SubmitChanges();
                    frmPhongBan_Load(sender, e);
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Thêm thất bại!");
                }
               

            }
            else
            {
                try
                {
                    DataDataContext db = new DataDataContext();
                    _pb = db.PHONGBANs.Single(s => s.MaPB == txtMaPB.Text);
                    _pb.MaPB = txtMaPB.Text;
                    _pb.TenPB = txtTenPB.Text;
                    db.SubmitChanges();
                    frmPhongBan_Load(sender, e);
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Sửa thất bại!");
                }
               
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = false;
            
            
        }
    }
}
