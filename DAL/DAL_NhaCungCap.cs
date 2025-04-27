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
    public class DAL_NhaCungCap : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // Phương thức lấy danh sách nhà cung cấp
        public DataTable GetAllNhaCungCap()
        {
            // Mở kết nối
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM NhaCungCap", _con);
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
            string sql = $"SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = '{ma.Trim()}'";
            cmd = new SqlCommand(sql, _con);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count;
        }

        // Phương thức thêm nhà cung cấp
        public bool ThemNhaCungCap(DTO_NhaCungCap ncc)
        {
            if (KiemTraMaTrung(ncc.MaNCC) > 0)
            {
                return false; // Mã nhà cung cấp đã tồn tại
            }
            else
            {
                string sql = $"INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES ('{ncc.MaNCC}', N'{ncc.TenNCC}', N'{ncc.DiaChi}', N'{ncc.SoDienThoai}')";
                thucthisql(sql);
                return true; // Thêm thành công
            }
        }

        // Phương thức sửa nhà cung cấp
        public bool SuaNhaCungCap(DTO_NhaCungCap ncc)
        {
            string sql = $"UPDATE NhaCungCap SET TenNCC = N'{ncc.TenNCC}', DiaChi = N'{ncc.DiaChi}', SoDienThoai = '{ncc.SoDienThoai}' WHERE MaNCC = '{ncc.MaNCC}'";

            // Gọi hàm thực thi câu lệnh SQL
            thucthisql(sql);
            return true;
        }

        // Phương thức xóa nhà cung cấp
        public bool XoaNhaCungCap(string maNCC)
        {
            string sql = $"DELETE FROM NhaCungCap WHERE MaNCC = '{maNCC}'";

            // Gọi hàm thực thi câu lệnh SQL
            thucthisql(sql);
            return true;
        }

        // Phương thức tìm kiếm nhà cung cấp
        public DataTable TimKiemNhaCungCap(string maNCC, string tenNCC)
        {
            // Mở kết nối
            _con.Open();
            string sql = $"SELECT * FROM NhaCungCap WHERE MaNCC LIKE '%{maNCC}%' AND TenNCC LIKE N'%{tenNCC}%'";
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