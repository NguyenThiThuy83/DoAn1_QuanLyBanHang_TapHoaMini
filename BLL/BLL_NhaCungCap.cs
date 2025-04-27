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
    public class BLL_NhaCungCap
    {
        private DAL_NhaCungCap dalNhaCungCap;
        public BLL_NhaCungCap()
        {
            this.dalNhaCungCap = new DAL_NhaCungCap();
        }
        public BLL_NhaCungCap(DAL_NhaCungCap dalNhaCungCap)
        {
            this.dalNhaCungCap = dalNhaCungCap;
        }

        // Lấy tất cả nhà cung cấp
        public DataTable GetAllNhaCungCap()
        {
            return dalNhaCungCap.GetAllNhaCungCap();
        }

        // Thêm nhà cung cấp
        public bool ThemNhaCungCap(DTO_NhaCungCap ncc)
        {
            return dalNhaCungCap.ThemNhaCungCap(ncc);
        }

        // Sửa nhà cung cấp
        public bool SuaNhaCungCap(DTO_NhaCungCap ncc)
        {
            return dalNhaCungCap.SuaNhaCungCap(ncc);
        }

        // Xóa nhà cung cấp
        public bool XoaNhaCungCap(string maNCC)
        {
            return dalNhaCungCap.XoaNhaCungCap(maNCC);
        }

        // Tìm kiếm nhà cung cấp
        public DataTable TimKiemNhaCungCap(string maNCC, string tenNCC)
        {
            return dalNhaCungCap.TimKiemNhaCungCap(maNCC, tenNCC);
        }
    }
}
