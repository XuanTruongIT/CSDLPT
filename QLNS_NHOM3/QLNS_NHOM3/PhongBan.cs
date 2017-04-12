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
    public partial class frmPhongBan : Form
    {
        PhongBanBll _phongBanBll = new PhongBanBll();

        PhongBanDal _phongBanDal = new PhongBanDal();

        //DataView Griview;

        public frmPhongBan()
        {
            InitializeComponent();
            dataGridView1.DataSource = _phongBanBll.GetAllPhongBan();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
           // btnHuy.Enabled = false;
        //    btnTim.Enabled = false;
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            //    label5.Text = null;
            //    label6.Text = null;

            //    for (int i = 0; i < dataGridView1.RowCount; i++)
            //    {
            //        dataGridView1.Rows[i].Cells[0].Value = i + 1;
            //    }
            //    label4.Text = dataGridView1.RowCount + " bản ghi.";
            //}

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ActiveControl = txtMaPB;
            txtMaPB.Focus();
            btnLuu.Enabled = true;
            txtMaPB.Text = null;
            txtTen.Text = null;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            mserr.Text = "";
        }
        int check;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            try
            {
                PhongBanDao pbd = new PhongBanDao();
                pbd.MaPb = txtMaPB.Text;
                pbd.TenPb = txtTen.Text;

                _phongBanDal.themPhongBan(pbd);
                dataGridView1.DataSource = _phongBanBll.GetAllPhongBan();
            }
            catch (Exception ex)
            {
                if (ex.Message == "String or binary data would be truncated.\r\nThe statement has been terminated.")
                {
                    mserr.Text = "Độ dài không hợp lệ!, Nhập trong khoảng 10 ký tự";
                }
                //else
                //if (ex.Message == "Thêm thất bại! \r\nThe transaction ended in the trigger. The batch has been aborted.\r\nThêm thất bại!Mời nhập đúng định dạng KBPB ")
                //{
                //    label5.Text = "Nhập đúng định dạng PBKB!";
                //}
                //else 
                //     MessageBox.Show("Nhập đúng định dạng PBKB!");

            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaPB.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTim.Enabled = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPB.Clear();
            txtTen.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo);
            if (rs.Equals(DialogResult.Yes))
            {
                string MaPB = Convert.ToString(txtMaPB.Text);
                _phongBanDal.xoaPhongBan(MaPB);
                dataGridView1.DataSource = _phongBanBll.GetAllPhongBan();
            }
            txtMaPB.Clear();
            txtTen.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongBanDao pbd = new PhongBanDao();
            txtMaPB.ReadOnly = true;
            pbd.TenPb = txtTen.Text;
            _phongBanDal.suaPhongBan(pbd);
            dataGridView1.DataSource = _phongBanBll.GetAllPhongBan();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string manhanvien = dataGridView1.Rows[i].Cells["MaPB"].Value.ToString();
                    dataGridView1.Rows[i].Cells["TenPB"].Value = "";
              
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hoặc không tồn tại tên nhân viên vừa nhập");

            }
        }
    }
}
