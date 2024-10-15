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
using LOGICPlayer;

namespace FRONTENDPlayer
{
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        ChucVuBackEnd chucvubackend = new ChucVuBackEnd();

        private void Them_CVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemChuVu formthem = new ThemChuVu();
            if (formthem.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Dong_CVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {

            dataGridView_ChucVu.DataSource = chucvubackend.LoadDataTable();
        }
    }
}