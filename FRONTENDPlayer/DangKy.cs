using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FRONTENDPlayer
{
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        private bool TrungTaiKhoan(string username)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True;";

            // Truy vấn SQL kiểm tra tài khoản
            string query = "SELECT COUNT(1) FROM TaiKhoan WHERE TenTaiKhoan = @username";

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
        private bool ThemTaiKhoan(string Username, string Password, string Email)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            //Trust Server Certificate = True; Encrypt = True;
            string connectionString = "Data Source=localhost;Initial Catalog=HRM;Integrated Security=True;";

            // Truy vấn SQL kiểm tra tài khoản
            string query = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email) VALUES (@Username, @Password, @Email)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password); // Bạn nên mã hóa mật khẩu trước khi lưu vào DB
                    cmd.Parameters.AddWithValue("@Email", Email);

                    // Thực thi truy vấn và lấy kết quả
                    int count = (int)cmd.ExecuteScalar();

                    // Nếu count = 1, thêm tk thành công
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    return false;
                }
            }
        }


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
            textBox1_Gmail.Text = string.Empty;
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
            else if (textBox1_Gmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Gmail !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1_Gmail.Focus();
            }
            // VIẾT CHƯA XONG - nếu tại tk hợp lệ -> lưu tài khoản và chuyển đến trang đăng ký
            else if (!TrungTaiKhoan(textBox_TaiKhoan.Text))
            {
                if (ThemTaiKhoan(textBox_TaiKhoan.Text, textBox2_MatKhau.Text, textBox1_Gmail.Text))
                {
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dangnhap dangnhap = new Dangnhap();
                    dangnhap.Show();
                }
                
            } else
            {
                label6_ThongBaoTrungTK.Visible = true;
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
                System.Windows.Forms.Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}