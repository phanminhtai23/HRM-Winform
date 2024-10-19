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
using DATAPlayer;

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
            ThemChucVu formthem = new ThemChucVu();
            if (formthem.ShowDialog() == DialogResult.OK)
            {
                dataGridView_ChucVu.DataSource = chucvubackend.LoadDataTable();
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

        private void Sua_Cvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy hàng hiện tại được chọn từ dataGridView_ChucVu
            if (dataGridView_ChucVu.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu của hàng được chọn
                var selectedRow = dataGridView_ChucVu.SelectedRows[0];
                string maChucVu = selectedRow.Cells["MaChucVu"].Value.ToString();
                string tenChucVu = selectedRow.Cells["TenChucVu"].Value.ToString();
                decimal heSoLuong = Convert.ToDecimal(selectedRow.Cells["HeSoLuong"].Value);

                // Khởi tạo form SuaChucVu với dữ liệu của hàng được chọn
                SuaChucVu formSua = new SuaChucVu(maChucVu, tenChucVu, heSoLuong);

                if (formSua.ShowDialog() == DialogResult.OK)
                {
                    // Làm mới lại dataGridView_ChucVu sau khi sửa
                    dataGridView_ChucVu.DataSource = chucvubackend.LoadDataTable();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Tim_CVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void Xoa_CVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (dataGridView_ChucVu.SelectedRows.Count > 0)
            {
                try
                {
                    //// Lấy dữ liệu của hàng được chọ

                    var selectedRow = dataGridView_ChucVu.SelectedRows[0];
                    string maChucVu = selectedRow.Cells["MaChucVu"].Value.ToString();

                    ChucVuBackEnd chucVuBackEnd = new ChucVuBackEnd();
                    DM_ChucVu chucVu = new DM_ChucVu();
                    chucVu.MaChucVu = maChucVu;

                    chucVuBackEnd.Remove(chucVu);
                    dataGridView_ChucVu.DataSource = chucvubackend.LoadDataTable();
                }
                catch  
                {
                    MessageBox.Show("Không thể xóa chức vụ đã có trong bảng nhân viên .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void In_CVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dataGridView_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}