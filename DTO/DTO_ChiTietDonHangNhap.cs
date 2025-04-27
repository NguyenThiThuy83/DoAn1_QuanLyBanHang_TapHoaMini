using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_ChiTietDonHangNhap dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_ChiTietDonHangNhap
    {
        public string MaDHN { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        // Phương thức khởi tạo không tham số
        public DTO_ChiTietDonHangNhap() { }

        // Phương thức khởi tạo có tham số
        public DTO_ChiTietDonHangNhap(string madhn, string masp, int soluong, decimal dongia, decimal thanhtien)
        {
            this.MaDHN = madhn;
            this.MaSP = masp;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
    }

}
