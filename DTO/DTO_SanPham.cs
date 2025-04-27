using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_SanPham dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaLH { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }

        //Phương thức khởi tạo ko tham số
        public DTO_SanPham() { }

        //Phương thức khởi tạo có tham số
        public DTO_SanPham(string masp, string tensp, string malh, decimal dongianhap, decimal dongiaban, int soluong, string mota, string hinhanh)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.MaLH = malh;
            this.DonGiaNhap = dongianhap;
            this.DonGiaBan = dongiaban;
            this.SoLuong = soluong;
            this.MoTa = mota;
            this.HinhAnh = hinhanh;
        }
    }

}
