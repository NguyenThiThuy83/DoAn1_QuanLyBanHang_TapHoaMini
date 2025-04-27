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
    public partial class GUI_QLSanPham : Form
    {
        string currentImagePath = "";
        BLL_SanPham bllSanPham = new BLL_SanPham();
        BLL_LoaiHang bllLoaiHang = new BLL_LoaiHang();
        public GUI_QLSanPham()
        {
            InitializeComponent();
        }

        // Load dữ liệu lên DataGridView
        void LoadDgv()
        {
            dgvSanPham.DataSource = bllSanPham.GetAllSanPham();
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.Columns[0].HeaderText = "Mã SP";
            dgvSanPham.Columns[1].HeaderText = "Tên SP";
            dgvSanPham.Columns[2].HeaderText = "Loại Hàng";
            dgvSanPham.Columns[3].HeaderText = "Đơn giá nhập";
            dgvSanPham.Columns[4].HeaderText = "Đơn giá bán";
            dgvSanPham.Columns[5].HeaderText = "Số lượng";
            dgvSanPham.Columns[6].HeaderText = "Mô tả";
            dgvSanPham.Columns[7].HeaderText = "Hình ảnh";
            dgvSanPham.Columns[8].Visible = false; // Ẩn cột mã loại hàng
        }

        private void GUI_QLSanPham_Load(object sender, EventArgs e)
        {
            picAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadLoaiHangToComboBox();
            LoadDgv();
        }

        void LoadLoaiHangToComboBox()
        {
            DataTable dtLoaiHang = bllLoaiHang.GetAllLoaiHang();
            cboLoaiHang.DataSource = dtLoaiHang;
            cboLoaiHang.DisplayMember = "TenLH";   // Hiển thị tên loại hàng
            cboLoaiHang.ValueMember = "MaLH";      // Lấy mã loại hàng
        }

        void ChanSua()
        {
            txtMaSP.Enabled = false;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAnhSP.Image = Image.FromFile(openFile.FileName);
                picAnhSP.Tag = openFile.FileName;  // Lưu tạm đường dẫn hình để lưu vào DB
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            txtMaSPTimKiem.Text = "";
            txtTenSPTimKiem.Text = "";
            errorProvider1.Clear();
            foreach (System.Windows.Forms.Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            picAnhSP.Image = null; // Xóa hình ảnh
            picAnhSP.Tag = null;  // Xóa đường dẫn hình ảnh
            cboLoaiHang.SelectedIndex = -1; // Đặt lại giá trị mặc định cho ComboBox
            txtMaSP.Focus();
            LoadDgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSP.Text.Trim()) || string.IsNullOrEmpty(txtTenSP.Text.Trim()) || cboLoaiHang.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Mã SP, Tên SP, Loại hàng).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string maLH = cboLoaiHang.SelectedValue.ToString();
                decimal? donGiaNhap = string.IsNullOrWhiteSpace(txtDonGiaNhap.Text) ? (decimal?)null : decimal.Parse(txtDonGiaNhap.Text);
                decimal? donGiaBan = string.IsNullOrWhiteSpace(txtDonGiaBan.Text) ? (decimal?)null : decimal.Parse(txtDonGiaBan.Text);
                int? soLuong = string.IsNullOrWhiteSpace(txtSoLuong.Text) ? (int?)null : int.Parse(txtSoLuong.Text);
                string moTa = txtMoTa.Text.Trim();
                string hinhAnh = picAnhSP.Tag != null ? picAnhSP.Tag.ToString() : "";

                DTO_SanPham sp = new DTO_SanPham(maSP, tenSP, maLH, donGiaNhap ?? 0, donGiaBan ?? 0, soLuong ?? 0, moTa, hinhAnh);

                if (bllSanPham.ThemSanPham(sp))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    LoadDgv();
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSP.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string maLH = cboLoaiHang.SelectedValue.ToString();
                decimal? donGiaNhap = string.IsNullOrWhiteSpace(txtDonGiaNhap.Text) ? (decimal?)null : decimal.Parse(txtDonGiaNhap.Text);
                decimal? donGiaBan = string.IsNullOrWhiteSpace(txtDonGiaBan.Text) ? (decimal?)null : decimal.Parse(txtDonGiaBan.Text);
                int? soLuong = string.IsNullOrWhiteSpace(txtSoLuong.Text) ? (int?)null : int.Parse(txtSoLuong.Text);
                string moTa = txtMoTa.Text.Trim();
                string hinhAnh = (picAnhSP.Tag != null && !string.IsNullOrEmpty(picAnhSP.Tag.ToString()))
                 ? picAnhSP.Tag.ToString()
                 : currentImagePath;

                DTO_SanPham sp = new DTO_SanPham(maSP, tenSP, maLH, donGiaNhap ?? 0, donGiaBan ?? 0, soLuong ?? 0, moTa, hinhAnh);

                if (bllSanPham.SuaSanPham(sp))
                {
                    MessageBox.Show("Sửa sản phẩm thành công");
                    LoadDgv();
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sản phẩm: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSP.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maSP = txtMaSP.Text.Trim();

                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (bllSanPham.XoaSanPham(maSP))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công");
                        LoadDgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message);
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
            string maSP = txtMaSPTimKiem.Text.Trim();
            string tenSP = txtTenSPTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(maSP) && string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng nhập Mã sản phẩm hoặc Tên sản phẩm để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllSanPham.TimKiemSanPham(maSP, tenSP);
            dgvSanPham.DataSource = dt;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                if (hang >= 0)
                {
                    txtMaSP.Text = dgvSanPham.Rows[hang].Cells[0].Value.ToString();
                    txtTenSP.Text = dgvSanPham.Rows[hang].Cells[1].Value.ToString();
                    cboLoaiHang.SelectedValue = dgvSanPham.Rows[hang].Cells[8].Value.ToString();
                    txtDonGiaNhap.Text = dgvSanPham.Rows[hang].Cells[3].Value.ToString();
                    txtDonGiaBan.Text = dgvSanPham.Rows[hang].Cells[4].Value.ToString();
                    txtSoLuong.Text = dgvSanPham.Rows[hang].Cells[5].Value.ToString();
                    txtMoTa.Text = dgvSanPham.Rows[hang].Cells[6].Value.ToString();

                    // Lưu đường dẫn hình ảnh hiện tại
                    currentImagePath = dgvSanPham.Rows[hang].Cells[7].Value.ToString();

                    // Load hình ảnh
                    if (File.Exists(currentImagePath))
                    {
                        picAnhSP.Image = Image.FromFile(currentImagePath);
                        picAnhSP.Tag = currentImagePath; // Lưu đường dẫn hình ảnh vào Tag
                    }
                    else
                    {
                        picAnhSP.Image = null;
                        picAnhSP.Tag = null; // Xóa đường dẫn hình ảnh nếu không tồn tại
                    }

                    ChanSua();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn nhập ký tự không phải số
                this.errorProvider1.SetError(txtDonGiaNhap, "Đơn giá nhập chỉ được nhập số");
            }
            else this.errorProvider1.Clear();
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn nhập ký tự không phải số
                this.errorProvider1.SetError(txtDonGiaBan, "Đơn giá bán chỉ được nhập số");
            }
            else this.errorProvider1.Clear();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn nhập ký tự không phải số
                this.errorProvider1.SetError(txtSoLuong, "Số lượng chỉ được nhập số");
            }
            else this.errorProvider1.Clear();
        }
    }
}
