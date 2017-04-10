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
    public partial class frmQLNV : Form
    {
        NhanVienBll _nhanVienBll = new NhanVienBll();
        public frmQLNV()
        {
            InitializeComponent();
            dataGridView1.DataSource = _nhanVienBll.GetAllNhanVien();

        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
           

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            lblRowCount.Text =  dataGridView1.RowCount + " bản ghi.";
           
            cboChuyenMon.DataSource = _nhanVienBll.GetTenChuyenMonById();
            cboChuyenMon.DisplayMember = "TenCM";
            cboChuyenMon.ValueMember = "MaCM";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[1].Value.ToString();
            cboChuyenMon.SelectedValue = row.Cells[2].Value.ToString();
        }

     
    }
}
