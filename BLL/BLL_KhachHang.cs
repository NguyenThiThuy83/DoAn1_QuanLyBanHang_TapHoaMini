using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_KhachHang
    {
        private DAL_KhachHang dalKhachHang;

        public BLL_KhachHang()
        {
            this.dalKhachHang = new DAL_KhachHang();
        }

        public BLL_KhachHang(DAL_KhachHang dalKhachHang)
        {
            this.dalKhachHang = dalKhachHang;
        }

        // Lấy tất cả khách hàng
        public DataTable GetAllKhachHang()
        {
            return dalKhachHang.GetAllKhachHang();
        }

        // Thêm khách hàng
        public bool ThemKhachHang(DTO_KhachHang khachHang)
        {
            return dalKhachHang.ThemKhachHang(khachHang);
        }

        // Sửa khách hàng
        public bool SuaKhachHang(DTO_KhachHang khachHang)
        {
            return dalKhachHang.SuaKhachHang(khachHang);
        }

        // Xóa khách hàng
        public bool XoaKhachHang(string maKH)
        {
            return dalKhachHang.XoaKhachHang(maKH);
        }

        // Tìm kiếm khách hàng
        public DataTable TimKiemKhachHang(string maKH, string tenKH)
        {
            return dalKhachHang.TimKiemKhachHang(maKH, tenKH);
        }
    }
}
