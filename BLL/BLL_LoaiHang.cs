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
    public class BLL_LoaiHang
    {
        private DAL_LoaiHang dalLoaiHang;

        public BLL_LoaiHang()
        {
            this.dalLoaiHang = new DAL_LoaiHang();
        }

        public BLL_LoaiHang(DAL_LoaiHang dalLoaiHang)
        {
            this.dalLoaiHang = dalLoaiHang;
        }

        // Lấy tất cả loại hàng
        public DataTable GetAllLoaiHang()
        {
            return dalLoaiHang.GetAllLoaiHang();
        }

        // Thêm loại hàng
        public bool ThemLoaiHang(DTO_LoaiHang loaiHang)
        {
            return dalLoaiHang.ThemLoaiHang(loaiHang);
        }

        // Sửa loại hàng
        public bool SuaLoaiHang(DTO_LoaiHang loaiHang)
        {
            return dalLoaiHang.SuaLoaiHang(loaiHang);
        }

        // Xóa loại hàng
        public bool XoaLoaiHang(string maLH)
        {
            return dalLoaiHang.XoaLoaiHang(maLH);
        }

        // Tìm kiếm loại hàng
        public DataTable TimKiemLoaiHang(string maLH, string tenLH)
        {
            return dalLoaiHang.TimKiemLoaiHang(maLH, tenLH);
        }
    }
}
