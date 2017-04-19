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
    public partial class frmChuyenMon : Form
    {
        public frmChuyenMon()
        {
            InitializeComponent();
        }

        private CHUYENMON _cm;


        private void frmChuyenMon_Load(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var lst = (from s in db.CHUYENMONs select s).ToList();
            dgv_chuyenmon.DataSource = lst;
            txtMaCM.DataBindings.Clear();
            txtTenCM.DataBindings.Clear();
            txtMaCM.DataBindings.Add("text", lst, "MaCM");
            txtTenCM.DataBindings.Add("text", lst, "TenCM");

        }

        private bool check;
        private void btnThem_Click(object sender, EventArgs e)
        {
            check = true;
            txtMaCM.Clear();
            txtTenCM.Clear();
            txtMaCM.Focus();
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
                    _cm = new CHUYENMON();
                    _cm.MaCM = txtMaCM.Text;
                    _cm.TenCM = txtTenCM.Text;
                    db.CHUYENMONs.InsertOnSubmit(_cm);
                    db.SubmitChanges();
                    frmChuyenMon_Load(sender,e);
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
                    _cm = new CHUYENMON();
                    _cm = db.CHUYENMONs.Single(s => s.MaCM == txtMaCM.Text);
                    _cm.MaCM = txtMaCM.Text;
                    _cm.TenCM = txtTenCM.Text;
                    db.SubmitChanges();
                    frmChuyenMon_Load(sender, e);
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
                _cm = new CHUYENMON();
                _cm = db.CHUYENMONs.Single(s => s.MaCM == txtMaCM.Text);
                _cm.MaCM = txtMaCM.Text;
                _cm.TenCM = txtTenCM.Text;
                db.CHUYENMONs.DeleteOnSubmit(_cm);
                db.SubmitChanges();
                frmChuyenMon_Load(sender, e);
            }
            
        }
    }
}
