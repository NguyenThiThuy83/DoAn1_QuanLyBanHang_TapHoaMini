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
    public class BLL_SanPham
    {
        private DAL_SanPham dalSanPham;
        public BLL_SanPham()
        {
            this.dalSanPham = new DAL_SanPham();
        }
        public BLL_SanPham(DAL_SanPham dalSanPham)
        {
            this.dalSanPham = dalSanPham;
        }

        // Lấy danh sách tất cả sản phẩm
        public DataTable GetAllSanPham()
        {
            return dalSanPham.GetAllSanPham();
        }

        // Thêm sản phẩm
        public bool ThemSanPham(DTO_SanPham sp)
        {
            return dalSanPham.ThemSanPham(sp);
        }

        // Sửa sản phẩm
        public bool SuaSanPham(DTO_SanPham sp)
        {
            return dalSanPham.SuaSanPham(sp);
        }

        // Xóa sản phẩm
        public bool XoaSanPham(string maSP)
        {
            return dalSanPham.XoaSanPham(maSP);
        }

        // Tìm kiếm sản phẩm theo mã hoặc tên
        public DataTable TimKiemSanPham(string maSP, string tenSP)
        {
            return dalSanPham.TimKiemSanPham(maSP, tenSP);
        }
    }
}
