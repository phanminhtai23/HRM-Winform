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
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        PhongBanBackEnd phongbanbackend = new PhongBanBackEnd();
        

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            dataGridView_PhongBan.DataSource = phongbanbackend.LoadDataTable();
        }
    }
}