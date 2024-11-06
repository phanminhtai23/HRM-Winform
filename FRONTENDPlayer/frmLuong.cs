using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DATAPlayer;
using System.Data.SqlClient;
using LOGICPlayer;

namespace FRONTENDPlayer
{
    public partial class frmLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmLuong()
        {
            ThongBao.Load_TableLuong += load_data;
            //ThongBao.Load_TableDM_ChucVu += load_data;
            //ThongBao.Load_TableNhanVien += load_data;
            InitializeComponent();
        }

        Luong1 _bangLuong;
        List<Luong1> _lstBangLuong;

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InLuong inluong = new InLuong();
            if (DialogResult.OK == inluong.ShowDialog())
            {

            }
        }

        NgayNghiBackEnd ngayNghiBackEnd = new NgayNghiBackEnd();
        public void load_data()
        {
            ngayNghiBackEnd.UpdateLuong();
            this.luongTableAdapter.FillBy(this.hRMDataSet.Luong);
            gridView1.OptionsBehavior.Editable = false;
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.Luong' table. You can move, or remove it, as needed.
            load_data();
            // TODO: This line of code loads data into the 'hRMDataSet.DataTable1' table. You can move, or remove it, as needed.

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongBao.Load_TableLuong -= load_data;
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChonThongKe chonThongKe = new ChonThongKe();
            if(DialogResult.OK == chonThongKe.ShowDialog())
            {

            }
        }

        public class Luong1
        {
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; } // Thêm thuộc tính này để chứa tên nhân viên
            public string ThangNam { get; set; }
            public int SoNgayLam { get; set; } // Kiểu int cho Số Ngày Làm
            public int LuongThucLanh { get; set; } // Kiểu int cho Lương Thực Lãnh
        }
    }
}