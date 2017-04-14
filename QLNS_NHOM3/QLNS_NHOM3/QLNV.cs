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
using Dao;

namespace QLNS_NHOM3
{
    public partial class frmQLNV : Form
    {
         NhanVienBll _nhanVienBll = new NhanVienBll();
        NhanVienDao _nhanVienDao = new NhanVienDao();
        private BindingSource _source;
        public frmQLNV()
        {
            InitializeComponent();
            

        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
             _source = new BindingSource();
            // TODO: This line of code loads data into the 'qLNSDataSet_TDHV.TDHV' table. You can move, or remove it, as needed.
            this.tDHVTableAdapter.Fill(this.qLNSDataSet_TDHV.TDHV);
            // TODO: This line of code loads data into the 'qLNSDataSet_ChiNhanh.CHINHANH' table. You can move, or remove it, as needed.
            this.cHINHANHTableAdapter.Fill(this.qLNSDataSet_ChiNhanh.CHINHANH);
            // TODO: This line of code loads data into the 'qLNSDataSet_PhongBan.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.qLNSDataSet_PhongBan.PHONGBAN);
            // TODO: This line of code loads data into the 'qLNSDataSet_ChuyenMon.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.qLNSDataSet_ChuyenMon.CHUYENMON);
            _source.DataSource = _nhanVienBll.GetAllNhanVien();
            dataGridView1.DataSource = _source;
            CellClick();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            lblRowCount.Text =  string.Format("{0} bản ghi.", dataGridView1.RowCount);
           
            //cboChuyenMon.DataSource = _nhanVienBll.GetTenChuyenMonById();
            //cboChuyenMon.DisplayMember = "TenCM";
            //cboChuyenMon.ValueMember = "MaCM";
            
           //txtHoTen.DataBindings.Clear();
           // txtHoTen.DataBindings.Add("text", _source, "HoTen");

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //DataGridViewRow row = new DataGridViewRow();
        //    //row = dataGridView1.Rows[e.RowIndex];
        //    //txtMaNV.Text = row.Cells[1].Value.ToString();
        //    //cboChuyenMon.SelectedValue = row.Cells[2].Value.ToString();

           
        //}


         public void CellClick()
        {
            var currentIndex = dataGridView1.CurrentCell.RowIndex;
             string gt = "";
             txtMaNV.Text = dataGridView1.Rows[currentIndex].Cells[1].Value.ToString();
            cboChuyenMon.SelectedValue = dataGridView1.Rows[currentIndex].Cells[2].Value.ToString();
            cboPhongBan.SelectedValue = dataGridView1.Rows[currentIndex].Cells[3].Value.ToString();
            cboChiNhanh.SelectedValue = dataGridView1.Rows[currentIndex].Cells[4].Value.ToString();
            cboTrinhDoHV.SelectedValue = dataGridView1.Rows[currentIndex].Cells[5].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[currentIndex].Cells[6].Value.ToString();
            //txtGioiTinh.Text = dataGridView1.Rows[currentIndex].Cells[7].Value.ToString();
             gt = dataGridView1.Rows[currentIndex].Cells[7].Value.ToString();
             if (gt.Trim() == "Nam")
             {
                 //MessageBox.Show(gt);
                 radNam.Checked = true;
             }
             else if (gt.Trim() == "Nữ")
             {
                 //MessageBox.Show(gt);
                 radNu.Checked = true;
             }
             else
             {
                 MessageBox.Show(gt);
             }
           
            txtQueQuan.Text = dataGridView1.Rows[currentIndex].Cells[8].Value.ToString();
            dtpNgaySinh.Text = dataGridView1.Rows[currentIndex].Cells[9].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[currentIndex].Cells[10].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            _source.MoveFirst();
            
            CellClick();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _source.MoveLast();
            
            CellClick();
        }

        
        

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _source.MovePrevious();
            CellClick();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _source.MoveNext();
            CellClick();
        }

        public void ClearTextBox()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            radNam.Checked = true;
            txtQueQuan.Clear();
            txtSDT.Clear();
        }

        private bool check;
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
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
                    _nhanVienDao.MaNv = txtMaNV.Text;
                    _nhanVienDao.MaCm = cboChuyenMon.SelectedValue.ToString();
                    _nhanVienDao.MaPb = cboPhongBan.SelectedValue.ToString();
                    _nhanVienDao.MaCn = cboChiNhanh.SelectedValue.ToString();
                    _nhanVienDao.MaTdhv = cboTrinhDoHV.SelectedValue.ToString();
                    _nhanVienDao.HoTen = txtHoTen.Text;
                    if (radNam.Checked)
                    {
                        _nhanVienDao.GioiTinh = "Nam";
                    }
                    else if (radNu.Checked)
                    {
                        _nhanVienDao.GioiTinh = "Nữ";
                    }

                    _nhanVienDao.QueQuan = txtQueQuan.Text;
                    _nhanVienDao.NgaySinh = dtpNgaySinh.Value;
                    _nhanVienDao.Sdt = txtSDT.Text;
                    _nhanVienBll.ThemNv(_nhanVienDao);
                    MessageBox.Show(@"Thêm thành công!");
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
                    if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtSDT.Text) )
                    {
                        MessageBox.Show(@"Không được để trống!");
                    }
                    else
                    {
                        _nhanVienDao.MaNv = txtMaNV.Text;
                        _nhanVienDao.MaCm = cboChuyenMon.SelectedValue.ToString();
                        _nhanVienDao.MaPb = cboPhongBan.SelectedValue.ToString();
                        _nhanVienDao.MaCn = cboChiNhanh.SelectedValue.ToString();
                        _nhanVienDao.MaTdhv = cboTrinhDoHV.SelectedValue.ToString();
                        _nhanVienDao.HoTen = txtHoTen.Text;
                        if (radNam.Checked)
                        {
                            _nhanVienDao.GioiTinh = "Nam";
                        }
                        else if (radNu.Checked)
                        {
                            _nhanVienDao.GioiTinh = "Nữ";
                        }

                        _nhanVienDao.QueQuan = txtQueQuan.Text;
                        _nhanVienDao.NgaySinh = dtpNgaySinh.Value;
                        _nhanVienDao.Sdt = txtSDT.Text;
                        _nhanVienBll.SuaNv(_nhanVienDao);
                        MessageBox.Show(@"Sửa thành công!");
                    }
                    
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Sửa thất bại!");
                }


            }
            frmQLNV_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Are you sue ?", @"Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string maNv = txtMaNV.Text;
                _nhanVienBll.XoaNv(maNv);
            }
            
            frmQLNV_Load(sender, e);
        }

       
    }
}
