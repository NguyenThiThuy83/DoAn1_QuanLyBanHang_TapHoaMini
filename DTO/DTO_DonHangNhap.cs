using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_DonHangNhap dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_DonHangNhap
    {
        public string MaDHN { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }

        // Phương thức khởi tạo không tham số
        public DTO_DonHangNhap() { }

        // Phương thức khởi tạo có tham số
        public DTO_DonHangNhap(string madhn, string mancc, DateTime ngaynhap, decimal tongtien)
        {
            this.MaDHN = madhn;
            this.MaNCC = mancc;
            this.NgayNhap = ngaynhap;
            this.TongTien = tongtien;
        }
    }

}
