using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_QLLoaiHang : Form
    {
        BLL_LoaiHang bllLoaiHang = new BLL_LoaiHang();
        public GUI_QLLoaiHang()
        {
            InitializeComponent();
        }

        // Load dữ liệu lên DataGridView
        void LoadDgv()
        {
            dgvLoaiHang.DataSource = bllLoaiHang.GetAllLoaiHang();
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiHang.Columns[0].HeaderText = "Mã loại hàng";
            dgvLoaiHang.Columns[1].HeaderText = "Tên loại hàng";
            dgvLoaiHang.Columns[2].HeaderText = "Mô tả";
        }

        private void GUI_QLLoaiHang_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        void ChanSua()
        {
            txtMaLH.Enabled = false;
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaLH.Text = dgvLoaiHang.Rows[hang].Cells[0].Value.ToString();
                txtTenLH.Text = dgvLoaiHang.Rows[hang].Cells[1].Value.ToString();
                txtMoTa.Text = dgvLoaiHang.Rows[hang].Cells[2].Value.ToString();
                ChanSua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaLH.Enabled = true;
            txtMaLHTimKiem.Text = "";
            txtTenLHTimKiem.Text = "";
            foreach (System.Windows.Forms.Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            txtMaLH.Focus();
            LoadDgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLH = txtMaLH.Text.Trim();
                string tenLH = txtTenLH.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                // Kiểm tra nếu bất kỳ ô nào trống
                if (string.IsNullOrEmpty(maLH) || string.IsNullOrEmpty(tenLH) || string.IsNullOrEmpty(moTa))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_LoaiHang loaiHang = new DTO_LoaiHang(maLH, tenLH, moTa);

                if (bllLoaiHang.ThemLoaiHang(loaiHang))
                {
                    MessageBox.Show("Thêm loại hàng thành công");
                    LoadDgv();
                }
                else
                {
                    MessageBox.Show("Mã loại hàng đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChanSua();
            string maLH = txtMaLH.Text.Trim();
            string tenLH = txtTenLH.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            DTO_LoaiHang loaiHang = new DTO_LoaiHang(maLH, tenLH, moTa);

            if (bllLoaiHang.SuaLoaiHang(loaiHang))
            {
                MessageBox.Show("Sửa loại hàng thành công");
                LoadDgv();
            }
            else
            {
                MessageBox.Show("Sửa loại hàng không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLH = txtMaLH.Text.Trim();
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (bllLoaiHang.XoaLoaiHang(maLH) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDgv();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maLH = txtMaLHTimKiem.Text.Trim();
            string tenLH = txtTenLHTimKiem.Text.Trim();
            // Kiểm tra nếu cả hai ô tìm kiếm đều trống
            if (string.IsNullOrEmpty(maLH) && string.IsNullOrEmpty(tenLH))
            {
                MessageBox.Show("Vui lòng nhập Mã loại hàng hoặc Tên loại hàng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllLoaiHang.TimKiemLoaiHang(maLH, tenLH);
            dgvLoaiHang.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
