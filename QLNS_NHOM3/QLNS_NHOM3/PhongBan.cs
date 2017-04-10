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
using Dal;
using Dao;
namespace QLNS_NHOM3
{
    public partial class PhongBan : Form
    {
        PhongBanBll _phongBanBll = new PhongBanBll();

        PhongBanDal _phongBanDal = new PhongBanDal();

        public PhongBan()
        {
            InitializeComponent();
            dataGridView1.DataSource = _phongBanBll.GetAllPhongBan();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            label5.Text = null;
            label6.Text = null;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            label4.Text = dataGridView1.RowCount + " bản ghi.";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaPB.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ActiveControl = txtMaPB;
            txtMaPB.Focus();
            btnLuu.Enabled = true;
            txtMaPB.Text = null;
            txtTen.Text = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhongBaoDao pbd = new PhongBaoDao();
            pbd.MaPB = txtMaPB.Text;
            pbd.TenPB = txtTen.Text;

            _phongBanDal.themPhongBan(pbd);
            dataGridView1.DataSource = _phongBanBll.GetAllPhongBan();
        }
    }
}
