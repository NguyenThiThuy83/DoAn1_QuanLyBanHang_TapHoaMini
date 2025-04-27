using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_LoaiHang dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_LoaiHang
    {
        public string MaLH { get; set; }
        public string TenLH { get; set; }
        public string MoTa { get; set; }

        //Phương thức khởi tạo ko tham số
        public DTO_LoaiHang() { }

        //Phương thức khởi tạo có tham số
        public DTO_LoaiHang(string malh, string tenlh, string mota)
        {
            this.MaLH = malh;
            this.TenLH = tenlh;
            this.MoTa = mota;
        }
    }

}
