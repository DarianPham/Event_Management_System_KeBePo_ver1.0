using Presentation_Layer.TRANG_CHU_KHACH_HANG.Dat_Su_Kien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.TRANG_CHU_KHACH_HANG
{
    public partial class frm_khachHang_datSuKien : Form
    {
        public frm_khachHang_datSuKien()
        {
            InitializeComponent();
        }
        private void GoiFormChucNang(Form frm)
        {
           pnl_datSuKien_chonOption.Controls.Clear();            // Xóa control cũ
            frm.TopLevel = false;                // Không phải top-level form
            frm.FormBorderStyle = FormBorderStyle.None; // Không viền
            frm.Dock = DockStyle.Fill;           // Chiếm hết Panel
           pnl_datSuKien_chonOption.Controls.Add(frm);           // Thêm vào Panel
            frm.Show();                          // Hiển thị
        }
        private void pic_loaiSuKien_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_b1chonLoaiSuKien());
        }
        private void pic_dichVuKhac_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_b2chonDiaDiem());
        }
        private void pic_thanhToan_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_b5thanhToan());
        }

        private void pic_hopDong_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_b6hopDong());
        }
    }
}
