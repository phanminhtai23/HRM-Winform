using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAPlayer;

namespace LOGICPlayer
{
    public class BackendDMLuong
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True";

        // Thêm lương cho nhân viên mới với các hệ số là null
        public bool ThemLuongMoi(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DM_Luong (MaNhanVien, LuongCoBan, PhuCap, KhauTruThue) VALUES (@MaNhanVien, NULL, NULL, NULL)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Sửa lương của nhân viên
        public bool SuaLuong(string maNhanVien, decimal? luongCoBan, decimal? phuCap, decimal? khauTruThue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DM_Luong SET LuongCoBan = @LuongCoBan, PhuCap = @PhuCap, KhauTruThue = @KhauTruThue WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@LuongCoBan", (object)luongCoBan ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhuCap", (object)phuCap ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@KhauTruThue", (object)khauTruThue ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Xóa lương của nhân viên
        public bool XoaLuong(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DM_Luong WHERE MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
