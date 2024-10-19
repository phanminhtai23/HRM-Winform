using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class ChucVuBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public List<DM_ChucVu> LoadDataTable() => Adapter.DM_ChucVu.AsNoTracking().ToList();

        public bool AddChucVu(string maChucVu, string tenChucVu, decimal heSoLuong)
        {
            try
            {
                DM_ChucVu newChucVu = new DM_ChucVu
                {
                    MaChucVu = maChucVu,
                    TenChucVu = tenChucVu,
                    HeSoLuong = heSoLuong,
                };

                Adapter.DM_ChucVu.Add(newChucVu);
                Adapter.SaveChanges();
                return true;

            }
            catch 
            {
                return false;
            }

        }

        public bool IsDuplicate(string maChucVu, string tenChucVu)
        {
            // Kiểm tra xem có chức vụ nào trùng mã hoặc tên không
            return Adapter.DM_ChucVu.Any(cv => cv.MaChucVu == maChucVu || cv.TenChucVu == tenChucVu);
        }

        public bool UpdateChucVu(string maChucVu, string tenChucVuMoi, decimal heSoLuongMoi)
        {
            try
            {
                // Tìm chức vụ theo mã trong cơ sở dữ liệu
                var chucVu = Adapter.DM_ChucVu.SingleOrDefault(cv => cv.MaChucVu == maChucVu);

                if (chucVu != null)
                {
                    // Cập nhật các thuộc tính của chức vụ
                    chucVu.TenChucVu = tenChucVuMoi;
                    chucVu.HeSoLuong = heSoLuongMoi;

                    // Lưu thay đổi
                    Adapter.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<DM_ChucVu> SearchChucVu(string keyword)
        {
            try
            {
                // Sử dụng LINQ để tìm kiếm chức vụ dựa trên từ khóa
                var result = Adapter.DM_ChucVu.AsNoTracking()
                                .Where(cv => cv.MaChucVu.ToLower().Contains(keyword)
                                          || cv.TenChucVu.ToLower().Contains(keyword)
                                          || cv.HeSoLuong.ToString().Contains(keyword))
                                .ToList();

                return result;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return new List<DM_ChucVu>(); // Trả về danh sách rỗng nếu có lỗi
            }
        }

        public void Remove(DM_ChucVu chucVu)
        {
            try
            {
                DM_ChucVu Row = Adapter.DM_ChucVu.FirstOrDefault(x => x.MaChucVu == chucVu.MaChucVu);
                Adapter.DM_ChucVu.Remove(Row);
                Adapter.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
