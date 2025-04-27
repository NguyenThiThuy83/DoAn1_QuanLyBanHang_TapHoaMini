using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_DonHangBan dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_DonHangBan
    {
        public string MaDHB { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal TongTien { get; set; }

        // Phương thức khởi tạo không tham số
        public DTO_DonHangBan() { }

        // Phương thức khởi tạo có tham số
        public DTO_DonHangBan(string madhb, string makh, DateTime ngayban, decimal tongtien)
        {
            this.MaDHB = madhb;
            this.MaKH = makh;
            this.NgayBan = ngayban;
            this.TongTien = tongtien;
        }
    }

}
