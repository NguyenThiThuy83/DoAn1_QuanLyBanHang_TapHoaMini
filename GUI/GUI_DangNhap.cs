using BLL;
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
    public partial class GUI_DangNhap : Form
    {
        BLL_TaiKhoan bllTaiKhoan = new BLL_TaiKhoan();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            int code = bllTaiKhoan.CheckDangNhap(username, password);

            if (code == 0)
            {
                MessageBox.Show("Chào mừng Nhân viên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.code = 0;
                MDI_TrangChu a = new MDI_TrangChu();
                a.Show();
                this.Hide();

            }
            else if (code == 1)
            {
                MessageBox.Show("Chào mừng Quản lý đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.code = 1;
                MDI_TrangChu a = new MDI_TrangChu();
                a.Show();
                this.Hide();

            }
            else if (code == 2)
            {
                MessageBox.Show("Mật khẩu sai !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Text = "";
                txtTaiKhoan.Text = "";
                txtTaiKhoan.Focus();
            }
        }

        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHien.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
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

        private void txtTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui lòng nhập tài khoản");
                txtTaiKhoan.Focus();
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan, "");
            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }
        }
    }
}
