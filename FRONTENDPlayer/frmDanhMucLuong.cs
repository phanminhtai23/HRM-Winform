using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATAPlayer;
using LOGICPlayer;

namespace FRONTENDPlayer
{
    public partial class frmDanhMucLuong : DevExpress.XtraEditors.XtraForm
    {
        private BackendDMLuong backend = new BackendDMLuong();

        public frmDanhMucLuong()
        {
            InitializeComponent();
        }

        private void frmDanhMucLuong_Load(object sender, EventArgs e)
        {
            this.dM_LuongTableAdapter.FillBy(this.hRMDataSet.DM_Luong);
        }

        private void Them_DMLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNhanVien = "Mã nhân viên mới"; // Giá trị mã nhân viên mới, tùy chỉnh
            if (backend.ThemLuongMoi(maNhanVien))
            {
                MessageBox.Show("Đã thêm lương mới cho nhân viên.");
                this.dM_LuongTableAdapter.Fill(this.hRMDataSet.DM_Luong);
            }
            else
            {
                MessageBox.Show("Thêm lương thất bại.");
            }
        }

        private void Sua_DMLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                string maNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNhanVien").ToString();
                decimal? luongCoBan = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LuongCoBan") as decimal?;
                decimal? phuCap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PhuCap") as decimal?;
                decimal? khauTruThue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KhauTruThue") as decimal?;

                // Tạo form sửa và truyền dữ liệu hàng đã chọn vào
                SuaDanhMucLuong suaDanhMucLuong = new SuaDanhMucLuong(maNhanVien, luongCoBan, phuCap, khauTruThue);
                if (suaDanhMucLuong.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại dữ liệu sau khi sửa
                    this.dM_LuongTableAdapter.FillBy(this.hRMDataSet.DM_Luong);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void Xoa_DMLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                string maNhanVien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNhanVien").ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa Lương", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (backend.XoaLuong(maNhanVien))
                    {
                        MessageBox.Show("Xóa lương thành công.");
                        this.dM_LuongTableAdapter.Fill(this.hRMDataSet.DM_Luong);
                    }
                    else
                    {
                        MessageBox.Show("Xóa lương thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void Dong_DMLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}