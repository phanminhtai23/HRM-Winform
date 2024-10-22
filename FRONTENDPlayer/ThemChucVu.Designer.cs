namespace FRONTENDPlayer
{
    partial class ThemChucVu
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
            this.lable_MaChuVu = new DevExpress.XtraEditors.LabelControl();
            this.label_TenChucVu = new DevExpress.XtraEditors.LabelControl();
            this.label_HeSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MaChucVu = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_TenChucVu = new DevExpress.XtraEditors.TextEdit();
            this.comboBox_HeSoLuong = new System.Windows.Forms.ComboBox();
            this.dMChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.dM_ChucVuTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_ChucVuTableAdapter();
            this.simpleButton_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Huy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lable_MaChuVu
            // 
            this.lable_MaChuVu.Location = new System.Drawing.Point(34, 32);
            this.lable_MaChuVu.Margin = new System.Windows.Forms.Padding(5);
            this.lable_MaChuVu.Name = "lable_MaChuVu";
            this.lable_MaChuVu.Size = new System.Drawing.Size(69, 16);
            this.lable_MaChuVu.TabIndex = 0;
            this.lable_MaChuVu.Text = "Mã Chức Vụ";
            // 
            // label_TenChucVu
            // 
            this.label_TenChucVu.Location = new System.Drawing.Point(29, 76);
            this.label_TenChucVu.Margin = new System.Windows.Forms.Padding(5);
            this.label_TenChucVu.Name = "label_TenChucVu";
            this.label_TenChucVu.Size = new System.Drawing.Size(74, 16);
            this.label_TenChucVu.TabIndex = 1;
            this.label_TenChucVu.Text = "Tên Chức Vụ";
            // 
            // label_HeSoLuong
            // 
            this.label_HeSoLuong.Location = new System.Drawing.Point(30, 113);
            this.label_HeSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.label_HeSoLuong.Name = "label_HeSoLuong";
            this.label_HeSoLuong.Size = new System.Drawing.Size(73, 16);
            this.label_HeSoLuong.TabIndex = 2;
            this.label_HeSoLuong.Text = "Hệ Số Lương";
            // 
            // textEdit_MaChucVu
            // 
            this.textEdit_MaChucVu.Location = new System.Drawing.Point(112, 23);
            this.textEdit_MaChucVu.Margin = new System.Windows.Forms.Padding(5);
            this.textEdit_MaChucVu.Name = "textEdit_MaChucVu";
            this.textEdit_MaChucVu.Size = new System.Drawing.Size(154, 34);
            this.textEdit_MaChucVu.TabIndex = 3;
            this.textEdit_MaChucVu.EditValueChanged += new System.EventHandler(this.textEdit_MaChucVu_EditValueChanged);
            // 
            // textEdit_TenChucVu
            // 
            this.textEdit_TenChucVu.Location = new System.Drawing.Point(112, 67);
            this.textEdit_TenChucVu.Margin = new System.Windows.Forms.Padding(5);
            this.textEdit_TenChucVu.Name = "textEdit_TenChucVu";
            this.textEdit_TenChucVu.Size = new System.Drawing.Size(251, 34);
            this.textEdit_TenChucVu.TabIndex = 4;
            this.textEdit_TenChucVu.EditValueChanged += new System.EventHandler(this.textEdit_TenChucVu_EditValueChanged);
            // 
            // comboBox_HeSoLuong
            // 
            this.comboBox_HeSoLuong.FormattingEnabled = true;
            this.comboBox_HeSoLuong.Items.AddRange(new object[] {
            "3.00",
            "3.50",
            "4.00",
            "4.50",
            "5.00",
            "5.50",
            "6.00"});
            this.comboBox_HeSoLuong.Location = new System.Drawing.Point(112, 113);
            this.comboBox_HeSoLuong.Name = "comboBox_HeSoLuong";
            this.comboBox_HeSoLuong.Size = new System.Drawing.Size(121, 24);
            this.comboBox_HeSoLuong.TabIndex = 5;
            this.comboBox_HeSoLuong.SelectedIndexChanged += new System.EventHandler(this.comboBox_HeSoLuong_SelectedIndexChanged);
            // 
            // dMChucVuBindingSource
            // 
            this.dMChucVuBindingSource.DataMember = "DM_ChucVu";
            this.dMChucVuBindingSource.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_ChucVuTableAdapter
            // 
            this.dM_ChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton_Luu
            // 
            this.simpleButton_Luu.Location = new System.Drawing.Point(458, 139);
            this.simpleButton_Luu.Name = "simpleButton_Luu";
            this.simpleButton_Luu.Size = new System.Drawing.Size(94, 29);
            this.simpleButton_Luu.TabIndex = 10;
            this.simpleButton_Luu.Text = "Lưu";
            this.simpleButton_Luu.Click += new System.EventHandler(this.simpleButton_Luu_Click);
            // 
            // simpleButton_Huy
            // 
            this.simpleButton_Huy.Location = new System.Drawing.Point(358, 139);
            this.simpleButton_Huy.Name = "simpleButton_Huy";
            this.simpleButton_Huy.Size = new System.Drawing.Size(94, 29);
            this.simpleButton_Huy.TabIndex = 11;
            this.simpleButton_Huy.Text = "Hủy";
            this.simpleButton_Huy.Click += new System.EventHandler(this.simpleButton_Huy_Click);
            // 
            // ThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 180);
            this.Controls.Add(this.simpleButton_Huy);
            this.Controls.Add(this.simpleButton_Luu);
            this.Controls.Add(this.comboBox_HeSoLuong);
            this.Controls.Add(this.textEdit_TenChucVu);
            this.Controls.Add(this.textEdit_MaChucVu);
            this.Controls.Add(this.label_HeSoLuong);
            this.Controls.Add(this.label_TenChucVu);
            this.Controls.Add(this.lable_MaChuVu);
            this.Name = "ThemChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Chức Vụ";
            this.Load += new System.EventHandler(this.ThemChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lable_MaChuVu;
        private DevExpress.XtraEditors.LabelControl label_TenChucVu;
        private DevExpress.XtraEditors.LabelControl label_HeSoLuong;
        private DevExpress.XtraEditors.TextEdit textEdit_MaChucVu;
        private DevExpress.XtraEditors.TextEdit textEdit_TenChucVu;
        private System.Windows.Forms.ComboBox comboBox_HeSoLuong;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource dMChucVuBindingSource;
        private HRMDataSetTableAdapters.DM_ChucVuTableAdapter dM_ChucVuTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Luu;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Huy;
    }
}