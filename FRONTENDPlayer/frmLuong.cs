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
    public partial class frmLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmLuong()
        {
            ThongBao.Load_TableLuong += load_data;
            InitializeComponent();
        }
        NgayNghiBackEnd ngayNghiBackEnd = new NgayNghiBackEnd();

        public void load_data()
        {
            this.luongTableAdapter.FillBy(this.hRMDataSet.Luong);
            gridView1.OptionsBehavior.Editable = false;
            ngayNghiBackEnd.UpdateLuong();
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChonThongKe chonThongKe = new ChonThongKe();
            if(DialogResult.OK == chonThongKe.ShowDialog())
            {

            }
        }
    }
}