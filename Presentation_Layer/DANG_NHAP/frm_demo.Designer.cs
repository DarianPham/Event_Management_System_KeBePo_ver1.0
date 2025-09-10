namespace Presentation_Layer.DANG_NHAP
{
    partial class frm_demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_demo));
            this.pnl_demo_dangNhap = new System.Windows.Forms.Panel();
            this.pnl_demo_dangKy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_demo_dangNhap
            // 
            this.pnl_demo_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.pnl_demo_dangNhap.Location = new System.Drawing.Point(457, 502);
            this.pnl_demo_dangNhap.Name = "pnl_demo_dangNhap";
            this.pnl_demo_dangNhap.Size = new System.Drawing.Size(216, 56);
            this.pnl_demo_dangNhap.TabIndex = 1;
            this.pnl_demo_dangNhap.Click += new System.EventHandler(this.pnl_demo_dangNhap_Click);
            // 
            // pnl_demo_dangKy
            // 
            this.pnl_demo_dangKy.BackColor = System.Drawing.Color.Transparent;
            this.pnl_demo_dangKy.Location = new System.Drawing.Point(703, 502);
            this.pnl_demo_dangKy.Name = "pnl_demo_dangKy";
            this.pnl_demo_dangKy.Size = new System.Drawing.Size(211, 56);
            this.pnl_demo_dangKy.TabIndex = 2;
            this.pnl_demo_dangKy.Click += new System.EventHandler(this.pnl_demo_dangKy_Click);
            // 
            // frm_demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 760);
            this.Controls.Add(this.pnl_demo_dangKy);
            this.Controls.Add(this.pnl_demo_dangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_demo";
            this.Text = "frm_demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_demo_dangNhap;
        private System.Windows.Forms.Panel pnl_demo_dangKy;
    }
}