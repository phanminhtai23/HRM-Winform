﻿namespace FRONTENDPlayer
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Ten = new DevExpress.XtraBars.BarStaticItem();
            this.nghiphep = new DevExpress.XtraBars.BarButtonItem();
            this.PhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.ChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.HopDong = new DevExpress.XtraBars.BarButtonItem();
            this.KhienThuongKyLuat = new DevExpress.XtraBars.BarButtonItem();
            this.DieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.ThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.Thoat_N = new DevExpress.XtraBars.BarButtonItem();
            this.DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.SauLuuDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.KhoiPhucDuLieu = new DevExpress.XtraBars.BarButtonItem();
            this.Thoat_H = new DevExpress.XtraBars.BarButtonItem();
            this.ThoiGian = new DevExpress.XtraBars.BarButtonItem();
            this.NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NhanSu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.DanhMucDungChung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Luong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.Ten,
            this.nghiphep,
            this.PhongBan,
            this.ChucVu,
            this.HopDong,
            this.KhienThuongKyLuat,
            this.DieuChuyen,
            this.ThoiViec,
            this.Thoat_N,
            this.DoiMatKhau,
            this.SauLuuDuLieu,
            this.KhoiPhucDuLieu,
            this.Thoat_H,
            this.ThoiGian,
            this.NhanVien,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.NhanSu,
            this.Luong,
            this.ThongKe,
            this.HeThong});
            this.ribbon.QuickToolbarItemLinks.Add(this.Ten);
            this.ribbon.Size = new System.Drawing.Size(1045, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // Ten
            // 
            this.Ten.Caption = "Đăng xuất";
            this.Ten.Id = 2;
            this.Ten.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Ten.ImageOptions.SvgImage")));
            this.Ten.Name = "Ten";
            this.Ten.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.Ten.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Ten_ItemClick);
            // 
            // nghiphep
            // 
            this.nghiphep.Caption = "Nghi Phép";
            this.nghiphep.Id = 6;
            this.nghiphep.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("nghiphep.ImageOptions.SvgImage")));
            this.nghiphep.Name = "nghiphep";
            // 
            // PhongBan
            // 
            this.PhongBan.Caption = "Phòng Ban";
            this.PhongBan.Id = 7;
            this.PhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PhongBan.ImageOptions.SvgImage")));
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PhongBang_ItemClick);
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "Chức Vụ";
            this.ChucVu.Id = 9;
            this.ChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ChucVu.ImageOptions.SvgImage")));
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChucVu_ItemClick);
            // 
            // HopDong
            // 
            this.HopDong.Caption = "Hợp Đồng";
            this.HopDong.Id = 10;
            this.HopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("HopDong.ImageOptions.SvgImage")));
            this.HopDong.Name = "HopDong";
            this.HopDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HopDong_ItemClick);
            // 
            // KhienThuongKyLuat
            // 
            this.KhienThuongKyLuat.Caption = "Khen Thưởng - Kỹ Luật";
            this.KhienThuongKyLuat.Id = 11;
            this.KhienThuongKyLuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("KhienThuongKyLuat.ImageOptions.SvgImage")));
            this.KhienThuongKyLuat.Name = "KhienThuongKyLuat";
            this.KhienThuongKyLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KhienThuongKyLuat_ItemClick);
            // 
            // DieuChuyen
            // 
            this.DieuChuyen.Caption = "Điều Chuyển";
            this.DieuChuyen.Id = 12;
            this.DieuChuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DieuChuyen.ImageOptions.SvgImage")));
            this.DieuChuyen.Name = "DieuChuyen";
            this.DieuChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DieuChuyen_ItemClick);
            // 
            // ThoiViec
            // 
            this.ThoiViec.Caption = "Thôi Việc";
            this.ThoiViec.Id = 13;
            this.ThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThoiViec.ImageOptions.SvgImage")));
            this.ThoiViec.Name = "ThoiViec";
            this.ThoiViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThoiViec_ItemClick);
            // 
            // Thoat_N
            // 
            this.Thoat_N.Caption = "Thoát";
            this.Thoat_N.Id = 14;
            this.Thoat_N.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Thoat_N.ImageOptions.SvgImage")));
            this.Thoat_N.Name = "Thoat_N";
            this.Thoat_N.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Thoat_ItemClick);
            // 
            // DoiMatKhau
            // 
            this.DoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.DoiMatKhau.Id = 15;
            this.DoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DoiMatKhau.ImageOptions.SvgImage")));
            this.DoiMatKhau.Name = "DoiMatKhau";
            this.DoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DoiMatKhau_ItemClick);
            // 
            // SauLuuDuLieu
            // 
            this.SauLuuDuLieu.Caption = "Sau Lưu Dữ Liệu";
            this.SauLuuDuLieu.Id = 16;
            this.SauLuuDuLieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SauLuuDuLieu.ImageOptions.SvgImage")));
            this.SauLuuDuLieu.Name = "SauLuuDuLieu";
            this.SauLuuDuLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SauLuuDuLieu_ItemClick);
            // 
            // KhoiPhucDuLieu
            // 
            this.KhoiPhucDuLieu.Caption = "Khôi Phục Dữ Liệu";
            this.KhoiPhucDuLieu.Id = 17;
            this.KhoiPhucDuLieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("KhoiPhucDuLieu.ImageOptions.SvgImage")));
            this.KhoiPhucDuLieu.Name = "KhoiPhucDuLieu";
            this.KhoiPhucDuLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KhoiPhucDuLieu_ItemClick);
            // 
            // Thoat_H
            // 
            this.Thoat_H.Caption = "Thoát";
            this.Thoat_H.Id = 18;
            this.Thoat_H.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Thoat_H.ImageOptions.SvgImage")));
            this.Thoat_H.Name = "Thoat_H";
            this.Thoat_H.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Thoat_H_ItemClick);
            // 
            // ThoiGian
            // 
            this.ThoiGian.Caption = "Thời Gian";
            this.ThoiGian.Id = 20;
            this.ThoiGian.Name = "ThoiGian";
            // 
            // NhanVien
            // 
            this.NhanVien.Caption = "Nhân Viên";
            this.NhanVien.Id = 22;
            this.NhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NhanVien.ImageOptions.SvgImage")));
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NhanVien_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.DoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.KhoiPhucDuLieu, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.SauLuuDuLieu, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.Thoat_H, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // NhanSu
            // 
            this.NhanSu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.DanhMucDungChung,
            this.ribbonPageGroup4});
            this.NhanSu.Name = "NhanSu";
            this.NhanSu.Text = "Nhân Sự";
            // 
            // DanhMucDungChung
            // 
            this.DanhMucDungChung.ItemLinks.Add(this.NhanVien);
            this.DanhMucDungChung.ItemLinks.Add(this.ChucVu, true);
            this.DanhMucDungChung.ItemLinks.Add(this.PhongBan, true);
            this.DanhMucDungChung.Name = "DanhMucDungChung";
            this.DanhMucDungChung.Text = "Danh Mục Dùng Chung";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.HopDong);
            this.ribbonPageGroup4.ItemLinks.Add(this.KhienThuongKyLuat, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.DieuChuyen, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.ThoiViec, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.Thoat_N, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nghiệp Vụ";
            // 
            // Luong
            // 
            this.Luong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.Luong.Name = "Luong";
            this.Luong.Text = "Lương";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 603);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1045, 30);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 23;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ThongKe
            // 
            this.ThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Text = "Thống Kê";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 633);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "TrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "TrangChu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage NhanSu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DanhMucDungChung;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage Luong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarStaticItem Ten;
        private DevExpress.XtraBars.BarButtonItem nghiphep;
        private DevExpress.XtraBars.BarButtonItem PhongBan;
        private DevExpress.XtraBars.BarButtonItem ChucVu;
        private DevExpress.XtraBars.BarButtonItem HopDong;
        private DevExpress.XtraBars.BarButtonItem KhienThuongKyLuat;
        private DevExpress.XtraBars.BarButtonItem DieuChuyen;
        private DevExpress.XtraBars.BarButtonItem ThoiViec;
        private DevExpress.XtraBars.BarButtonItem Thoat_N;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem DoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem SauLuuDuLieu;
        private DevExpress.XtraBars.BarButtonItem KhoiPhucDuLieu;
        private DevExpress.XtraBars.BarButtonItem Thoat_H;
        private DevExpress.XtraBars.BarButtonItem ThoiGian;
        private DevExpress.XtraBars.BarButtonItem NhanVien;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}