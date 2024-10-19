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
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        private string col1 = "", col2 = "", col3 = "";
        PhongBanBackEnd phongbanbackend = new PhongBanBackEnd();
        public frmPhongBan()
        {
            InitializeComponent();
        }
        
        public void frmPhongBan_Load(object sender, EventArgs e)
        {
            Load_DataTable();
        }
        
        private void Them_PBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemPhongBan themPhongBan = new ThemPhongBan();
            if (themPhongBan.ShowDialog() == DialogResult.OK)
            {
                Load_DataTable();
            }
        }

        private void Load_DataTable()
        {
            dataGridView_PhongBan.DataSource = phongbanbackend.LoadDataTable();
            dataGridView_PhongBan.ClearSelection();
        }
        private void Sua_PBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Chưa nhấp vào hàng thì k hiện bảng sửa
            if (col1 == "" || col2 == "" || col3 == "") {
                MessageBox.Show("Vui lòng chọn hàng để sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                SuaPhongBan suaPhongBan = new SuaPhongBan(col1, col2, col3);
                if (suaPhongBan.ShowDialog() == DialogResult.OK)
                {
                    Load_DataTable();
                }
            }
        }

        private void Dong_PBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Xoa_PBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Chưa nhấp vào hàng thì k hiện bảng sửa
            if (col1 == "" || col2 == "" || col3 == "")
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    PhongBanBackEnd phongBanBackEnd = new PhongBanBackEnd();

                    PhongBan phongBan = new PhongBan();
                    phongBan.MaPhongBan = col1;
                    phongBan.TenPhongBan = col2;
                    phongBan.VanPhong = col3;

                    phongBanBackEnd.Remove(phongBan);

                    Load_DataTable();
                    MessageBox.Show("Xóa phòng ban thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }

        }

        private void TimKiemPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dataGridView_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dataGridView_PhongBan.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột và lưu vào biến
                col1 = row.Cells[0].Value.ToString(); // Cột 1
                col2 = row.Cells[1].Value.ToString(); // Cột 2
                col3 = row.Cells[2].Value.ToString(); // Cột 3
            }
        }
    }
}