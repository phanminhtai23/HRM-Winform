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

namespace FRONTENDPlayer
{
    public partial class frmNgayNghi : DevExpress.XtraEditors.XtraForm
    {
        public frmNgayNghi()
        {
            InitializeComponent();
        }

        private void frmNgayNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.NgayNghi' table. You can move, or remove it, as needed.
            this.ngayNghiTableAdapter.Fill(this.hRMDataSet.NgayNghi);
        }

        private void barButtonItem1_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNgayNghi themNgayNghi = new ThemNgayNghi();
            if (themNgayNghi.ShowDialog() == DialogResult.OK)
            {
                this.ngayNghiTableAdapter.Fill(this.hRMDataSet.NgayNghi);
            }
        }

        private void barButtonItem4_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}