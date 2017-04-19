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
    public partial class frmHopDongLaoDong : Form
    {
        public frmHopDongLaoDong()
        {
            InitializeComponent();
        }

        private HDLD _hd;

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var lst = (from s in db.HDLDs select s).ToList();
            dgv_hopdonglaodong.DataSource = lst;
            txtMaHD.DataBindings.Clear();
            txtTenHD.DataBindings.Clear();
            txtLoaiHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("text", lst, "MaHD");
            txtTenHD.DataBindings.Add("text", lst, "TenHD");
            txtLoaiHD.DataBindings.Add("text", lst, "LoaiHD");
        }

        private bool check;

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = true;
            txtMaHD.Clear();
            txtTenHD.Clear();
            txtLoaiHD.Clear();
            txtMaHD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check)
            {
                try
                {
                    DataDataContext db = new DataDataContext();
                    _hd = new HDLD();
                    _hd.MaHD = txtMaHD.Text;
                    _hd.TenHD = txtTenHD.Text;
                    _hd.LoaiHD = txtLoaiHD.Text;
                    db.HDLDs.InsertOnSubmit(_hd);
                    db.SubmitChanges();
                    frmHopDongLaoDong_Load(sender, e);
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
                    _hd = db.HDLDs.Single(s => s.MaHD == txtMaHD.Text);
                    _hd.MaHD = txtMaHD.Text;
                    _hd.TenHD = txtTenHD.Text;
                    _hd.LoaiHD = txtLoaiHD.Text;
                    db.SubmitChanges();
                    frmHopDongLaoDong_Load(sender, e);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Are you sure?", @"Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DataDataContext db = new DataDataContext();
                _hd = new HDLD();

                _hd = db.HDLDs.Single(s => s.MaHD == txtMaHD.Text);
                _hd.MaHD = txtMaHD.Text;
                _hd.TenHD = txtTenHD.Text;
                _hd.LoaiHD = txtLoaiHD.Text;
                db.HDLDs.DeleteOnSubmit(_hd);
                db.SubmitChanges();
                frmHopDongLaoDong_Load(sender, e);
            }
        }
    }
}

