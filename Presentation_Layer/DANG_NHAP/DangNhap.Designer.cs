namespace Presentation_Layer
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.pnl_dangNhap_dangNhap = new System.Windows.Forms.Panel();
            this.cbb_dangNhap_dangNhap = new System.Windows.Forms.ComboBox();
            this.btn_dangNhap_dangNhap = new Krypton.Toolkit.KryptonButton();
            this.txt_dangNhap_matKhau = new Krypton.Toolkit.KryptonTextBox();
            this.txt_dangNhap_tenDangNhap = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dangNhap_dangNhapDuoi = new Krypton.Toolkit.KryptonButton();
            this.btn_dangNhap_dangKyDuoi = new Krypton.Toolkit.KryptonButton();
            this.btn_dangNhap_dangNhapTren = new Krypton.Toolkit.KryptonButton();
            this.btn_dangNhap_dangKyTren = new Krypton.Toolkit.KryptonButton();
            this.pnl_dangNhap_dangKy = new System.Windows.Forms.Panel();
            this.pic_dangNhap_admin = new System.Windows.Forms.PictureBox();
            this.pic_dangNhap_khachHang = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_dangNhap_nhanVien = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_dangNhap_dangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_dangNhap_dangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dangNhap_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dangNhap_khachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dangNhap_nhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_dangNhap_dangNhap
            // 
            this.pnl_dangNhap_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.pnl_dangNhap_dangNhap.Controls.Add(this.cbb_dangNhap_dangNhap);
            this.pnl_dangNhap_dangNhap.Controls.Add(this.btn_dangNhap_dangNhap);
            this.pnl_dangNhap_dangNhap.Controls.Add(this.txt_dangNhap_matKhau);
            this.pnl_dangNhap_dangNhap.Controls.Add(this.txt_dangNhap_tenDangNhap);
            this.pnl_dangNhap_dangNhap.Location = new System.Drawing.Point(3, 3);
            this.pnl_dangNhap_dangNhap.Name = "pnl_dangNhap_dangNhap";
            this.pnl_dangNhap_dangNhap.Size = new System.Drawing.Size(452, 419);
            this.pnl_dangNhap_dangNhap.TabIndex = 1;
            // 
            // cbb_dangNhap_dangNhap
            // 
            this.cbb_dangNhap_dangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_dangNhap_dangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dangNhap_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_dangNhap_dangNhap.ForeColor = System.Drawing.Color.Gray;
            this.cbb_dangNhap_dangNhap.FormattingEnabled = true;
            this.cbb_dangNhap_dangNhap.Items.AddRange(new object[] {
            "Admin",
            "Khách hàng",
            "Nhân viên"});
            this.cbb_dangNhap_dangNhap.Location = new System.Drawing.Point(63, 221);
            this.cbb_dangNhap_dangNhap.Name = "cbb_dangNhap_dangNhap";
            this.cbb_dangNhap_dangNhap.Size = new System.Drawing.Size(327, 26);
            this.cbb_dangNhap_dangNhap.TabIndex = 3;
            // 
            // btn_dangNhap_dangNhap
            // 
            this.btn_dangNhap_dangNhap.Location = new System.Drawing.Point(63, 336);
            this.btn_dangNhap_dangNhap.Name = "btn_dangNhap_dangNhap";
            this.btn_dangNhap_dangNhap.Size = new System.Drawing.Size(327, 49);
            this.btn_dangNhap_dangNhap.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap_dangNhap.StateCommon.Back.Image")));
            this.btn_dangNhap_dangNhap.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_dangNhap_dangNhap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangNhap_dangNhap.TabIndex = 2;
            this.btn_dangNhap_dangNhap.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_dangNhap_dangNhap.Values.Text = "ĐĂNG NHẬP";
            this.btn_dangNhap_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_dangNhap_Click);
            // 
            // txt_dangNhap_matKhau
            // 
            this.txt_dangNhap_matKhau.Location = new System.Drawing.Point(63, 153);
            this.txt_dangNhap_matKhau.Multiline = true;
            this.txt_dangNhap_matKhau.Name = "txt_dangNhap_matKhau";
            this.txt_dangNhap_matKhau.Size = new System.Drawing.Size(327, 51);
            this.txt_dangNhap_matKhau.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_dangNhap_matKhau.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_dangNhap_matKhau.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_dangNhap_matKhau.StateCommon.Border.Rounding = 20F;
            this.txt_dangNhap_matKhau.StateCommon.Border.Width = 1;
            this.txt_dangNhap_matKhau.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_dangNhap_matKhau.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dangNhap_matKhau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_dangNhap_matKhau.TabIndex = 1;
            this.txt_dangNhap_matKhau.Text = "ltcsdl";
            this.txt_dangNhap_matKhau.WordWrap = false;
            // 
            // txt_dangNhap_tenDangNhap
            // 
            this.txt_dangNhap_tenDangNhap.Location = new System.Drawing.Point(63, 86);
            this.txt_dangNhap_tenDangNhap.Multiline = true;
            this.txt_dangNhap_tenDangNhap.Name = "txt_dangNhap_tenDangNhap";
            this.txt_dangNhap_tenDangNhap.Size = new System.Drawing.Size(327, 51);
            this.txt_dangNhap_tenDangNhap.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_dangNhap_tenDangNhap.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_dangNhap_tenDangNhap.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txt_dangNhap_tenDangNhap.StateCommon.Border.Rounding = 20F;
            this.txt_dangNhap_tenDangNhap.StateCommon.Border.Width = 1;
            this.txt_dangNhap_tenDangNhap.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_dangNhap_tenDangNhap.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dangNhap_tenDangNhap.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.txt_dangNhap_tenDangNhap.TabIndex = 0;
            this.txt_dangNhap_tenDangNhap.Text = "kebepo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(673, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(505, 711);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(120, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 95);
            this.label4.TabIndex = 3;
            this.label4.Text = "KEBEPO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dangNhap_dangNhapDuoi
            // 
            this.btn_dangNhap_dangNhapDuoi.Location = new System.Drawing.Point(136, 181);
            this.btn_dangNhap_dangNhapDuoi.Name = "btn_dangNhap_dangNhapDuoi";
            this.btn_dangNhap_dangNhapDuoi.Size = new System.Drawing.Size(149, 46);
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Border.Rounding = 20F;
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangNhapDuoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangNhap_dangNhapDuoi.TabIndex = 5;
            this.btn_dangNhap_dangNhapDuoi.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_dangNhap_dangNhapDuoi.Values.Text = "Đăng Nhập";
            // 
            // btn_dangNhap_dangKyDuoi
            // 
            this.btn_dangNhap_dangKyDuoi.Location = new System.Drawing.Point(322, 181);
            this.btn_dangNhap_dangKyDuoi.Name = "btn_dangNhap_dangKyDuoi";
            this.btn_dangNhap_dangKyDuoi.Size = new System.Drawing.Size(153, 46);
            this.btn_dangNhap_dangKyDuoi.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_dangNhap_dangKyDuoi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangKyDuoi.StateCommon.Border.Rounding = 20F;
            this.btn_dangNhap_dangKyDuoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_dangNhap_dangKyDuoi.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangKyDuoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangNhap_dangKyDuoi.TabIndex = 7;
            this.btn_dangNhap_dangKyDuoi.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_dangNhap_dangKyDuoi.Values.Text = "Đăng Ký";
            // 
            // btn_dangNhap_dangNhapTren
            // 
            this.btn_dangNhap_dangNhapTren.Location = new System.Drawing.Point(136, 181);
            this.btn_dangNhap_dangNhapTren.Name = "btn_dangNhap_dangNhapTren";
            this.btn_dangNhap_dangNhapTren.Size = new System.Drawing.Size(149, 46);
            this.btn_dangNhap_dangNhapTren.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_dangNhap_dangNhapTren.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_dangNhap_dangNhapTren.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangNhapTren.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap_dangNhapTren.StateCommon.Back.Image")));
            this.btn_dangNhap_dangNhapTren.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_dangNhap_dangNhapTren.StateCommon.Border.Rounding = 20F;
            this.btn_dangNhap_dangNhapTren.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.btn_dangNhap_dangNhapTren.StateCommon.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.btn_dangNhap_dangNhapTren.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_dangNhap_dangNhapTren.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_dangNhap_dangNhapTren.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangNhapTren.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangNhap_dangNhapTren.TabIndex = 8;
            this.btn_dangNhap_dangNhapTren.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_dangNhap_dangNhapTren.Values.Text = "Đăng Nhập";
            this.btn_dangNhap_dangNhapTren.Click += new System.EventHandler(this.btn_dangNhap_dangNhapTren_Click);
            // 
            // btn_dangNhap_dangKyTren
            // 
            this.btn_dangNhap_dangKyTren.Location = new System.Drawing.Point(322, 181);
            this.btn_dangNhap_dangKyTren.Name = "btn_dangNhap_dangKyTren";
            this.btn_dangNhap_dangKyTren.Size = new System.Drawing.Size(153, 46);
            this.btn_dangNhap_dangKyTren.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_dangNhap_dangKyTren.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangKyTren.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap_dangKyTren.StateCommon.Back.Image")));
            this.btn_dangNhap_dangKyTren.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_dangNhap_dangKyTren.StateCommon.Border.Rounding = 20F;
            this.btn_dangNhap_dangKyTren.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_dangNhap_dangKyTren.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_dangNhap_dangKyTren.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_dangNhap_dangKyTren.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangNhap_dangKyTren.TabIndex = 8;
            this.btn_dangNhap_dangKyTren.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_dangNhap_dangKyTren.Values.Text = "Đăng Ký";
            this.btn_dangNhap_dangKyTren.Click += new System.EventHandler(this.btn_dangNhap_dangKyTren_Click);
            // 
            // pnl_dangNhap_dangKy
            // 
            this.pnl_dangNhap_dangKy.BackColor = System.Drawing.Color.Transparent;
            this.pnl_dangNhap_dangKy.Controls.Add(this.pnl_dangNhap_dangNhap);
            this.pnl_dangNhap_dangKy.Controls.Add(this.pic_dangNhap_admin);
            this.pnl_dangNhap_dangKy.Controls.Add(this.pic_dangNhap_khachHang);
            this.pnl_dangNhap_dangKy.Controls.Add(this.label5);
            this.pnl_dangNhap_dangKy.Controls.Add(this.label1);
            this.pnl_dangNhap_dangKy.Controls.Add(this.pic_dangNhap_nhanVien);
            this.pnl_dangNhap_dangKy.Controls.Add(this.label2);
            this.pnl_dangNhap_dangKy.Controls.Add(this.label3);
            this.pnl_dangNhap_dangKy.Location = new System.Drawing.Point(82, 264);
            this.pnl_dangNhap_dangKy.Name = "pnl_dangNhap_dangKy";
            this.pnl_dangNhap_dangKy.Size = new System.Drawing.Size(452, 419);
            this.pnl_dangNhap_dangKy.TabIndex = 3;
            // 
            // pic_dangNhap_admin
            // 
            this.pic_dangNhap_admin.Image = ((System.Drawing.Image)(resources.GetObject("pic_dangNhap_admin.Image")));
            this.pic_dangNhap_admin.Location = new System.Drawing.Point(18, 183);
            this.pic_dangNhap_admin.Name = "pic_dangNhap_admin";
            this.pic_dangNhap_admin.Size = new System.Drawing.Size(105, 98);
            this.pic_dangNhap_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_dangNhap_admin.TabIndex = 1;
            this.pic_dangNhap_admin.TabStop = false;
            this.pic_dangNhap_admin.Click += new System.EventHandler(this.pic_dangNhap_admin_Click);
            // 
            // pic_dangNhap_khachHang
            // 
            this.pic_dangNhap_khachHang.Image = ((System.Drawing.Image)(resources.GetObject("pic_dangNhap_khachHang.Image")));
            this.pic_dangNhap_khachHang.Location = new System.Drawing.Point(321, 183);
            this.pic_dangNhap_khachHang.Name = "pic_dangNhap_khachHang";
            this.pic_dangNhap_khachHang.Size = new System.Drawing.Size(105, 98);
            this.pic_dangNhap_khachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_dangNhap_khachHang.TabIndex = 0;
            this.pic_dangNhap_khachHang.TabStop = false;
            this.pic_dangNhap_khachHang.Click += new System.EventHandler(this.pic_dangNhap_khachHang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(162, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bạn là ai ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // pic_dangNhap_nhanVien
            // 
            this.pic_dangNhap_nhanVien.Image = ((System.Drawing.Image)(resources.GetObject("pic_dangNhap_nhanVien.Image")));
            this.pic_dangNhap_nhanVien.Location = new System.Drawing.Point(167, 183);
            this.pic_dangNhap_nhanVien.Name = "pic_dangNhap_nhanVien";
            this.pic_dangNhap_nhanVien.Size = new System.Drawing.Size(105, 98);
            this.pic_dangNhap_nhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_dangNhap_nhanVien.TabIndex = 2;
            this.pic_dangNhap_nhanVien.TabStop = false;
            this.pic_dangNhap_nhanVien.Click += new System.EventHandler(this.pic_dangNhap_nhanVien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(176, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(330, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách hàng";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 707);
            this.Controls.Add(this.btn_dangNhap_dangNhapDuoi);
            this.Controls.Add(this.btn_dangNhap_dangKyTren);
            this.Controls.Add(this.btn_dangNhap_dangNhapTren);
            this.Controls.Add(this.btn_dangNhap_dangKyDuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_dangNhap_dangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.pnl_dangNhap_dangNhap.ResumeLayout(false);
            this.pnl_dangNhap_dangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_dangNhap_dangKy.ResumeLayout(false);
            this.pnl_dangNhap_dangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dangNhap_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dangNhap_khachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dangNhap_nhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_dangNhap_dangNhap;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btn_dangNhap_dangNhapDuoi;
        private Krypton.Toolkit.KryptonButton btn_dangNhap_dangKyDuoi;
        private Krypton.Toolkit.KryptonButton btn_dangNhap_dangNhapTren;
        private Krypton.Toolkit.KryptonButton btn_dangNhap_dangKyTren;
        private Krypton.Toolkit.KryptonTextBox txt_dangNhap_tenDangNhap;
        private Krypton.Toolkit.KryptonButton btn_dangNhap_dangNhap;
        private Krypton.Toolkit.KryptonTextBox txt_dangNhap_matKhau;
        private System.Windows.Forms.Panel pnl_dangNhap_dangKy;
        private System.Windows.Forms.ComboBox cbb_dangNhap_dangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_dangNhap_nhanVien;
        private System.Windows.Forms.PictureBox pic_dangNhap_admin;
        private System.Windows.Forms.PictureBox pic_dangNhap_khachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}