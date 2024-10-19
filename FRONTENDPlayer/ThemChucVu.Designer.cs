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
            this.lable_MaChuVu = new DevExpress.XtraEditors.LabelControl();
            this.label_TenChucVu = new DevExpress.XtraEditors.LabelControl();
            this.label_HeSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MaChucVu = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_TenChucVu = new DevExpress.XtraEditors.TextEdit();
            this.comboBox_HeSoLuong = new System.Windows.Forms.ComboBox();
            this.button_HuyThemChucVu = new System.Windows.Forms.Button();
            this.button_LuuThemChucVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenChucVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lable_MaChuVu
            // 
            this.lable_MaChuVu.Location = new System.Drawing.Point(32, 34);
            this.lable_MaChuVu.Margin = new System.Windows.Forms.Padding(4);
            this.lable_MaChuVu.Name = "lable_MaChuVu";
            this.lable_MaChuVu.Size = new System.Drawing.Size(69, 16);
            this.lable_MaChuVu.TabIndex = 0;
            this.lable_MaChuVu.Text = "Mã Chức Vụ";
            // 
            // label_TenChucVu
            // 
            this.label_TenChucVu.Location = new System.Drawing.Point(28, 65);
            this.label_TenChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.label_TenChucVu.Name = "label_TenChucVu";
            this.label_TenChucVu.Size = new System.Drawing.Size(74, 16);
            this.label_TenChucVu.TabIndex = 1;
            this.label_TenChucVu.Text = "Tên Chức Vụ";
            // 
            // label_HeSoLuong
            // 
            this.label_HeSoLuong.Location = new System.Drawing.Point(28, 95);
            this.label_HeSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.label_HeSoLuong.Name = "label_HeSoLuong";
            this.label_HeSoLuong.Size = new System.Drawing.Size(73, 16);
            this.label_HeSoLuong.TabIndex = 2;
            this.label_HeSoLuong.Text = "Hệ Số Lương";
            // 
            // textEdit_MaChucVu
            // 
            this.textEdit_MaChucVu.Location = new System.Drawing.Point(115, 31);
            this.textEdit_MaChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit_MaChucVu.Name = "textEdit_MaChucVu";
            this.textEdit_MaChucVu.Size = new System.Drawing.Size(157, 23);
            this.textEdit_MaChucVu.TabIndex = 3;
            this.textEdit_MaChucVu.EditValueChanged += new System.EventHandler(this.textEdit_MaChucVu_EditValueChanged);
            // 
            // textEdit_TenChucVu
            // 
            this.textEdit_TenChucVu.Location = new System.Drawing.Point(115, 62);
            this.textEdit_TenChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit_TenChucVu.Name = "textEdit_TenChucVu";
            this.textEdit_TenChucVu.Size = new System.Drawing.Size(303, 23);
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
            "5.00"});
            this.comboBox_HeSoLuong.Location = new System.Drawing.Point(115, 92);
            this.comboBox_HeSoLuong.Name = "comboBox_HeSoLuong";
            this.comboBox_HeSoLuong.Size = new System.Drawing.Size(121, 24);
            this.comboBox_HeSoLuong.TabIndex = 5;
            this.comboBox_HeSoLuong.SelectedIndexChanged += new System.EventHandler(this.comboBox_HeSoLuong_SelectedIndexChanged);
            // 
            // button_HuyThemChucVu
            // 
            this.button_HuyThemChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_HuyThemChucVu.Location = new System.Drawing.Point(359, 121);
            this.button_HuyThemChucVu.Name = "button_HuyThemChucVu";
            this.button_HuyThemChucVu.Size = new System.Drawing.Size(83, 37);
            this.button_HuyThemChucVu.TabIndex = 6;
            this.button_HuyThemChucVu.Text = "Hủy";
            this.button_HuyThemChucVu.UseVisualStyleBackColor = false;
            this.button_HuyThemChucVu.Click += new System.EventHandler(this.button_DongThemChucVu_Click);
            // 
            // button_LuuThemChucVu
            // 
            this.button_LuuThemChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_LuuThemChucVu.Location = new System.Drawing.Point(448, 120);
            this.button_LuuThemChucVu.Name = "button_LuuThemChucVu";
            this.button_LuuThemChucVu.Size = new System.Drawing.Size(83, 37);
            this.button_LuuThemChucVu.TabIndex = 9;
            this.button_LuuThemChucVu.Text = "Lưu";
            this.button_LuuThemChucVu.UseVisualStyleBackColor = false;
            this.button_LuuThemChucVu.Click += new System.EventHandler(this.button_LuuThemChucVu_Click);
            // 
            // ThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 169);
            this.Controls.Add(this.button_LuuThemChucVu);
            this.Controls.Add(this.button_HuyThemChucVu);
            this.Controls.Add(this.comboBox_HeSoLuong);
            this.Controls.Add(this.textEdit_TenChucVu);
            this.Controls.Add(this.textEdit_MaChucVu);
            this.Controls.Add(this.label_HeSoLuong);
            this.Controls.Add(this.label_TenChucVu);
            this.Controls.Add(this.lable_MaChuVu);
            this.Name = "ThemChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Chức Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenChucVu.Properties)).EndInit();
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
        private System.Windows.Forms.Button button_HuyThemChucVu;
        private System.Windows.Forms.Button button_LuuThemChucVu;
    }
}