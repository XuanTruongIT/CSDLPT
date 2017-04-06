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
            // TODO: This line of code loads data into the 'qLNSDataSet4.TDHV' table. You can move, or remove it, as needed.
            this.tDHVTableAdapter.Fill(this.qLNSDataSet4.TDHV);
            // TODO: This line of code loads data into the 'qLNSDataSet3.CHINHANH' table. You can move, or remove it, as needed.
            this.cHINHANHTableAdapter.Fill(this.qLNSDataSet3.CHINHANH);
            // TODO: This line of code loads data into the 'qLNSDataSet2.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.qLNSDataSet2.PHONGBAN);
            // TODO: This line of code loads data into the 'qLNSDataSet1.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter1.Fill(this.qLNSDataSet1.CHUYENMON);
            // TODO: This line of code loads data into the 'qLNSDataSet.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.qLNSDataSet.CHUYENMON);
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

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                _nhanVienBll.DongBo();
                MessageBox.Show("OK");
                dataGridView1.DataSource = _nhanVienBll.GetAllNhanVien();

            }
            catch (Exception)
            {

                MessageBox.Show("Loi");
            }
        }
    }
}
