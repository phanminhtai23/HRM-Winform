﻿using DATAPlayer;
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

        public void UpdateLuong()
        {
            try
            {
                // Lấy danh sách các ngày nghỉ từ bảng NgayNghi
                var dsNgayNghi = Adapter.NgayNghi.ToList();

                // Lấy tất cả bản ghi từ bảng Luong
                var dsLuong = Adapter.Luong.ToList();

                foreach (var luong in dsLuong)
                {
                    // Kiểm tra xem bản ghi tương ứng trong bảng NgayNghi có tồn tại không
                    var ngayNghiRecord = dsNgayNghi
                        .FirstOrDefault(n => n.MaNhanVien == luong.MaNhanVien && n.ThangNam == luong.ThangNam);

                    if (ngayNghiRecord == null)
                    {
                        // Nếu không tồn tại bản ghi trong NgayNghi, xóa bản ghi trong Luong
                        Adapter.Luong.Remove(luong);
                    }
                }
                // Lưu thay đổi khi xóa các bản ghi không hợp lệ
                Adapter.SaveChanges();


                foreach (var ngayNghi in dsNgayNghi)
                {
                    // Lấy thông tin nhân viên từ bảng Luong
                    var luongRecord = Adapter.Luong.FirstOrDefault(l => l.MaNhanVien == ngayNghi.MaNhanVien && l.ThangNam == ngayNghi.ThangNam);

                    // Tính số ngày làm việc
                    int month = int.Parse(ngayNghi.ThangNam.Substring(0, 2));
                    int year = int.Parse(ngayNghi.ThangNam.Substring(3, 4));
                    int ngayTrongThang = DateTime.DaysInMonth(year, month);
                    int soNgayLam = (int)(ngayTrongThang - ngayNghi.SoNgayNghi);

                    // Lấy thông tin lương cơ bản, phụ cấp và khấu trừ thuế từ bảng DM_Luong
                    var thongtinLuong = Adapter.DM_Luong
                        .Where(x => x.MaNhanVien == ngayNghi.MaNhanVien)
                        .Select(x => new { x.LuongCoBan, x.KhauTruThue, x.PhuCap })
                        .FirstOrDefault();
                    // Lấy hệ số lương
                    var hsLuong = Adapter.NhanVien
                        .Where(nv => nv.TinhTrangLamViec == true && nv.MaNhanVien == ngayNghi.MaNhanVien) // Lấy nhân viên đang làm việc
                        .Join(
                            Adapter.DM_ChucVu,
                            nv => nv.MaChucVu,
                            cv => cv.MaChucVu,
                            (nv, cv) => cv.HeSoLuong
                        )
                        .FirstOrDefault();
                    if (thongtinLuong != null && hsLuong != null)
                    {
                        int luongNgay = (int)((thongtinLuong.LuongCoBan * hsLuong) / ngayTrongThang);

                        // Tính trừ ngày công nghỉ từ ngày nghỉ thứ 2 
                        int tinhNgayNghi = Math.Max((int)ngayNghi.SoNgayNghi - 1, 0);
                        int truNghi = luongNgay * tinhNgayNghi;

                        // Tính LươngThucLanh dựa trên số ngày làm việc và lương cơ bản
                        int luongThucLanh = ((int)Math.Round((int)((thongtinLuong.LuongCoBan * hsLuong)
                                + thongtinLuong.PhuCap
                                - thongtinLuong.KhauTruThue
                                - truNghi) / 1000.0) * 1000);

                        if (luongRecord != null)
                        {
                            // Cập nhật lương
                            luongRecord.SoNgayLam = soNgayLam;
                            luongRecord.LuongThucLanh = luongThucLanh;
                        }
                        else
                        {
                            // Tạo bản ghi mới trong bảng Luong
                            Luong themLuong = new Luong
                            {
                                MaNhanVien = ngayNghi.MaNhanVien,
                                ThangNam = ngayNghi.ThangNam,
                                SoNgayLam = soNgayLam,
                                LuongThucLanh = luongThucLanh
                            };
                            Adapter.Luong.Add(themLuong);
                        }
                        // Lưu thay đổi
                        Adapter.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public bool Add(NgayNghi ThemNgayNghi)
        {
            try
            {
                // Kiểm tra xem bản ghi đã tồn tại chưa
                bool exists = Adapter.NgayNghi.Any(x => x.MaNhanVien == ThemNgayNghi.MaNhanVien && x.ThangNam == ThemNgayNghi.ThangNam);
                if (exists)
                {
                    return false;
                }
                else
                {
                    // Thêm bản ghi mới vào bảng NgayNghi
                    Adapter.NgayNghi.Add(ThemNgayNghi);

                    // Tách lấy tháng và năm từ ThangNam
                    int month = int.Parse(ThemNgayNghi.ThangNam.Substring(0, 2));
                    int year = int.Parse(ThemNgayNghi.ThangNam.Substring(3, 4));

                    // Lấy tổng số ngày trong tháng
                    int ngayTrongThang = DateTime.DaysInMonth(year, month);

                    // Tính số ngày làm việc
                    int soNgayLam = (int)(ngayTrongThang - ThemNgayNghi.SoNgayNghi);

                    // Lấy thông tin lương từ bảng DM_Luong
                    var thongtinLuong = Adapter.DM_Luong
                        .Where(x => x.MaNhanVien == ThemNgayNghi.MaNhanVien)
                        .Select(x => new { x.LuongCoBan, x.KhauTruThue, x.PhuCap })
                        .FirstOrDefault();

                    // Lấy hệ số lương của nhân viên
                    var hsLuong = Adapter.NhanVien
                        .Where(nv => nv.TinhTrangLamViec == true && nv.MaNhanVien == ThemNgayNghi.MaNhanVien) // Lấy nhân viên đang làm việc
                        .Join(
                            Adapter.DM_ChucVu,
                            nv => nv.MaChucVu,
                            cv => cv.MaChucVu,
                            (nv, cv) => cv.HeSoLuong
                        )
                        .FirstOrDefault();

                    // Kiểm tra thông tin lương và hệ số lương
                    if (thongtinLuong == null)
                    {
                        throw new Exception("Không tìm thấy thông tin lương cho nhân viên này.");
                    }
                    if (hsLuong == null)
                    {
                        throw new Exception("Không tìm thấy thông tin về hệ số lương của nhân viên này.");
                    }

                    // Tính lương theo ngày
                    int luongNgay = (int)((thongtinLuong.LuongCoBan * hsLuong) / ngayTrongThang);

                    // Tính trừ ngày công nghỉ từ ngày nghỉ thứ 2 
                    int tinhNgayNghi = Math.Max((int)ThemNgayNghi.SoNgayNghi - 1, 0);
                    int truNghi = luongNgay * tinhNgayNghi;

                    // Tính LươngThucLanh
                    int luongThucLanh = ((int)Math.Round((int)((thongtinLuong.LuongCoBan * hsLuong)
                                + thongtinLuong.PhuCap
                                - thongtinLuong.KhauTruThue
                                - truNghi) / 1000.0) * 1000);

                    // Tạo bản ghi mới trong bảng Luong
                    Luong themLuong = new Luong
                    {
                        MaNhanVien = ThemNgayNghi.MaNhanVien,
                        ThangNam = ThemNgayNghi.ThangNam,
                        SoNgayLam = soNgayLam,
                        LuongThucLanh = luongThucLanh
                    };
                    Adapter.Luong.Add(themLuong);

                    // Lưu thay đổi vào database
                    Adapter.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public bool Update(NgayNghi UpdateNgayNghi)
        {
            try
            {
                   String String_MaNhanVien = UpdateNgayNghi.MaNhanVien;
                   String String_ThangNam = UpdateNgayNghi.ThangNam;
                   NgayNghi Row = Adapter.NgayNghi.FirstOrDefault(x => (x.MaNhanVien == String_MaNhanVien && x.ThangNam == String_ThangNam));
                   //Row.MaNhanVien = UpdateNgayNghi.MaNhanVien;
                   //Row.ThangNam = UpdateNgayNghi.ThangNam;
                   Row.SoNgayNghi = UpdateNgayNghi.SoNgayNghi;
                   Row.GhiChu = UpdateNgayNghi.GhiChu;
                   Adapter.SaveChanges();

                   return true;
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
                string maNhanVien = RemoveNgayNghi.MaNhanVien;
                string thangNam = RemoveNgayNghi.ThangNam;

                // Tìm bản ghi trong bảng NgayNghi
                var ngayNghiRecord = Adapter.NgayNghi
                    .FirstOrDefault(x => x.MaNhanVien == maNhanVien && x.ThangNam == thangNam);

                if (ngayNghiRecord != null)
                {
                    // Tìm bản ghi trong bảng Luong liên quan đến ngày nghỉ này
                    var luongRecord = Adapter.Luong
                        .FirstOrDefault(x => x.MaNhanVien == maNhanVien && x.ThangNam == thangNam);

                    // Xóa bản ghi trong bảng NgayNghi
                    Adapter.NgayNghi.Remove(ngayNghiRecord);

                    // Nếu tồn tại bản ghi trong bảng Luong, thì xóa nó
                    if (luongRecord != null)
                    {
                        Adapter.Luong.Remove(luongRecord);
                    }

                    // Lưu thay đổi vào database
                    Adapter.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy bản ghi trong bảng NgayNghi để xóa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
