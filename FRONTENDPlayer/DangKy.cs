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
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        public DangKy()
        {
            InitializeComponent();
            textBox_TaiKhoan.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            this.Hide();
            dangnhap.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            textBox_TaiKhoan.Text = string.Empty;
            textBox2_MatKhau.Text = string.Empty;
            textBox3_XacNhanMK.Text = string.Empty;
            textBox_TaiKhoan.Focus();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap .Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_TaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_TaiKhoan.Focus();
            }
            else if (textBox2_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_MatKhau.Focus();
            }
            else if (textBox3_XacNhanMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_XacNhanMK.Focus();
            }
            else if (textBox3_XacNhanMK.Text != textBox2_MatKhau.Text)
            {
                MessageBox.Show("Bạn đã nhập sai xác nhận mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_XacNhanMK.Focus();
            }
            // VIẾT CHƯA XONG - nếu tại tk hợp lệ -> lưu tài khoản và chuyển đến trang đăng ký
            else if (textBox_TaiKhoan.Text == "Nếu Đăng ký thành công")
            {
                MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dangnhap dangnhap = new Dangnhap();
                dangnhap.Show();
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}