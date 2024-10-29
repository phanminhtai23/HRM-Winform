using DATAPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICPlayer
{
    public class NgayNghiBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public List<NgayNghi> LoadDataTable() => Adapter.NgayNghi.AsNoTracking().ToList();

        public bool Add(NgayNghi ThemNgayNghi)
        {
            try
            {
                // Check if the record already exists
                //Console.WriteLine($"MaNhanVien: {ThemNgayNghi.MaNhanVien}, ThangNam: {ThemNgayNghi.ThangNam}");
                bool exists = Adapter.NgayNghi.Any(x => (x.MaNhanVien == ThemNgayNghi.MaNhanVien && x.ThangNam == ThemNgayNghi.ThangNam));
                if (exists)
                {
                    return false;
                } else
                {
                    Adapter.NgayNghi.Add(ThemNgayNghi);
                    Adapter.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Update(NgayNghi UpdateNgayNghi)
        {
            try
            {
                String String_MaNhanVien = UpdateNgayNghi.MaNhanVien;
                String String_ThangNam = UpdateNgayNghi.ThangNam;
                NgayNghi Row = Adapter.NgayNghi.FirstOrDefault(x => x.MaNhanVien == String_MaNhanVien && x.ThangNam == String_ThangNam);
                Row.MaNhanVien = UpdateNgayNghi.MaNhanVien; 
                Row.ThangNam = UpdateNgayNghi.ThangNam;
                Row.SoNgayNghi = UpdateNgayNghi.SoNgayNghi;
                Row.GhiChu = UpdateNgayNghi.GhiChu;

                Adapter.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }
        }
        public void Remove(NgayNghi RemoveNgayNghi)
        {
            try
            {
                String String_MaNhanVien = RemoveNgayNghi.MaNhanVien;
                String String_ThangNam = RemoveNgayNghi.ThangNam;
                NgayNghi Row = Adapter.NgayNghi.FirstOrDefault(x => x.MaNhanVien == String_MaNhanVien && x.ThangNam == String_ThangNam);

                Adapter.NgayNghi.Remove(Row);

                Adapter.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }
        }
    }
}
