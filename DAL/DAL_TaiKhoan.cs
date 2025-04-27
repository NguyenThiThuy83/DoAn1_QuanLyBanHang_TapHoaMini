using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnect
    {
        public int CheckDangNhap(string username, string password)
        {
            _con.Open();
            //Tạo một đối tượng SqlCommand để thực thi các truy vấn đến cơ sở dữ liệu
            SqlCommand cmd = new SqlCommand();
            //Xác định loại của câu lệnh truy vấn là một Stored Procedure 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CheckDangNhap";
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Connection = _con;
            //Thực thi câu lệnh truy vấn và trả về kết quả duy nhất từ câu lệnh truy vấn đó
            object kq = cmd.ExecuteScalar();
            int code = Convert.ToInt32(kq);
            _con.Close();
            return code;
        }

        public void UpdateMatKhau(string taikhoan, string matKhauMoi)
        {
            _con.Open();
            string query = "UPDATE TBL_TaiKhoan SET MatKhau = @MatKhau WHERE TaiKhoan = @taikhoan";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@MatKhau", matKhauMoi);
            cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public int ChangePassword(string username, string oldPassword, string newPassword)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ChangePassword";
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@OldPassword", oldPassword);
            cmd.Parameters.AddWithValue("@NewPassword", newPassword);
            cmd.Connection = _con;
            int result = cmd.ExecuteNonQuery();
            _con.Close();
            return result;
        }
    }
}