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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        private CHUCVU _cv;

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var lst = (from s in db.CHUCVUs select s).ToList();
            dgv_chucvu.DataSource = lst;
            txtMaCV.DataBindings.Clear();
            txtTenCV.DataBindings.Clear();
            txtPhuCap.DataBindings.Clear();
            txtMaCV.DataBindings.Add("text", lst, "MaCV");
            txtTenCV.DataBindings.Add("text", lst, "TenCV");
            txtPhuCap.DataBindings.Add("text", lst, "PhuCap");

        }

        private bool check;

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = true;
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtPhuCap.Clear();
            txtMaCV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check)
            {
                try
                {
                    DataDataContext db = new DataDataContext();
                    _cv = new CHUCVU();
                    _cv.MaCV = txtMaCV.Text;
                    _cv.TenCV = txtTenCV.Text;
                    _cv.PhuCap = int.Parse(txtPhuCap.Text);
                    db.CHUCVUs.InsertOnSubmit(_cv);
                    db.SubmitChanges();
                    frmChucVu_Load(sender, e);
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
                    _cv = new CHUCVU();
                    _cv = db.CHUCVUs.Single(s => s.MaCV == txtMaCV.Text);
                    _cv.MaCV = txtMaCV.Text;
                    _cv.TenCV = txtTenCV.Text;
                    _cv.PhuCap = int.Parse(txtPhuCap.Text);
                    db.SubmitChanges();
                    frmChucVu_Load(sender, e);
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Sửa thất bại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Are you sure?", @"Confirmation", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DataDataContext db = new DataDataContext();
                _cv = new CHUCVU();
                _cv = db.CHUCVUs.Single(s => s.MaCV == txtMaCV.Text);
                _cv.MaCV = txtMaCV.Text;
                _cv.TenCV = txtTenCV.Text;
                _cv.PhuCap = int.Parse(txtPhuCap.Text);
                db.CHUCVUs.DeleteOnSubmit(_cv);
                db.SubmitChanges();
                frmChucVu_Load(sender, e);
            }
        }
    }
}
