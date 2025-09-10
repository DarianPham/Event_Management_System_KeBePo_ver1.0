using Presentation_Layer.DANG_NHAP;
using Presentation_Layer.TRANG_CHU_KHACH_HANG;
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

namespace Presentation_Layer
{
    public partial class frm_trangThongTinKhachHang: Form
    {
        public frm_trangThongTinKhachHang()
        {
            InitializeComponent();
        }

        public void GoiFormChucNang(Form frm)
        {
            pnl_chucNang.Controls.Clear();            // Xóa control cũ
            frm.TopLevel = false;                // Không phải top-level form
            frm.FormBorderStyle = FormBorderStyle.None; // Không viền
            frm.Dock = DockStyle.Fill;           // Chiếm hết Panel
            pnl_chucNang.Controls.Add(frm);           // Thêm vào Panel
            frm.Show();                          // Hiển thị
        }
        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_TrangthongtinKH_Sukiendadanhgia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_datSuKien_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_demoDatSuKien(this)); // luu y THIS

        }

        private void pic_quanLySuKien_Click(object sender, EventArgs e)
        {
            GoiFormChucNang(new frm_khachHang_quanLySuKien());
        }

        private void pic_danhGia_Click(object sender, EventArgs e)
        {

        }

        private void pic_thongBao_Click(object sender, EventArgs e)
        {

        }

        private void pic_dangXuat_Click(object sender, EventArgs e)
        {
            string msg = "Bạn muốn đăng xuất ?";
            DialogResult result = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                System.Threading.Thread thread = new System.Threading.Thread(() =>
                {
                    Application.Run(new frm_Loading());
                });

                thread.SetApartmentState(System.Threading.ApartmentState.STA);
                thread.Start();

                Application.Exit(); // Tắt toàn bộ app hiện tại (các form khác)
                                    //this.Hide(); // Ẩn form đăng nhập để không thấy nữa

                //DangNhap dangNhap = new DangNhap();
                //dangNhap.ShowDialog(); // Dùng ShowDialog sẽ giữ app sống, và tạo loop riêng
                //this.Close();
            }
            else
            {
                /*txt_dangNhap_tenDangNhap.Focus();*/ // Trả con trỏ về ô nhập tài khoản để nhập lại
            }
        }
    }
}
