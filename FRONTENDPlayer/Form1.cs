using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public Dangnhap()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

            DangKy dangky = new DangKy();
            dangky.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn thoát ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            label4_SaiTK.Visible = false;
            if (textBox_TaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_TaiKhoan.Focus();
            }
            else if (textBox_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MatKhau.Focus();
            }
            else if (textBox_TaiKhoan.Text != "admin" || textBox_MatKhau.Text != "123")
            {
                label4_SaiTK.Visible = true;
            }

            else if (textBox_TaiKhoan.Text == "admin" && textBox_MatKhau.Text == "123")
            {
                TrangChu trangChu = new TrangChu();
                this.Hide();
                trangChu.Show();
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn thoát ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }


    }
}
