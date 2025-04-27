using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_ChiTietDonHangBan dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_ChiTietDonHangBan
    {
        public string MaDHB { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        // Phương thức khởi tạo không tham số
        public DTO_ChiTietDonHangBan() { }

        // Phương thức khởi tạo có tham số
        public DTO_ChiTietDonHangBan(string madhb, string masp, int soluong, decimal dongia, decimal thanhtien)
        {
            this.MaDHB = madhb;
            this.MaSP = masp;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
    }

}
