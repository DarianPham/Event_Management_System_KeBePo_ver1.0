namespace Presentation_Layer
{
    partial class frm_trangQuanLySuKienNhanVien
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
            this.pnl_trangQuanLySuKienNhanVien_chinh = new System.Windows.Forms.Panel();
            this.lb_trangQuanLySuKienNhanVien_suKien = new System.Windows.Forms.Label();
            this.dgv_suKien = new System.Windows.Forms.DataGridView();
            this.pnl_trangQuanLySuKienNhanVien_chinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suKien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_trangQuanLySuKienNhanVien_chinh
            // 
            this.pnl_trangQuanLySuKienNhanVien_chinh.Controls.Add(this.dgv_suKien);
            this.pnl_trangQuanLySuKienNhanVien_chinh.Controls.Add(this.lb_trangQuanLySuKienNhanVien_suKien);
            this.pnl_trangQuanLySuKienNhanVien_chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_trangQuanLySuKienNhanVien_chinh.Location = new System.Drawing.Point(0, 0);
            this.pnl_trangQuanLySuKienNhanVien_chinh.Name = "pnl_trangQuanLySuKienNhanVien_chinh";
            this.pnl_trangQuanLySuKienNhanVien_chinh.Size = new System.Drawing.Size(1612, 800);
            this.pnl_trangQuanLySuKienNhanVien_chinh.TabIndex = 0;
            // 
            // lb_trangQuanLySuKienNhanVien_suKien
            // 
            this.lb_trangQuanLySuKienNhanVien_suKien.AutoSize = true;
            this.lb_trangQuanLySuKienNhanVien_suKien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangQuanLySuKienNhanVien_suKien.Location = new System.Drawing.Point(46, 30);
            this.lb_trangQuanLySuKienNhanVien_suKien.Name = "lb_trangQuanLySuKienNhanVien_suKien";
            this.lb_trangQuanLySuKienNhanVien_suKien.Size = new System.Drawing.Size(176, 41);
            this.lb_trangQuanLySuKienNhanVien_suKien.TabIndex = 2;
            this.lb_trangQuanLySuKienNhanVien_suKien.Text = "Các sự kiện";
            // 
            // dgv_suKien
            // 
            this.dgv_suKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suKien.Location = new System.Drawing.Point(33, 92);
            this.dgv_suKien.Name = "dgv_suKien";
            this.dgv_suKien.RowHeadersWidth = 51;
            this.dgv_suKien.RowTemplate.Height = 24;
            this.dgv_suKien.Size = new System.Drawing.Size(1047, 672);
            this.dgv_suKien.TabIndex = 3;
            // 
            // frm_trangQuanLySuKienNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 800);
            this.Controls.Add(this.pnl_trangQuanLySuKienNhanVien_chinh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_trangQuanLySuKienNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_trangQuanLySuKienNhanVien";
            this.Load += new System.EventHandler(this.frm_trangQuanLySuKienNhanVien_Load);
            this.pnl_trangQuanLySuKienNhanVien_chinh.ResumeLayout(false);
            this.pnl_trangQuanLySuKienNhanVien_chinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suKien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_trangQuanLySuKienNhanVien_chinh;
        private System.Windows.Forms.Label lb_trangQuanLySuKienNhanVien_suKien;
        private System.Windows.Forms.DataGridView dgv_suKien;
    }
}