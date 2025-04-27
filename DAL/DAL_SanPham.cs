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
    public class DAL_SanPham : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // Lấy danh sách tất cả sản phẩm
        public DataTable GetAllSanPham()
        {
            _con.Open();
            string sql = @"
                SELECT sp.MaSP, sp.TenSP, lh.TenLH, sp.DonGiaNhap, sp.DonGiaBan, sp.SoLuong, sp.MoTa, sp.HinhAnh, lh.MaLH
                FROM SanPham sp
                JOIN LoaiHang lh ON sp.MaLH = lh.MaLH";
            da = new SqlDataAdapter(sql, _con);
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

        // Kiểm tra mã sản phẩm trùng
        public int KiemTraMaTrung(string maSP)
        {
            _con.Open();
            string sql = $"SELECT COUNT(*) FROM SanPham WHERE MaSP = '{maSP.Trim()}'";
            cmd = new SqlCommand(sql, _con);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count;
        }

        // Thêm sản phẩm
        public bool ThemSanPham(DTO_SanPham sp)
        {
            if (KiemTraMaTrung(sp.MaSP) > 0)
            {
                return false; // Mã sản phẩm đã tồn tại
            }
            else
            {
                string sql = $"INSERT INTO SanPham (MaSP, TenSP, MaLH, DonGiaNhap, DonGiaBan, SoLuong, MoTa, HinhAnh) " +
                             $"VALUES ('{sp.MaSP}', N'{sp.TenSP}', '{sp.MaLH}', {sp.DonGiaNhap}, {sp.DonGiaBan}, {sp.SoLuong}, N'{sp.MoTa}', N'{sp.HinhAnh}')";
                thucthisql(sql);
                return true;
            }
        }

        // Sửa sản phẩm
        public bool SuaSanPham(DTO_SanPham sp)
        {
            string sql = $"UPDATE SanPham SET " +
                         $"TenSP = N'{sp.TenSP}', " +
                         $"MaLH = '{sp.MaLH}', " +
                         $"DonGiaNhap = {sp.DonGiaNhap}, " +
                         $"DonGiaBan = {sp.DonGiaBan}, " +
                         $"SoLuong = {sp.SoLuong}, " +
                         $"MoTa = N'{sp.MoTa}', " +
                         $"HinhAnh = N'{sp.HinhAnh}' " +
                         $"WHERE MaSP = '{sp.MaSP}'";

            thucthisql(sql);
            return true;
        }

        // Xóa sản phẩm
        public bool XoaSanPham(string maSP)
        {
            string sql = $"DELETE FROM SanPham WHERE MaSP = '{maSP}'";
            thucthisql(sql);
            return true;
        }

        // Tìm kiếm sản phẩm theo mã hoặc tên
        public DataTable TimKiemSanPham(string maSP, string tenSP)
        {
            _con.Open();
            string sql = $"SELECT * FROM SanPham WHERE MaSP LIKE '%{maSP}%' AND TenSP LIKE N'%{tenSP}%'";
            da = new SqlDataAdapter(sql, _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}