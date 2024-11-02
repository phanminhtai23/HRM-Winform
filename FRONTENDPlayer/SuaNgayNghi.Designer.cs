namespace FRONTENDPlayer
{
    partial class SuaNgayNghi
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
            this.lookUpEdit1_MaNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.comboBoxEdit_SoNgayNghi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5_CanhBao = new System.Windows.Forms.Label();
            this.dateEdit1_ThangNghi = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton2_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.textBox3_GhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1_MaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_SoNgayNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_ThangNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_ThangNghi.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1_MaNhanVien
            // 
            this.lookUpEdit1_MaNhanVien.Location = new System.Drawing.Point(187, 47);
            this.lookUpEdit1_MaNhanVien.Name = "lookUpEdit1_MaNhanVien";
            this.lookUpEdit1_MaNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1_MaNhanVien.Properties.DataSource = this.nhanVienBindingSource;
            this.lookUpEdit1_MaNhanVien.Properties.DisplayMember = "MaNhanVien";
            this.lookUpEdit1_MaNhanVien.Properties.ReadOnly = true;
            this.lookUpEdit1_MaNhanVien.Properties.ValueMember = "MaNhanVien";
            this.lookUpEdit1_MaNhanVien.Size = new System.Drawing.Size(158, 34);
            this.lookUpEdit1_MaNhanVien.TabIndex = 31;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEdit_SoNgayNghi
            // 
            this.comboBoxEdit_SoNgayNghi.Location = new System.Drawing.Point(187, 158);
            this.comboBoxEdit_SoNgayNghi.Name = "comboBoxEdit_SoNgayNghi";
            this.comboBoxEdit_SoNgayNghi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_SoNgayNghi.Size = new System.Drawing.Size(158, 34);
            this.comboBoxEdit_SoNgayNghi.TabIndex = 21;
            // 
            // label5_CanhBao
            // 
            this.label5_CanhBao.AutoSize = true;
            this.label5_CanhBao.ForeColor = System.Drawing.Color.Red;
            this.label5_CanhBao.Location = new System.Drawing.Point(360, 110);
            this.label5_CanhBao.Name = "label5_CanhBao";
            this.label5_CanhBao.Size = new System.Drawing.Size(164, 16);
            this.label5_CanhBao.TabIndex = 30;
            this.label5_CanhBao.Text = "Vui lòng chọn số ngày nghỉ.";
            this.label5_CanhBao.Visible = false;
            // 
            // dateEdit1_ThangNghi
            // 
            this.dateEdit1_ThangNghi.EditValue = null;
            this.dateEdit1_ThangNghi.Location = new System.Drawing.Point(187, 101);
            this.dateEdit1_ThangNghi.Name = "dateEdit1_ThangNghi";
            this.dateEdit1_ThangNghi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1_ThangNghi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1_ThangNghi.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEdit1_ThangNghi.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dateEdit1_ThangNghi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1_ThangNghi.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dateEdit1_ThangNghi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1_ThangNghi.Properties.MaskSettings.Set("mask", "MM/yyyy");
            this.dateEdit1_ThangNghi.Properties.ReadOnly = true;
            this.dateEdit1_ThangNghi.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dateEdit1_ThangNghi.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1_ThangNghi.Size = new System.Drawing.Size(158, 34);
            this.dateEdit1_ThangNghi.TabIndex = 29;
            this.dateEdit1_ThangNghi.EditValueChanged += new System.EventHandler(this.dateEdit1_ThangNghi_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(78, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã Nhân viên:";
            // 
            // simpleButton2_XacNhan
            // 
            this.simpleButton2_XacNhan.Appearance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2_XacNhan.Appearance.Options.UseFont = true;
            this.simpleButton2_XacNhan.Location = new System.Drawing.Point(448, 354);
            this.simpleButton2_XacNhan.Name = "simpleButton2_XacNhan";
            this.simpleButton2_XacNhan.Size = new System.Drawing.Size(87, 36);
            this.simpleButton2_XacNhan.TabIndex = 27;
            this.simpleButton2_XacNhan.Text = "Xác nhận";
            this.simpleButton2_XacNhan.Click += new System.EventHandler(this.simpleButton2_XacNhan_Click);
            // 
            // simpleButton1_Huy
            // 
            this.simpleButton1_Huy.Appearance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1_Huy.Appearance.Options.UseFont = true;
            this.simpleButton1_Huy.Location = new System.Drawing.Point(343, 354);
            this.simpleButton1_Huy.Name = "simpleButton1_Huy";
            this.simpleButton1_Huy.Size = new System.Drawing.Size(87, 36);
            this.simpleButton1_Huy.TabIndex = 26;
            this.simpleButton1_Huy.Text = "Hủy";
            this.simpleButton1_Huy.Click += new System.EventHandler(this.simpleButton1_Huy_Click);
            // 
            // textBox3_GhiChu
            // 
            this.textBox3_GhiChu.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox3_GhiChu.Location = new System.Drawing.Point(187, 219);
            this.textBox3_GhiChu.Multiline = true;
            this.textBox3_GhiChu.Name = "textBox3_GhiChu";
            this.textBox3_GhiChu.Size = new System.Drawing.Size(301, 111);
            this.textBox3_GhiChu.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(109, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ghi Chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(76, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số Ngày Nghỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(91, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tháng Nghỉ:";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // SuaNgayNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 436);
            this.Controls.Add(this.lookUpEdit1_MaNhanVien);
            this.Controls.Add(this.comboBoxEdit_SoNgayNghi);
            this.Controls.Add(this.label5_CanhBao);
            this.Controls.Add(this.dateEdit1_ThangNghi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton2_XacNhan);
            this.Controls.Add(this.simpleButton1_Huy);
            this.Controls.Add(this.textBox3_GhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaNgayNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Ngày Nghỉ";
            this.Load += new System.EventHandler(this.SuaNgayNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1_MaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_SoNgayNghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_ThangNghi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_ThangNghi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1_MaNhanVien;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_SoNgayNghi;
        private System.Windows.Forms.Label label5_CanhBao;
        private DevExpress.XtraEditors.DateEdit dateEdit1_ThangNghi;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2_XacNhan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1_Huy;
        private System.Windows.Forms.TextBox textBox3_GhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private HRMDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}