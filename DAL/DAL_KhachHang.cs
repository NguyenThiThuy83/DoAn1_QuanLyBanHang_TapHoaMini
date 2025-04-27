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
    public class DAL_KhachHang : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // Lấy danh sách tất cả khách hàng
        public DataTable GetAllKhachHang()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM KhachHang", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        // Hàm thực thi câu lệnh SQL chung
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        // Kiểm tra mã khách hàng trùng
        public int KiemTraMaTrung(string maKH)
        {
            _con.Open();
            string sql = $"SELECT COUNT(*) FROM KhachHang WHERE MaKH = '{maKH.Trim()}'";
            cmd = new SqlCommand(sql, _con);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count;
        }

        // Thêm khách hàng
        public bool ThemKhachHang(DTO_KhachHang khachHang)
        {
            if (KiemTraMaTrung(khachHang.MaKH) > 0)
            {
                return false; // Mã khách hàng đã tồn tại
            }
            else
            {
                string sql = $"INSERT INTO KhachHang (MaKH, TenKH, SoDienThoai, DiaChi, Gmail) " +
                             $"VALUES ('{khachHang.MaKH}', N'{khachHang.TenKH}', '{khachHang.SoDienThoai}', N'{khachHang.DiaChi}', '{khachHang.Gmail}')";
                thucthisql(sql);
                return true;
            }
        }

        // Sửa khách hàng
        public bool SuaKhachHang(DTO_KhachHang khachHang)
        {
            string sql = $"UPDATE KhachHang SET " +
                         $"TenKH = N'{khachHang.TenKH}', " +
                         $"SoDienThoai = '{khachHang.SoDienThoai}', " +
                         $"DiaChi = N'{khachHang.DiaChi}', " +
                         $"Gmail = '{khachHang.Gmail}' " +
                         $"WHERE MaKH = '{khachHang.MaKH}'";

            thucthisql(sql);
            return true;
        }

        // Xóa khách hàng
        public bool XoaKhachHang(string maKH)
        {
            string sql = $"DELETE FROM KhachHang WHERE MaKH = '{maKH}'";
            thucthisql(sql);
            return true;
        }

        // Tìm kiếm khách hàng theo mã hoặc tên
        public DataTable TimKiemKhachHang(string maKH, string tenKH)
        {
            _con.Open();
            string sql = $"SELECT * FROM KhachHang WHERE MaKH LIKE '%{maKH}%' AND TenKH LIKE N'%{tenKH}%'";
            da = new SqlDataAdapter(sql, _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}