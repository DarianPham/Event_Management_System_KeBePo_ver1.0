namespace Presentation_Layer
{
    partial class frm_dangNhap_khachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangNhap_khachHang));
            this.txt_khachHang_tenDangNhap = new Krypton.Toolkit.KryptonTextBox();
            this.btn_dangNhap_dangKy = new Krypton.Toolkit.KryptonButton();
            this.txt_khachHang_matKhau = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_khachHang_hoVaTen = new Krypton.Toolkit.KryptonTextBox();
            this.txt_khachHang_diaChi = new Krypton.Toolkit.KryptonTextBox();
            this.txt_khachHang_email = new Krypton.Toolkit.KryptonTextBox();
            this.txt_khachHang_soDienThoai = new Krypton.Toolkit.KryptonTextBox();
            this.dtp_dangKy_sinhNhat = new System.Windows.Forms.DateTimePicker();
            this.rdo_dangKy_gtNam = new System.Windows.Forms.RadioButton();
            this.rdo_dangKy_gtNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_khachHang_tenDangNhap
            // 
            this.txt_khachHang_tenDangNhap.Location = new System.Drawing.Point(55, 234);
            this.txt_khachHang_tenDangNhap.Multiline = true;
            this.txt_khachHang_tenDangNhap.Name = "txt_khachHang_tenDangNhap";
            this.txt_khachHang_tenDangNhap.Size = new System.Drawing.Size(327, 51);
            this.txt_khachHang_tenDangNhap.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_tenDangNhap.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_tenDangNhap.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_tenDangNhap.StateCommon.Border.Rounding = 20F;
            this.txt_khachHang_tenDangNhap.StateCommon.Border.Width = 1;
            this.txt_khachHang_tenDangNhap.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_khachHang_tenDangNhap.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_khachHang_tenDangNhap.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_khachHang_tenDangNhap.TabIndex = 5;
            this.txt_khachHang_tenDangNhap.Text = "Tên đăng nhập";
            // 
            // btn_dangNhap_dangKy
            // 
            this.btn_dangNhap_dangKy.Location = new System.Drawing.Point(222, 538);
            this.btn_dangNhap_dangKy.Name = "btn_dangNhap_dangKy";
            this.btn_dangNhap_dangKy.Size = new System.Drawing.Size(327, 49);
            this.btn_dangNhap_dangKy.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap_dangKy.StateCommon.Back.Image")));
            this.btn_dangNhap_dangKy.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_dangNhap_dangKy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangNhap_dangKy.TabIndex = 7;
            this.btn_dangNhap_dangKy.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_dangNhap_dangKy.Values.Text = "ĐĂNG KÝ";
            this.btn_dangNhap_dangKy.Click += new System.EventHandler(this.btn_dangNhap_dangKy_Click);
            // 
            // txt_khachHang_matKhau
            // 
            this.txt_khachHang_matKhau.Location = new System.Drawing.Point(427, 238);
            this.txt_khachHang_matKhau.Multiline = true;
            this.txt_khachHang_matKhau.Name = "txt_khachHang_matKhau";
            this.txt_khachHang_matKhau.Size = new System.Drawing.Size(327, 47);
            this.txt_khachHang_matKhau.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_matKhau.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_matKhau.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_matKhau.StateCommon.Border.Rounding = 20F;
            this.txt_khachHang_matKhau.StateCommon.Border.Width = 1;
            this.txt_khachHang_matKhau.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_khachHang_matKhau.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_khachHang_matKhau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_khachHang_matKhau.TabIndex = 6;
            this.txt_khachHang_matKhau.Text = "Mật khẩu";
            this.txt_khachHang_matKhau.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_khachHang_hoVaTen
            // 
            this.txt_khachHang_hoVaTen.Location = new System.Drawing.Point(55, 301);
            this.txt_khachHang_hoVaTen.Multiline = true;
            this.txt_khachHang_hoVaTen.Name = "txt_khachHang_hoVaTen";
            this.txt_khachHang_hoVaTen.Size = new System.Drawing.Size(327, 47);
            this.txt_khachHang_hoVaTen.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_hoVaTen.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_hoVaTen.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_hoVaTen.StateCommon.Border.Rounding = 20F;
            this.txt_khachHang_hoVaTen.StateCommon.Border.Width = 1;
            this.txt_khachHang_hoVaTen.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_khachHang_hoVaTen.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_khachHang_hoVaTen.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_khachHang_hoVaTen.TabIndex = 8;
            this.txt_khachHang_hoVaTen.Text = "Họ và tên";
            this.txt_khachHang_hoVaTen.WordWrap = false;
            // 
            // txt_khachHang_diaChi
            // 
            this.txt_khachHang_diaChi.Location = new System.Drawing.Point(427, 382);
            this.txt_khachHang_diaChi.Multiline = true;
            this.txt_khachHang_diaChi.Name = "txt_khachHang_diaChi";
            this.txt_khachHang_diaChi.Size = new System.Drawing.Size(327, 47);
            this.txt_khachHang_diaChi.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_diaChi.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_diaChi.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_diaChi.StateCommon.Border.Rounding = 20F;
            this.txt_khachHang_diaChi.StateCommon.Border.Width = 1;
            this.txt_khachHang_diaChi.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_khachHang_diaChi.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_khachHang_diaChi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_khachHang_diaChi.TabIndex = 9;
            this.txt_khachHang_diaChi.Text = "Địa chỉ";
            this.txt_khachHang_diaChi.WordWrap = false;
            // 
            // txt_khachHang_email
            // 
            this.txt_khachHang_email.Location = new System.Drawing.Point(427, 301);
            this.txt_khachHang_email.Multiline = true;
            this.txt_khachHang_email.Name = "txt_khachHang_email";
            this.txt_khachHang_email.Size = new System.Drawing.Size(327, 47);
            this.txt_khachHang_email.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_email.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_email.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_email.StateCommon.Border.Rounding = 20F;
            this.txt_khachHang_email.StateCommon.Border.Width = 1;
            this.txt_khachHang_email.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_khachHang_email.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_khachHang_email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_khachHang_email.TabIndex = 10;
            this.txt_khachHang_email.Text = "Email";
            this.txt_khachHang_email.WordWrap = false;
            // 
            // txt_khachHang_soDienThoai
            // 
            this.txt_khachHang_soDienThoai.Location = new System.Drawing.Point(427, 445);
            this.txt_khachHang_soDienThoai.Multiline = true;
            this.txt_khachHang_soDienThoai.Name = "txt_khachHang_soDienThoai";
            this.txt_khachHang_soDienThoai.Size = new System.Drawing.Size(327, 47);
            this.txt_khachHang_soDienThoai.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_soDienThoai.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_soDienThoai.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_khachHang_soDienThoai.StateCommon.Border.Rounding = 20F;
            this.txt_khachHang_soDienThoai.StateCommon.Border.Width = 1;
            this.txt_khachHang_soDienThoai.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_khachHang_soDienThoai.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_khachHang_soDienThoai.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_khachHang_soDienThoai.TabIndex = 11;
            this.txt_khachHang_soDienThoai.Text = "Số điện thoại";
            this.txt_khachHang_soDienThoai.WordWrap = false;
            // 
            // dtp_dangKy_sinhNhat
            // 
            this.dtp_dangKy_sinhNhat.CustomFormat = "dd/MM/yyyy";
            this.dtp_dangKy_sinhNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_dangKy_sinhNhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dangKy_sinhNhat.Location = new System.Drawing.Point(55, 382);
            this.dtp_dangKy_sinhNhat.MaxDate = new System.DateTime(2025, 12, 4, 0, 0, 0, 0);
            this.dtp_dangKy_sinhNhat.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_dangKy_sinhNhat.Name = "dtp_dangKy_sinhNhat";
            this.dtp_dangKy_sinhNhat.Size = new System.Drawing.Size(253, 24);
            this.dtp_dangKy_sinhNhat.TabIndex = 17;
            // 
            // rdo_dangKy_gtNam
            // 
            this.rdo_dangKy_gtNam.AutoSize = true;
            this.rdo_dangKy_gtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_dangKy_gtNam.Location = new System.Drawing.Point(55, 445);
            this.rdo_dangKy_gtNam.Name = "rdo_dangKy_gtNam";
            this.rdo_dangKy_gtNam.Size = new System.Drawing.Size(61, 22);
            this.rdo_dangKy_gtNam.TabIndex = 18;
            this.rdo_dangKy_gtNam.TabStop = true;
            this.rdo_dangKy_gtNam.Text = "Nam";
            this.rdo_dangKy_gtNam.UseVisualStyleBackColor = true;
            // 
            // rdo_dangKy_gtNu
            // 
            this.rdo_dangKy_gtNu.AutoSize = true;
            this.rdo_dangKy_gtNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_dangKy_gtNu.Location = new System.Drawing.Point(152, 445);
            this.rdo_dangKy_gtNu.Name = "rdo_dangKy_gtNu";
            this.rdo_dangKy_gtNu.Size = new System.Drawing.Size(48, 22);
            this.rdo_dangKy_gtNu.TabIndex = 19;
            this.rdo_dangKy_gtNu.TabStop = true;
            this.rdo_dangKy_gtNu.Text = "Nữ";
            this.rdo_dangKy_gtNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(52, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sinh nhật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(52, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giới tính";
            // 
            // frm_dangNhap_khachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 622);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_dangKy_gtNu);
            this.Controls.Add(this.rdo_dangKy_gtNam);
            this.Controls.Add(this.dtp_dangKy_sinhNhat);
            this.Controls.Add(this.txt_khachHang_soDienThoai);
            this.Controls.Add(this.txt_khachHang_email);
            this.Controls.Add(this.txt_khachHang_diaChi);
            this.Controls.Add(this.txt_khachHang_hoVaTen);
            this.Controls.Add(this.txt_khachHang_tenDangNhap);
            this.Controls.Add(this.btn_dangNhap_dangKy);
            this.Controls.Add(this.txt_khachHang_matKhau);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dangNhap_khachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dangNhap_nhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox txt_khachHang_tenDangNhap;
        private Krypton.Toolkit.KryptonButton btn_dangNhap_dangKy;
        private Krypton.Toolkit.KryptonTextBox txt_khachHang_matKhau;
        private Krypton.Toolkit.KryptonTextBox txt_khachHang_hoVaTen;
        private Krypton.Toolkit.KryptonTextBox txt_khachHang_diaChi;
        private Krypton.Toolkit.KryptonTextBox txt_khachHang_email;
        private Krypton.Toolkit.KryptonTextBox txt_khachHang_soDienThoai;
        private System.Windows.Forms.DateTimePicker dtp_dangKy_sinhNhat;
        private System.Windows.Forms.RadioButton rdo_dangKy_gtNam;
        private System.Windows.Forms.RadioButton rdo_dangKy_gtNu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}