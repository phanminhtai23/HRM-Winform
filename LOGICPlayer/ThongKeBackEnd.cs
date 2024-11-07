using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAPlayer;

namespace LOGICPlayer
{
    public class ThongKeBackEnd
    {
        readonly HRMEntities Adapter = new HRMEntities();
        public long TongLuongNhanVien_ddMMyyy(string NgayBatDau, string NgayKetThuc)
        {
            using (var context = new HRMEntities())
            {
                // Chuyển NgayBatDau và NgayKetThuc thành định dạng YYYYMM để so sánh
                int ngayBatDauInt = int.Parse(NgayBatDau.Substring(6, 4)) * 100 + int.Parse(NgayBatDau.Substring(3, 2));
                int ngayKetThucInt = int.Parse(NgayKetThuc.Substring(6, 4)) * 100 + int.Parse(NgayKetThuc.Substring(3, 2));

                long totalSalary = context.Luong
                    .AsEnumerable()
                    .Where(l =>
                        (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) >= ngayBatDauInt &&
                        (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) <= ngayKetThucInt)
                    .Sum(l => (long)l.LuongThucLanh);
                return totalSalary; // Trả về 0 nếu totalSalary là null
            }
        }

        public int TongLuongNhanVien_MMyyy(string NgayBatDau, string NgayKetThuc)
        {
            using (var context = new HRMEntities())
            {
                // Hiển thị giá trị để kiểm tra
                //Console.WriteLine($"NgayBatDau: {NgayBatDau}, NgayKetThuc: {NgayKetThuc}");

                // Chuyển NgayBatDau và NgayKetThuc thành định dạng YYYYMM để so sánh
                int ngayBatDauInt = int.Parse(NgayBatDau.Substring(3, 4)) * 100 + int.Parse(NgayBatDau.Substring(0, 2));
                int ngayKetThucInt = int.Parse(NgayKetThuc.Substring(3, 4)) * 100 + int.Parse(NgayKetThuc.Substring(0, 2));

                // Hiển thị giá trị để kiểm tra

                //Console.WriteLine($"NgayBatDauInt: {ngayBatDauInt}, NgayKetThucInt: {ngayKetThucInt}");
                var totalSalary = context.Luong
                    .AsEnumerable()
                    .Where(l =>
                        (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) >= ngayBatDauInt &&
                        (int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2))) <= ngayKetThucInt)
                    .Sum(l => l.LuongThucLanh);

                return totalSalary ?? 0; // Trả về 0 nếu totalSalary là null
            }
        }

        public int LayLuongThucLanh(string thangNam)
        {
            // Print thangNam to console
            Console.WriteLine($"thangNam: {thangNam}");

            using (var context = new HRMEntities())
            {
                // Chuyển đổi chuỗi 'mm/yyyy' thành định dạng số nguyên 'yyyymm'
                int thangNamInt = int.Parse(thangNam.Substring(3, 4)) * 100 + int.Parse(thangNam.Substring(0, 2));

                // Truy vấn lương thực lãnh cho tháng-năm cụ thể
                var totalLuongThucLanh = context.Luong
                    .AsEnumerable()
                    .Where(l => int.Parse(l.ThangNam.Substring(3, 4)) * 100 + int.Parse(l.ThangNam.Substring(0, 2)) == thangNamInt)
                    .Sum(l => l.LuongThucLanh);

                return totalLuongThucLanh ?? 0;
            }
        }
    }
}
