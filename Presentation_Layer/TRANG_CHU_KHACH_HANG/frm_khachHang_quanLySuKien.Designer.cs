namespace Presentation_Layer.TRANG_CHU_KHACH_HANG
{
    partial class frm_khachHang_quanLySuKien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_suKienDaDat = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_dichVu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_suKien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnl_suKienDaDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suKien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_suKienDaDat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 785);
            this.panel1.TabIndex = 0;
            // 
            // pnl_suKienDaDat
            // 
            this.pnl_suKienDaDat.Controls.Add(this.label3);
            this.pnl_suKienDaDat.Controls.Add(this.dgv_dichVu);
            this.pnl_suKienDaDat.Controls.Add(this.label2);
            this.pnl_suKienDaDat.Controls.Add(this.dgv_suKien);
            this.pnl_suKienDaDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_suKienDaDat.Location = new System.Drawing.Point(0, 0);
            this.pnl_suKienDaDat.Name = "pnl_suKienDaDat";
            this.pnl_suKienDaDat.Size = new System.Drawing.Size(1422, 785);
            this.pnl_suKienDaDat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Danh sách dịch vụ ";
            // 
            // dgv_dichVu
            // 
            this.dgv_dichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichVu.Location = new System.Drawing.Point(25, 393);
            this.dgv_dichVu.Name = "dgv_dichVu";
            this.dgv_dichVu.RowHeadersWidth = 51;
            this.dgv_dichVu.RowTemplate.Height = 24;
            this.dgv_dichVu.Size = new System.Drawing.Size(953, 339);
            this.dgv_dichVu.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Danh sách sự kiện";
            // 
            // dgv_suKien
            // 
            this.dgv_suKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suKien.Location = new System.Drawing.Point(25, 129);
            this.dgv_suKien.Name = "dgv_suKien";
            this.dgv_suKien.RowHeadersWidth = 51;
            this.dgv_suKien.RowTemplate.Height = 24;
            this.dgv_suKien.Size = new System.Drawing.Size(953, 211);
            this.dgv_suKien.TabIndex = 1;
            // 
            // frm_khachHang_quanLySuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 785);
            this.Controls.Add(this.panel1);
            this.Name = "frm_khachHang_quanLySuKien";
            this.Text = "frm_khachHang_quanLySuKien";
            this.panel1.ResumeLayout(false);
            this.pnl_suKienDaDat.ResumeLayout(false);
            this.pnl_suKienDaDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suKien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_suKienDaDat;
        private System.Windows.Forms.DataGridView dgv_suKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_dichVu;
    }
}