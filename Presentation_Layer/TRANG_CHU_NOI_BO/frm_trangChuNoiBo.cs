using Presentation_Layer.TRANG_CHU_NOI_BO.Quan_Ly_Tai_Khoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class frm_trangChuNoiBo : Form
    {
        public frm_trangChuNoiBo()
        {
            InitializeComponent();
        }
        // I. Xử lý chuyển hướng chức năng
        private void GoiFormChucNang(Form frm)
        {
            pnl_trangChuNoiBo_chinh.Controls.Clear();            // Xóa control cũ
            frm.TopLevel = false;                // Không phải top-level form
            frm.FormBorderStyle = FormBorderStyle.None; // Không viền
            frm.Dock = DockStyle.Fill;           // Chiếm hết Panel
            pnl_trangChuNoiBo_chinh.Controls.Add(frm);           // Thêm vào Panel
            frm.Show();                          // Hiển thị
        }

        private void btn_trangChuNoiBo_quanLyNhanVien_Click(object sender, EventArgs e)
        {
            GoiFormChucNang( new frm_trangQuanLySuKienNhanVien() );
        }

        private void btn_trangChuNoiBo_quanLySuKien_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_trangQuanLySuKienNhanVien());
        }

        private void btn_trangChuNoiBo_quanLyDoiTac_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_trangQuanLyDoiTac());
        }

        private void btn_trangChuNoiBo_baoCao_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_trangBaoCaoThongKe());
        }

        private void btn_trangChuNoiBo_quanLyTaiKhoan_Click(object sender, EventArgs e)
        {
           GoiFormChucNang(new frm_quanLyTaiKhoan());
        }

        private void btn_trangChuNoiBo_trangTongQuan_Click(object sender, EventArgs e)
        {

        }
    }
}
