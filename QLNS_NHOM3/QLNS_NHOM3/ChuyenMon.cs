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


    }
}
