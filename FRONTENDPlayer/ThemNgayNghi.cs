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
    public partial class ThemNgayNghi : DevExpress.XtraEditors.XtraForm
    {
        public ThemNgayNghi()
        {
            InitializeComponent();
            PopulateComboBoxEdit();
            label5_CanhBao.Visible = false;

            this.AcceptButton = this.simpleButton2_XacNhan;
        }

        private void PopulateComboBoxEdit()
        {
            for (int i = 0; i <= 31; i++)
            {
                this.comboBoxEdit_SoNgayNghi.Properties.Items.Add(i);
            }
        }

        private void ThemNgayNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hRMDataSet.NhanVien);

        }

        private void simpleButton1_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_XacNhan_Click(object sender, EventArgs e)
        {
            label5_CanhBao.Visible = false;
            if (lookUpEdit1_MaNhanVien.EditValue == null || string.IsNullOrEmpty(lookUpEdit1_MaNhanVien.EditValue.ToString()))
            {
                label5_CanhBao.Visible = true;
                label5_CanhBao.Text = "Vui lòng chọn mã nhân viên.";
                label5_CanhBao.Location = new Point(316, 21);
            }
            else if (dateEdit1_ThangNghi.EditValue == null || string.IsNullOrEmpty(dateEdit1_ThangNghi.EditValue.ToString()))
            {
                label5_CanhBao.Visible = true;
                label5_CanhBao.Text = "Vui lòng chọn tháng nghỉ.";
                label5_CanhBao.Location = new Point(316, 75);
            }
            else if (((DateTime)dateEdit1_ThangNghi.EditValue) > DateTime.Now)
            {
                label5_CanhBao.Visible = true;
                label5_CanhBao.Text = "Phải bé hơn tháng hiện tại.";
                label5_CanhBao.Location = new Point(316, 75);
            }
            else if (comboBoxEdit_SoNgayNghi.SelectedItem == null)
            {
                label5_CanhBao.Visible = true;
                label5_CanhBao.Text = "Vui lòng chọn số ngày nghỉ.";
                label5_CanhBao.Location = new Point(316, 132);
            }
            else
            {
                NgayNghiBackEnd ngayNghiBackEnd = new NgayNghiBackEnd();
                NgayNghi ngayNghi = new NgayNghi();

                // Lấy giá trị từ lookUpEdit1_MaNhanVien
                DataRowView dataRowView = lookUpEdit1_MaNhanVien.EditValue as DataRowView;
                if (dataRowView != null)
                {
                    ngayNghi.MaNhanVien = dataRowView["MaNhanVien"].ToString();
                }

                ngayNghi.ThangNam = ((DateTime)dateEdit1_ThangNghi.EditValue).ToString("MM/yyyy");
                ngayNghi.SoNgayNghi = (int)comboBoxEdit_SoNgayNghi.SelectedItem;
                ngayNghi.GhiChu = textBox3_GhiChu.Text;

                try
                {
                    if (ngayNghiBackEnd.Add(ngayNghi))
                    {
                        XtraMessageBox.Show("Thêm ngày nghỉ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã nhân viên và tháng nghỉ đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm ngày nghỉ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}