using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_QLKhachHang : Form
    {
        BLL_KhachHang bllKhachHang = new BLL_KhachHang();
        public GUI_QLKhachHang()
        {
            InitializeComponent();
        }

        // Load dữ liệu lên DataGridView
        void LoadDgv()
        {
            dgvKhachHang.DataSource = bllKhachHang.GetAllKhachHang();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[4].HeaderText = "Gmail";
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        void ChanSua()
        {
            txtMaKH.Enabled = false;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaKH.Text = dgvKhachHang.Rows[hang].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[hang].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dgvKhachHang.Rows[hang].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[hang].Cells[3].Value.ToString();
                txtGmail.Text = dgvKhachHang.Rows[hang].Cells[4].Value.ToString();
                ChanSua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtMaKHTimKiem.Text = "";
            txtTenKHTimKiem.Text = "";
            foreach (System.Windows.Forms.Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            txtMaKH.Focus();
            LoadDgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtSoDienThoai.Text.Trim();
                string gmail = txtGmail.Text.Trim();

                if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(gmail) && !IsValidEmail(gmail))
                {
                    MessageBox.Show("Gmail không đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGmail.Focus();
                    return;
                }

                DTO_KhachHang khachHang = new DTO_KhachHang(maKH, tenKH, diaChi, sdt, gmail);

                if (bllKhachHang.ThemKhachHang(khachHang))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    LoadDgv();
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
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
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string gmail = txtGmail.Text.Trim();

            if (!string.IsNullOrEmpty(gmail) && !IsValidEmail(gmail))
            {
                MessageBox.Show("Gmail không đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGmail.Focus();
                return;
            }

            DTO_KhachHang khachHang = new DTO_KhachHang(maKH, tenKH, diaChi, sdt, gmail);

            if (bllKhachHang.SuaKhachHang(khachHang))
            {
                MessageBox.Show("Sửa khách hàng thành công");
                LoadDgv();
            }
            else
            {
                MessageBox.Show("Sửa khách hàng không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (bllKhachHang.XoaKhachHang(maKH))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDgv();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKHTimKiem.Text.Trim();
            string tenKH = txtTenKHTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(maKH) && string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập Mã khách hàng hoặc Tên khách hàng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllKhachHang.TimKiemKhachHang(maKH, tenKH);
            dgvKhachHang.DataSource = dt;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn nhập ký tự không phải số
                this.errorProvider1.SetError(txtSoDienThoai, "Số điện thoại chỉ được nhập số");
            }
            else this.errorProvider1.Clear();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGmail.Text) && !IsValidEmail(txtGmail.Text))
                errorProvider1.SetError(txtGmail, "Gmail không đúng định dạng");
            else
                errorProvider1.Clear();
        }
    }
}
