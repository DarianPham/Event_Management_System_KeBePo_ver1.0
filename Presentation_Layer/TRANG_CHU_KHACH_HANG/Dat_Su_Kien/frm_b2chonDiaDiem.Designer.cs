namespace Presentation_Layer.TRANG_CHU_KHACH_HANG.Dat_Su_Kien
{
    partial class frm_b2chonDiaDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_doiTac = new System.Windows.Forms.DataGridView();
            this.dgv_dichVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_dichVu_suKien = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ccb_loaiDichVu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVu_suKien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Một số nhà cung cấp";
            // 
            // dgv_doiTac
            // 
            this.dgv_doiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doiTac.Location = new System.Drawing.Point(12, 161);
            this.dgv_doiTac.Name = "dgv_doiTac";
            this.dgv_doiTac.RowHeadersWidth = 51;
            this.dgv_doiTac.RowTemplate.Height = 24;
            this.dgv_doiTac.Size = new System.Drawing.Size(1000, 246);
            this.dgv_doiTac.TabIndex = 12;
            this.dgv_doiTac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doiTac_CellContentClick);
            // 
            // dgv_dichVu
            // 
            this.dgv_dichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichVu.Location = new System.Drawing.Point(16, 456);
            this.dgv_dichVu.Name = "dgv_dichVu";
            this.dgv_dichVu.RowHeadersWidth = 51;
            this.dgv_dichVu.RowTemplate.Height = 24;
            this.dgv_dichVu.Size = new System.Drawing.Size(996, 284);
            this.dgv_dichVu.TabIndex = 13;
            this.dgv_dichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dichVu_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Danh sách dịch vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1613, 755);
            this.panel1.TabIndex = 21;
            // 
            // dgv_dichVu_suKien
            // 
            this.dgv_dichVu_suKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichVu_suKien.Location = new System.Drawing.Point(1072, 161);
            this.dgv_dichVu_suKien.Name = "dgv_dichVu_suKien";
            this.dgv_dichVu_suKien.RowHeadersWidth = 51;
            this.dgv_dichVu_suKien.RowTemplate.Height = 24;
            this.dgv_dichVu_suKien.Size = new System.Drawing.Size(529, 579);
            this.dgv_dichVu_suKien.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(1068, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Danh sách dịch vụ bạn chọn";
            // 
            // ccb_loaiDichVu
            // 
            this.ccb_loaiDichVu.FormattingEnabled = true;
            this.ccb_loaiDichVu.Location = new System.Drawing.Point(210, 34);
            this.ccb_loaiDichVu.Name = "ccb_loaiDichVu";
            this.ccb_loaiDichVu.Size = new System.Drawing.Size(423, 24);
            this.ccb_loaiDichVu.TabIndex = 21;
            this.ccb_loaiDichVu.SelectedIndexChanged += new System.EventHandler(this.ccb_loaiDichVu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(20, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Chọn dịch vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ccb_loaiDichVu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgv_dichVu_suKien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_doiTac);
            this.panel2.Controls.Add(this.dgv_dichVu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1613, 755);
            this.panel2.TabIndex = 24;
            // 
            // frm_b2chonDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 755);
            this.Controls.Add(this.panel1);
            this.Name = "frm_b2chonDiaDiem";
            this.Text = "frm_b2chonDiaDiem";
            this.Load += new System.EventHandler(this.frm_b2chonDiaDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVu_suKien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_doiTac;
        private System.Windows.Forms.DataGridView dgv_dichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_dichVu_suKien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ccb_loaiDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}