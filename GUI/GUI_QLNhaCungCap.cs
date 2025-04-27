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
    public partial class GUI_QLNhaCungCap : Form
    {
        BLL_NhaCungCap bllNhaCungCap = new BLL_NhaCungCap();

        public GUI_QLNhaCungCap()
        {
            InitializeComponent();
        }

        // Load dữ liệu lên DataGridView
        void LoadDgv()
        {
            dgvNhaCungCap.DataSource = bllNhaCungCap.GetAllNhaCungCap();
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhaCungCap.Columns[2].HeaderText = "Địa chỉ";
            dgvNhaCungCap.Columns[3].HeaderText = "Số điện thoại";
        }

        private void GUI_QLNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        void ChanSua()
        {
            txtMaNCC.Enabled = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtMaNCC.Text = dgvNhaCungCap.Rows[row].Cells[0].Value.ToString();
                    txtTenNCC.Text = dgvNhaCungCap.Rows[row].Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvNhaCungCap.Rows[row].Cells[2].Value.ToString();
                    txtSoDienThoai.Text = dgvNhaCungCap.Rows[row].Cells[3].Value.ToString();
                    ChanSua();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtMaNCCTimKiem.Text = "";
            txtTenNCCTimKiem.Text = "";
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            txtMaNCC.Focus();
            LoadDgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txtMaNCC.Text.Trim();
                string tenNCC = txtTenNCC.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string soDienThoai = txtSoDienThoai.Text.Trim();

                if (string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(tenNCC) ||
                    string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_NhaCungCap ncc = new DTO_NhaCungCap(maNCC, tenNCC, diaChi, soDienThoai);

                if (bllNhaCungCap.ThemNhaCungCap(ncc))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    LoadDgv();
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại");
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
            string maNCC = txtMaNCC.Text.Trim();
            string tenNCC = txtTenNCC.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            DTO_NhaCungCap ncc = new DTO_NhaCungCap(maNCC, tenNCC, diaChi, soDienThoai);

            if (bllNhaCungCap.SuaNhaCungCap(ncc))
            {
                MessageBox.Show("Sửa nhà cung cấp thành công");
                LoadDgv();
            }
            else
            {
                MessageBox.Show("Sửa nhà cung cấp không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (bllNhaCungCap.XoaNhaCungCap(maNCC))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDgv();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCCTimKiem.Text.Trim();
            string tenNCC = txtTenNCCTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maNCC) && string.IsNullOrEmpty(tenNCC))
            {
                MessageBox.Show("Vui lòng nhập Mã hoặc Tên nhà cung cấp để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllNhaCungCap.TimKiemNhaCungCap(maNCC, tenNCC);
            dgvNhaCungCap.DataSource = dt;
        }
    }
}
