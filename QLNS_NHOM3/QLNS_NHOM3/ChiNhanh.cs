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
    public partial class frmChiNhanh : Form
    {
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private CHINHANH _cn;

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var lst = (from s in db.CHINHANHs select s).ToList();
            dgv_chinhanh.DataSource = lst;
            txtMaCN.DataBindings.Clear();
            txtTenCN.DataBindings.Clear();
            
            txtMaCN.DataBindings.Add("text", lst, "MaCN");
            txtTenCN.DataBindings.Add("text", lst, "TenCN");
        }

        private bool check;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCN.Clear();
            txtTenCN.Clear();
            txtMaCN.Focus();
            check = true;
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
                    _cn = new CHINHANH();
                    _cn.MaCN = txtMaCN.Text;
                    _cn.TenCN = txtTenCN.Text;
                    db.CHINHANHs.InsertOnSubmit(_cn);
                    db.SubmitChanges();
                    frmChiNhanh_Load(sender, e);
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
                    _cn = new CHINHANH();
                    _cn = db.CHINHANHs.Single(s => s.MaCN == txtMaCN.Text);
                    _cn.MaCN = txtMaCN.Text;
                    _cn.TenCN = txtTenCN.Text;
                    db.SubmitChanges();
                    frmChiNhanh_Load(sender,e);
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
                _cn = new CHINHANH();
                _cn = db.CHINHANHs.Single(s => s.MaCN == txtMaCN.Text);
                _cn.MaCN = txtMaCN.Text;
                _cn.TenCN = txtTenCN.Text;
                db.CHINHANHs.DeleteOnSubmit(_cn);
                db.SubmitChanges();
                frmChiNhanh_Load(sender, e);
            }
        }
    }
}
