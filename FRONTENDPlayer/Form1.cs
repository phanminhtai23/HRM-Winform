using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DATAPlayer;

namespace FRONTENDPlayer
{

    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        private bool KiemTraDangNhap(string username, string password)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True;Encrypt=True;";

        // Truy vấn SQL kiểm tra tài khoản
        string query = "SELECT COUNT(1) FROM Users WHERE username = @username AND password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Thêm tham số để tránh SQL Injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Thực thi truy vấn và lấy kết quả
                    int count = (int)cmd.ExecuteScalar();

                    // Nếu count = 1, tức là tài khoản tồn tại
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    return false;
                }
            }
        }

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
            else if (KiemTraDangNhap(textBox_TaiKhoan.Text, textBox_MatKhau.Text))
            {
                TrangChu trangChu = new TrangChu();
                this.Hide();
                trangChu.Show();
            } else
            {
                label4_SaiTK.Visible = true;
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
