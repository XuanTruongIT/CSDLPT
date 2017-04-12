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
            

        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet_TDHV.TDHV' table. You can move, or remove it, as needed.
            this.tDHVTableAdapter.Fill(this.qLNSDataSet_TDHV.TDHV);
            // TODO: This line of code loads data into the 'qLNSDataSet_ChiNhanh.CHINHANH' table. You can move, or remove it, as needed.
            this.cHINHANHTableAdapter.Fill(this.qLNSDataSet_ChiNhanh.CHINHANH);
            // TODO: This line of code loads data into the 'qLNSDataSet_PhongBan.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.qLNSDataSet_PhongBan.PHONGBAN);
            // TODO: This line of code loads data into the 'qLNSDataSet_ChuyenMon.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.qLNSDataSet_ChuyenMon.CHUYENMON);

            dataGridView1.DataSource = _nhanVienBll.GetAllNhanVien();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            lblRowCount.Text =  string.Format("{0} bản ghi.", dataGridView1.RowCount);
           
            //cboChuyenMon.DataSource = _nhanVienBll.GetTenChuyenMonById();
            //cboChuyenMon.DisplayMember = "TenCM";
            //cboChuyenMon.ValueMember = "MaCM";
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row = dataGridView1.Rows[e.RowIndex];
            //txtMaNV.Text = row.Cells[1].Value.ToString();
            //cboChuyenMon.SelectedValue = row.Cells[2].Value.ToString();

            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            txtMaNV.Text = dataGridView1.Rows[CurrentIndex].Cells[1].Value.ToString();
            cboChuyenMon.SelectedValue = dataGridView1.Rows[CurrentIndex].Cells[2].Value.ToString();
            cboPhongBan.SelectedValue = dataGridView1.Rows[CurrentIndex].Cells[3].Value.ToString();
            cboChiNhanh.SelectedValue = dataGridView1.Rows[CurrentIndex].Cells[4].Value.ToString();
            cboTrinhDoHV.SelectedValue = dataGridView1.Rows[CurrentIndex].Cells[5].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[CurrentIndex].Cells[6].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[CurrentIndex].Cells[7].Value.ToString();
            txtQueQuan.Text = dataGridView1.Rows[CurrentIndex].Cells[8].Value.ToString();
            dtpNgaySinh.Text = dataGridView1.Rows[CurrentIndex].Cells[9].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[CurrentIndex].Cells[10].Value.ToString();
        }

     
    }
}
