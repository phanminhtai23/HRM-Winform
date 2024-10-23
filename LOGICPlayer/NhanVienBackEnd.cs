using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class NhanVienBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        //public List<NhanVien> LoadDataTable() => Adapter.NhanViens.AsNoTracking().ToList();
        public List<object> LoadDataTable()
        {
            return Adapter.NhanVien
                .AsNoTracking()
                .Join(
                    Adapter.PhongBan,  // Bảng PhongBan
                    nv => nv.MaPhongBan,  // Khóa ngoại ở NhanVien
                    pb => pb.MaPhongBan,  // Khóa chính ở PhongBan
                    (nv, pb) => new { nv, pb })  // Kết hợp dữ liệu
                .Join(
                    Adapter.DM_ChucVu,  // Bảng ChucVu
                    nvpb => nvpb.nv.MaChucVu,  // Khóa ngoại ở NhanVien
                    cv => cv.MaChucVu,  // Khóa chính ở ChucVu
                    (nvpb, cv) => new // Kết hợp thêm dữ liệu của ChucVu
                    {
                        MaNhanVien = nvpb.nv.MaNhanVien,
                        TenNhanVien = nvpb.nv.TenNhanVien,
                        NgaySinh = nvpb.nv.NgaySinh,
                        DiaChi = nvpb.nv.DiaChi,
                        SoDienThoai = nvpb.nv.SoDienThoai,
                        TenPhongBan = nvpb.pb.TenPhongBan,  // Lấy tên phòng ban
                        TenChucVu = cv.TenChucVu  // Lấy tên chức vụ
                    })
                .ToList<object>();
        }

        public string TaoMaNhanVienMoi()
        {
            // Tự động tạo mã nhân viên mới
            string lastMaNhanVien = Adapter.NhanVien
                .Where(nv => nv.MaNhanVien.StartsWith("TKD"))
                .OrderByDescending(nv => nv.MaNhanVien)
                .Select(nv => nv.MaNhanVien)
                .FirstOrDefault();

            string maNhanVien;
            if (!string.IsNullOrEmpty(lastMaNhanVien))
            {
                string prefix = "TKD";
                string numberPart = lastMaNhanVien.Substring(prefix.Length);
                int nextNumber = int.Parse(numberPart) + 1;
                maNhanVien = $"{prefix}{nextNumber.ToString("D2")}";
            }
            else
            {
                maNhanVien = "TKD01";
            }

            return maNhanVien;
        }
        public string layMaPhongBanByTen(string tenPhongBan)
        {
            // Truy vấn mã phòng ban từ tên phòng ban
            var phongBan = Adapter.PhongBan
                .FirstOrDefault(pb => pb.TenPhongBan.Equals(tenPhongBan, StringComparison.OrdinalIgnoreCase));

            return phongBan?.MaPhongBan; // Trả về mã phòng ban hoặc null nếu không tìm thấy
        }

        public string layMaChucVuByTen(string tenChucVu)
        {
            // Truy vấn mã chức vụ từ tên chức vụ
            var chucVu = Adapter.DM_ChucVu
                .FirstOrDefault(cv => cv.TenChucVu.Equals(tenChucVu, StringComparison.OrdinalIgnoreCase));

            return chucVu?.MaChucVu; // Trả về mã chức vụ hoặc null nếu không tìm thấy
        }

        public bool UpdateNhanVien(NhanVien nhanVienSua)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True";
            string query = "UPDATE NhanVien SET ";
            List<string> updateFields = new List<string>();

            if (!string.IsNullOrEmpty(nhanVienSua.TenNhanVien))
                updateFields.Add("TenNhanVien = @TenNhanVien");
            if (nhanVienSua.NgaySinh.HasValue)
                updateFields.Add("NgaySinh = @NgaySinh");
            if (!string.IsNullOrEmpty(nhanVienSua.DiaChi))
                updateFields.Add("DiaChi = @DiaChi");
            if (!string.IsNullOrEmpty(nhanVienSua.SoDienThoai))
                updateFields.Add("SoDienThoai = @SoDienThoai");
            if (!string.IsNullOrEmpty(nhanVienSua.MaPhongBan))
                updateFields.Add("MaPhongBan = @MaPhongBan");
            if (!string.IsNullOrEmpty(nhanVienSua.MaChucVu))
                updateFields.Add("MaChucVu = @MaChucVu");

            if (updateFields.Count == 0)
                return false;  // Không có gì để cập nhật

            query += string.Join(", ", updateFields) + " WHERE MaNhanVien = @MaNhanVien";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", nhanVienSua.MaNhanVien);
                        if (!string.IsNullOrEmpty(nhanVienSua.TenNhanVien))
                            cmd.Parameters.AddWithValue("@TenNhanVien", nhanVienSua.TenNhanVien);
                        if (nhanVienSua.NgaySinh.HasValue)
                            cmd.Parameters.AddWithValue("@NgaySinh", nhanVienSua.NgaySinh.Value);
                        if (!string.IsNullOrEmpty(nhanVienSua.DiaChi))
                            cmd.Parameters.AddWithValue("@DiaChi", nhanVienSua.DiaChi);
                        if (!string.IsNullOrEmpty(nhanVienSua.SoDienThoai))
                            cmd.Parameters.AddWithValue("@SoDienThoai", nhanVienSua.SoDienThoai);
                        if (!string.IsNullOrEmpty(nhanVienSua.MaPhongBan))
                            cmd.Parameters.AddWithValue("@MaPhongBan", nhanVienSua.MaPhongBan);
                        if (!string.IsNullOrEmpty(nhanVienSua.MaChucVu))
                            cmd.Parameters.AddWithValue("@MaChucVu", nhanVienSua.MaChucVu);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }






        public bool AddNhanVien(NhanVien nhanVienMoi)
        {
            try
            {
                if (nhanVienMoi == null)
                {
                    throw new ArgumentNullException(nameof(nhanVienMoi), "Nhân viên mới không được null");
                }
                //Kiểm tra mã nhân viên đã tồn tại chưa
                var existingNhanVien = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == nhanVienMoi.MaNhanVien);
                if (existingNhanVien != null)
                {
                    throw new Exception($"Mã nhân viên {nhanVienMoi.MaNhanVien} đã tồn tại.");
                }

                Adapter.NhanVien.Add(nhanVienMoi);
                Adapter.SaveChanges(); // Lưu thay đổi vào CSDL
                return true; // Thêm thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên mới", ex);
            }
        }
        public bool DeleteNhanVien(string maNV)
        {
            try
            {
                // Tìm nhân viên theo mã
                var nhanVien = Adapter.NhanVien.FirstOrDefault(x => x.MaNhanVien == maNV);
                if (nhanVien == null)
                {
                    throw new Exception($"Không tìm thấy nhân viên với mã: {maNV}");
                }

                // Xóa tất cả thông tin liên quan của nhân viên trong các bảng khác
                // Xóa QT_CongTac
                var qtcCongTacRecords = Adapter.QT_CongTac.Where(x => x.MaNhanVien == maNV).ToList();
                if (qtcCongTacRecords.Any())
                {
                    Adapter.QT_CongTac.RemoveRange(qtcCongTacRecords);
                }

                // Xóa DM_Luong
                var dmLuong = Adapter.DM_Luong.FirstOrDefault(x => x.MaNhanVien == maNV);
                if (dmLuong != null)
                {
                    Adapter.DM_Luong.Remove(dmLuong);
                }

                // Xóa NgayNghi
                var ngayNghiRecords = Adapter.NgayNghi.Where(x => x.MaNhanVien == maNV).ToList();
                if (ngayNghiRecords.Any())
                {
                    Adapter.NgayNghi.RemoveRange(ngayNghiRecords);
                }

                // Xóa Luong
                var luongRecords = Adapter.Luong.Where(x => x.MaNhanVien == maNV).ToList();
                if (luongRecords.Any())
                {
                    Adapter.Luong.RemoveRange(luongRecords);
                }

                // Xóa thông tin trong bảng NhanVien
                Adapter.NhanVien.Remove(nhanVien);

                // Lưu thay đổi vào CSDL
                Adapter.SaveChanges();

                return true; // Xóa thành công
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa nhân viên với mã: {maNV}", ex);
            }
        }



        // Giải phóng tài nguyên
        public void Dispose()
        {
            Adapter.Dispose();
        }
    }
}
