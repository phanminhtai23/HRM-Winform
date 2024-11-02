using DevExpress.XtraCharts;
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
using static DevExpress.Data.Filtering.Helpers.SubExprHelper;
using LOGICPlayer;
using DevExpress.XtraRichEdit.Model;
using System.Runtime.InteropServices.ComTypes;

namespace FRONTENDPlayer
{
    public partial class ChonThongKe : DevExpress.XtraEditors.XtraForm
    {
        public ChonThongKe()
        {
            InitializeComponent();
        }

        private void ChonThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.hRMDataSet.Luong);
            label3_CanhBao.Visible = false;
            label3_TongLuong.Visible = false;

        }

        private void dateEdit2_DateKetThuc_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_DateBatDau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void simpleButton2_XacNhan_Click_1(object sender, EventArgs e)
        {
            label3_CanhBao.Visible = false;
            label3_TongLuong.Visible = false;
            if (dateEdit1_DateBatDau.EditValue == null || string.IsNullOrEmpty(dateEdit1_DateBatDau.EditValue.ToString()))
            {
                label3_CanhBao.Text = "Vui lòng chọn tháng bắt đầu thống kê.";
                label3_CanhBao.Location = new Point(69, 14);
                label3_CanhBao.Visible = true;
            }
            else if (dateEdit2_DateKetThuc.EditValue == null || string.IsNullOrEmpty(dateEdit2_DateKetThuc.EditValue.ToString()))
            {
                label3_CanhBao.Text = "Vui lòng chọn tháng kết thúc thống kê.";
                label3_CanhBao.Location = new Point(69, 77);
                label3_CanhBao.Visible = true;
            }
            else if (((DateTime)dateEdit1_DateBatDau.EditValue) > DateTime.Now)
            {
                label3_CanhBao.Text = "Tháng không được lớn hơn hiện tại.";
                label3_CanhBao.Location = new Point(69, 14);
                label3_CanhBao.Visible = true;
            }
            else if (((DateTime)dateEdit2_DateKetThuc.EditValue) > DateTime.Now)
            {
                label3_CanhBao.Text = "Tháng không được lớn hơn hiện tại.";
                label3_CanhBao.Location = new Point(69, 77);
                label3_CanhBao.Visible = true;
            }
             else if (((DateTime)dateEdit1_DateBatDau.EditValue) > ((DateTime)dateEdit2_DateKetThuc.EditValue))
            {
                label3_CanhBao.Text = "Tháng kết thúc phải bé hơn tháng bắt đầu.";
                label3_CanhBao.Location = new Point(31, 77);
                label3_CanhBao.Visible = true;
            }
            else
            {
                try
                {
                    ThongKeBackEnd thongKeBackEnd = new ThongKeBackEnd();
                    int TongLuong = thongKeBackEnd.TongLuongNhanVien_ddMMyyy(dateEdit1_DateBatDau.EditValue.ToString(), dateEdit2_DateKetThuc.EditValue.ToString());

                    // Print the values of dateEdit1_DateBatDau and dateEdit2_DateKetThuc
                    //MessageBox.Show($"Ngày bắt đầu: {dateEdit1_DateBatDau.EditValue.ToString()}\nNgày kết thúc: {dateEdit2_DateKetThuc.EditValue.ToString()}", "Thông tin ngày", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (TongLuong == 0)
                    {
                        MessageBox.Show("Không có dữ liệu thống kê trong khoảng thời gian đã chọn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Tạo biểu đồ
                        label3_TongLuong.Text = $"Tổng lương: {TongLuong:N0} VNĐ";
                        label3_TongLuong.Visible = true;
                    }

                    DrawChart(dateEdit1_DateBatDau.EditValue.ToString(), dateEdit2_DateKetThuc.EditValue.ToString());

                }
                catch
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void DrawChart(string startDate, string endDate)
        {
            ThongKeBackEnd thongKeBackEnd = new ThongKeBackEnd();

            // Clear any existing series
            chartControl1.Series.Clear();

            // Create a Series for the bar chart
            Series series = new Series("Tổng lương", ViewType.Bar);

            // Get data and add to series
            var danhSachThang = LayDanhSachThang(startDate, endDate);
            foreach (string thang in danhSachThang)
            {
                int luong = thongKeBackEnd.TongLuongNhanVien_MMyyy(thang, thang);
                series.Points.Add(new SeriesPoint(thang, luong));
            }

            // Add series to the chart
            chartControl1.Series.Add(series);

            // Configure the chart (optional)
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl1.Titles.Clear();
            chartControl1.Titles.Add(new ChartTitle { Text = "Biểu đồ tổng lương theo tháng" });

            // Configure the X-axis labels
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            diagram.AxisX.Label.TextPattern = "{A:MM/yyyy}"; // This sets the label to the argument value in "MM/yyyy" format
            diagram.AxisX.Label.Angle = -45; // Optional: Rotate labels for better readability
            diagram.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            diagram.AxisX.Label.ResolveOverlappingOptions.AllowStagger = true;

            // Set the interval for the X-axis to 1 month
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Month;
            diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.None;
            diagram.AxisX.DateTimeScaleOptions.GridSpacing = 1;


            // Configure the Y-axis labels
            diagram.AxisY.Label.TextPattern = "{V:N0}"; // This sets the label to the value in "N0" format
                                                        // Set the Y-axis title to "VNĐ"
            diagram.AxisY.Title.Text = "VNĐ";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }


        public List<string> LayDanhSachThang(string NgayBatDau, string NgayKetThuc)
        {

            List<string> danhSachThang = new List<string>();

            // Chuyển đổi từ chuỗi dd/MM/yyyy sang DateTime
            DateTime batDau = DateTime.ParseExact(NgayBatDau, "dd/MM/yyyy hh:mm:ss tt", null);
            DateTime ketThuc = DateTime.ParseExact(NgayKetThuc, "dd/MM/yyyy hh:mm:ss tt", null);


            // Khởi tạo biến để lặp qua các tháng
            DateTime thangHienTai = new DateTime(batDau.Year, batDau.Month, 1);

            while (thangHienTai <= ketThuc)
            {
                // Thêm tháng hiện tại vào danh sách dưới định dạng mm/yyyy
                danhSachThang.Add(thangHienTai.ToString("MM/yyyy"));

                // Chuyển sang tháng tiếp theo
                thangHienTai = thangHienTai.AddMonths(1);
            }

            return danhSachThang;
        }

        private void simpleButton1_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}