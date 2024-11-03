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
            InitializeComponent();
        }

        Luong _bangLuong;
        List<Luong> _lstBangLuong;
        public void load_data()
        {
            this.luongTableAdapter.FillBy(this.hRMDataSet.Luong);

        }

        private void Luong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.Luong' table. You can move, or remove it, as needed.
            load_data();
            // TODO: This line of code loads data into the 'hRMDataSet.DataTable1' table. You can move, or remove it, as needed.

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_InLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //rptBangLuong rptBangLuong = new rptBangLuong(_lstBangLuong);
            //rptBangLuong.ShowPreviewDialog();
            InLuong inLuong = new InLuong();
            if(inLuong.ShowDialog() == DialogResult.OK)
            {

            }
        }


    }
    public class Luong
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; } // Thêm thuộc tính này để chứa tên nhân viên
        public string ThangNam { get; set; }
        public int SoNgayLam { get; set; } // Kiểu int cho Số Ngày Làm
        public int LuongThucLanh { get; set; } // Kiểu int cho Lương Thực Lãnh
    }
}