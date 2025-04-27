using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_KhachHang dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Gmail { get; set; }

        // Phương thức khởi tạo không tham số
        public DTO_KhachHang() { }

        // Phương thức khởi tạo có tham số
        public DTO_KhachHang(string makh, string tenkh, string sodienthoai, string diachi, string gmail)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.SoDienThoai = sodienthoai;
            this.DiaChi = diachi;
            this.Gmail = gmail;
        }
    }

}
