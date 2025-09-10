using Presentation_Layer.DANG_NHAP;
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
    public partial class frm_trangKhachHang : Form
    {
        private frm_trangChuKhachHang frm_trangKH; // cho frm hiện tại trở thành frm con của frm trang chủ khách hàng 
        public frm_trangKhachHang(frm_trangChuKhachHang parentFrom)
        {
            InitializeComponent();
            frm_trangKH = parentFrom;
        }

        private void lbl_trangKhachHang_thongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_trangKH.GoiFormChucNang(new frm_trangThongTinKhachHang());  
        }

        private void lbl_trangKhachHang_khac_Click(object sender, EventArgs e)
        {

        }

        private void lbl_trangKhachHang_dangXuat_Click(object sender, EventArgs e)
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
