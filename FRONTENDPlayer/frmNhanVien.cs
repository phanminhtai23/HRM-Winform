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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBackEnd nhanvienbackend = new NhanVienBackEnd();

        private void Them_NV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemThongTinNhanVien FormThemNV = new ThemThongTinNhanVien();
            if(FormThemNV.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Dong_fromNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView_NhanVien.DataSource = nhanvienbackend.LoadDataTable();
        }
    }
}