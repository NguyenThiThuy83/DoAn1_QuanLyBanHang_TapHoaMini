using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Lớp DTO_TaiKhoan dùng để truyền dữ liệu giữa các lớp DAL, BLL và GUI
    public class DTO_TaiKhoan
    {
        // Khai báo các thuộc tính
        public int MaTK { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int PerID { get; set; }

        //Phương thức khởi tạo ko tham số
        public DTO_TaiKhoan() { }

        //Phương thức khởi tạo có tham số
        public DTO_TaiKhoan(int matk, string taikhoan, string matkhau, int perid)
        {
            this.MaTK = matk;
            this.TaiKhoan = taikhoan;
            this.MatKhau = MatKhau;
            this.PerID = perid;
        }
    }
}
