using DATAPlayer;
using DevExpress.XtraEditors;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class SuaNgayNghi : DevExpress.XtraEditors.XtraForm
    {
        public string maNhanVien = "";
        public string thangNam = "";
        public int soNgayNghi = 0;
        public string ghiChu = "";
        public SuaNgayNghi(string maNhanVien, string thangNam, int soNgayNghi, string ghiChu)
        {
            InitializeComponent();
            PopulateComboBoxEdit();
            this.AcceptButton = this.simpleButton2_XacNhan;

            this.maNhanVien = maNhanVien;
            this.thangNam = thangNam;
            this.soNgayNghi = soNgayNghi;
            this.ghiChu = ghiChu;

            lookUpEdit1_MaNhanVien.EditValue = maNhanVien;
            dateEdit1_ThangNghi.DateTime = DateTime.ParseExact(thangNam, "MM/yyyy", CultureInfo.InvariantCulture);
            comboBoxEdit_SoNgayNghi.EditValue = soNgayNghi;
            textBox3_GhiChu.Text = ghiChu;

        }

        private void PopulateComboBoxEdit()
        {
            for (int i = 0; i <= 31; i++)
            {
                this.comboBoxEdit_SoNgayNghi.Properties.Items.Add(i);
            }
        }

        private void simpleButton2_XacNhan_Click(object sender, EventArgs e)
        {
            label5_CanhBao.Visible = false;
            string maNhanVien = lookUpEdit1_MaNhanVien.EditValue?.ToString() ?? "N/A";
            string thangNghi = dateEdit1_ThangNghi.EditValue != null ? ((DateTime)dateEdit1_ThangNghi.EditValue).ToString("MM/yyyy") : "N/A";
            string soNgayNghi = comboBoxEdit_SoNgayNghi.SelectedItem?.ToString() ?? "N/A";
            string ghiChu = textBox3_GhiChu.Text;

             if (comboBoxEdit_SoNgayNghi.SelectedItem == null)
            {
                label5_CanhBao.Visible = true;
                label5_CanhBao.Text = "Vui lòng chọn số ngày nghỉ.";
                label5_CanhBao.Location = new Point(360, 110); 
            }
            else
            {
                NgayNghiBackEnd ngayNghiBackEnd = new NgayNghiBackEnd();
                NgayNghi ngayNghi = new NgayNghi();

                ngayNghi.MaNhanVien = this.maNhanVien;
                ngayNghi.ThangNam = this.thangNam;
                ngayNghi.SoNgayNghi = (int)comboBoxEdit_SoNgayNghi.SelectedItem;
                ngayNghi.GhiChu = textBox3_GhiChu.Text;

                try
                {
                    if (ngayNghiBackEnd.Update(ngayNghi))
                    {
                        XtraMessageBox.Show("Sửa ngày nghỉ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã nhân viên và tháng nghỉ đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Sửa ngày nghỉ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void simpleButton1_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaNgayNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.hRMDataSet.NhanVien);

            

        }

        private void dateEdit1_ThangNghi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}