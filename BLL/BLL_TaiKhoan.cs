using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        private DAL_TaiKhoan daltaikhoan;
        public BLL_TaiKhoan()
        {
            this.daltaikhoan = new DAL_TaiKhoan();
        }
        public BLL_TaiKhoan(DAL_TaiKhoan daltaikhoan)
        {
            this.daltaikhoan = daltaikhoan;
        }

        public int CheckDangNhap(string username, string password)
        {
            return daltaikhoan.CheckDangNhap(username, password);
        }

        public void UpdateMatKhau(string taikhoan, string matKhauMoi)
        {
            daltaikhoan.UpdateMatKhau(taikhoan, matKhauMoi);
        }

        public int ChangePassword(string username, string oldPassword, string newPassword)
        {
            // Kiểm tra đăng nhập trước khi thay đổi mật khẩu (nếu cần)
            int loginResult = daltaikhoan.CheckDangNhap(username, oldPassword);
            if (loginResult == 1 || loginResult == 0)
            {
                return daltaikhoan.ChangePassword(username, oldPassword, newPassword);
            }
            else
            {
                return -1; // Mã lỗi cho biết đăng nhập không thành công
            }
        }
    }
}
