using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class GUI_DoiMatKhau : Form
    {
        BLL_TaiKhoan bllTaiKhoan = new BLL_TaiKhoan();
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void GUI_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text;
            string MKCu = txtMatKhauCu.Text;
            string MKMoi = txtMatKhauMoi.Text;
            string NhapLaiMK = txtNhapLaiMatKhau.Text;

            if (string.IsNullOrEmpty(TaiKhoan) || string.IsNullOrEmpty(MKCu) || string.IsNullOrEmpty(MKMoi) || string.IsNullOrEmpty(NhapLaiMK))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (MKMoi != NhapLaiMK)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.");
                return;
            }

            int result = bllTaiKhoan.ChangePassword(TaiKhoan, MKCu, MKMoi);
            if (result == 1)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công.");

            }
            else if (result == -1)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không chính xác.");
            }
            else
            {
                MessageBox.Show("Lỗi trong quá trình thay đổi mật khẩu.");
            }
        }

        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHien.Checked)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
