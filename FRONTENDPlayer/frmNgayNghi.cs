using DATAPlayer;
using DevExpress.XtraEditors;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class frmNgayNghi : DevExpress.XtraEditors.XtraForm
    {
        public frmNgayNghi()
        {
            ThongBao.Load_TableLuong += load_data;
            InitializeComponent();
        }
        NgayNghiBackEnd ngayNghiBackEnd = new NgayNghiBackEnd();
        private void frmNgayNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.NgayNghi' table. You can move, or remove it, as needed.
            //this.ngayNghiTableAdapter.FillBy1(this.hRMDataSet.NgayNghi);
            load_data();
        }

        public void load_data()
        {
            this.ngayNghiTableAdapter.FillBy1(this.hRMDataSet.NgayNghi);
            gridView1.OptionsBehavior.Editable = false;
            ngayNghiBackEnd.UpdateLuong();

        }
        // click thêm ngày nghỉ
        private void barButtonItem1_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNgayNghi themNgayNghi = new ThemNgayNghi();
            if (themNgayNghi.ShowDialog() == DialogResult.OK)
            {
                load_data();
                ThongBao.CapNhatBang_Luong();
            }
        }

        private void barButtonItem4_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy GridView từ GridControl
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // Kiểm tra xem có dòng nào được chọn không
            if (gridView.FocusedRowHandle >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                string maNhanVien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNhanVien").ToString();
                string thangNam = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ThangNam").ToString();
                int soNgayNghi = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "SoNgayNghi"));
                string ghiChu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "GhiChu").ToString();

                // Tạo đối tượng form sửa với dữ liệu được chọn
                SuaNgayNghi formSua = new SuaNgayNghi(maNhanVien, thangNam, soNgayNghi, ghiChu);

                // Hiển thị form sửa
                if (formSua.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi sửa, tải lại dữ liệu vào GridControl
                    load_data();
                    ThongBao.CapNhatBang_Luong();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barButtonItem3_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy GridView từ GridControl
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // Kiểm tra xem có dòng nào được chọn không
            if (gridView.FocusedRowHandle >= 0)
            {
                

                try
                {
                    // Lấy dữ liệu từ dòng được chọn
                    string maNhanVien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNhanVien").ToString();
                    string thangNam = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ThangNam").ToString();
                    int soNgayNghi = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "SoNgayNghi"));
                    string ghiChu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "GhiChu").ToString();


                    NgayNghi ngayNghi = new NgayNghi();
                    ngayNghi.MaNhanVien = maNhanVien;
                    ngayNghi.ThangNam = thangNam;
                    ngayNghi.SoNgayNghi = soNgayNghi;
                    ngayNghi.GhiChu = ghiChu;

                    
                    ngayNghiBackEnd.Remove(ngayNghi);


                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ngayNghiTableAdapter.FillBy1(this.hRMDataSet.NgayNghi);
                    ThongBao.CapNhatBang_Luong();
                }
                catch
                {
                    MessageBox.Show("Xóa phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}