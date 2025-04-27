using DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiHang : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // Phương thức lấy danh sách loại hàng
        public DataTable GetAllLoaiHang()
        {
            // Mở kết nối
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM LoaiHang", _con);
            dt = new DataTable();
            // Thực thi câu lệnh truy vấn và truyền dữ liệu vào DataTable
            da.Fill(dt);
            // Đóng kết nối
            _con.Close();
            return dt;
        }

        void thucthisql(string sql)
        {
            // Mở kết nối
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            // Thực thi câu lệnh truy vấn
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            _con.Close();
        }

        public int KiemTraMaTrung(string ma)
        {
            _con.Open();
            string sql = $"SELECT COUNT(*) FROM LoaiHang WHERE MaLH = '{ma.Trim()}'";
            cmd = new SqlCommand(sql, _con);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count;
        }

        // Phương thức thêm loại hàng
        public bool ThemLoaiHang(DTO_LoaiHang loaiHang)
        {
            if (KiemTraMaTrung(loaiHang.MaLH) > 0)
            {
                return false; // Mã loại hàng đã tồn tại
            }
            else
            {
                string sql = $"INSERT INTO LoaiHang (MaLH, TenLH, MoTa) VALUES ('{loaiHang.MaLH}', N'{loaiHang.TenLH}', N'{loaiHang.MoTa}')";
                thucthisql(sql);
                return true; // Thêm thành công
            }
        }

        // Phương thức sửa loại hàng
        public bool SuaLoaiHang(DTO_LoaiHang loaiHang)
        {
            string sql = $"UPDATE LoaiHang SET TenLH = N'{loaiHang.TenLH}', MoTa = N'{loaiHang.MoTa}' WHERE MaLH = '{loaiHang.MaLH}'";

            // Gọi hàm thực thi câu lệnh SQL
            thucthisql(sql);
            return true;
        }

        // Phương thức xóa loại hàng
        public bool XoaLoaiHang(string maLH)
        {
            string sql = $"DELETE FROM LoaiHang WHERE MaLH = '{maLH}'";
            // Gọi hàm thực thi câu lệnh SQL
            thucthisql(sql);
            return true;
        }

        public DataTable TimKiemLoaiHang(string maLH, string tenLH)
        {
            // Mở kết nối
            _con.Open();
            string sql = $"SELECT * FROM LoaiHang WHERE MaLH LIKE '%{maLH}%' AND TenLH LIKE N'%{tenLH}%'";
            da = new SqlDataAdapter(sql, _con);
            dt = new DataTable();
            // Thực thi câu lệnh truy vấn và truyền dữ liệu vào DataTable
            da.Fill(dt);
            // Đóng kết nối
            _con.Close();
            return dt;
        }
    }
}