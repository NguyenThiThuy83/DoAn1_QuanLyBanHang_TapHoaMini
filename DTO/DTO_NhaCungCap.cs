using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_NhaCungCap dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        // Phương thức khởi tạo không tham số
        public DTO_NhaCungCap() { }

        // Phương thức khởi tạo có tham số
        public DTO_NhaCungCap(string mancc, string tenncc, string diachi, string sodienthoai)
        {
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.DiaChi = diachi;
            this.SoDienThoai = sodienthoai;
        }
    }

}
