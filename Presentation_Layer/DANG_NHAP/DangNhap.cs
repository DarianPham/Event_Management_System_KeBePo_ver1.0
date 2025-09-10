using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer;
using Transfer_Object;


namespace Presentation_Layer
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        //Xử lý hiệu ứng
        /// 1. Ấn nút hiện pnl
        private void btn_dangNhap_dangKyTren_Click(object sender, EventArgs e)
        {
            pnl_dangNhap_dangKy.BringToFront();
            btn_dangNhap_dangKyDuoi.BringToFront();
            btn_dangNhap_dangNhapTren.BringToFront();
        }

        private void btn_dangNhap_dangNhapTren_Click(object sender, EventArgs e)
        {
            pnl_dangNhap_dangNhap.BringToFront();
            btn_dangNhap_dangNhapDuoi.BringToFront();
            btn_dangNhap_dangKyTren.BringToFront();
        }
        //Xử lý logic

        //1. Nút đăng nhập
        private void btn_dangNhap_dangNhap_Click(object sender, EventArgs e)
        {
            string username, password, phan_quyen;
            username = txt_dangNhap_tenDangNhap.Text.Trim();
            password = txt_dangNhap_matKhau.Text;
            phan_quyen = cbb_dangNhap_dangNhap.SelectedItem.ToString();

            TaiKhoan acc = new TaiKhoan(username, password, phan_quyen);
            bool b = false;
            try
            {
                b = new LoginBL().Login(acc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (b & cbb_dangNhap_dangNhap.SelectedItem.ToString() == "Khách hàng")
            {
                username = txt_dangNhap_tenDangNhap.Text;
                this.Hide(); // Ẩn form đăng nhập để không thấy nữa
                string maNguoiDung = new KhachHangBL().GetMaKhachHangFromNguoiDung(username); // => bạn cần viết hàm này
                frm_trangChuKhachHang trangChuKH = new frm_trangChuKhachHang();
                trangChuKH.ShowDialog(); // Dùng ShowDialog sẽ giữ app sống, và tạo loop riêng

                this.Close(); // Sau khi form chính đóng thì mới đóng login
            }
            else 
            {
                if (b)
                {
                    this.Hide(); // Ẩn form đăng nhập để không thấy nữa

                    frm_trangChuNoiBo trangChuForm = new frm_trangChuNoiBo();
                    trangChuForm.ShowDialog(); // Dùng ShowDialog sẽ giữ app sống, và tạo loop riêng

                    this.Close(); // Sau khi form chính đóng thì mới đóng login
                }
                else
                {
                    string msg = "Tên đăng nhập hoặc mật khẩu không đúng. Bạn có muốn thử lại không?";
                    DialogResult result = MessageBox.Show(msg, "Đăng nhập thất bại", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit(); // Thoát ứng dụng nếu người dùng bấm Hủy
                    }
                    else
                    {
                        txt_dangNhap_tenDangNhap.Focus(); // Trả con trỏ về ô nhập tài khoản để nhập lại
                    }
                }
                
            }

        }
        //2. Đăng ký      
        private void pic_dangNhap_admin_Click(object sender, EventArgs e)
        {
            string msg = "Không thể tạo, vui lòng liên hệ Admin để được tạo tài khoản";
            DialogResult result = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pic_dangNhap_nhanVien_Click(object sender, EventArgs e)
        {
            string msg = "Không thể tạo, vui lòng liên hệ Admin để được tạo tài khoản ! ";
            DialogResult result = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pic_dangNhap_khachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
           frm_dangNhap_khachHang kh = new frm_dangNhap_khachHang();
            kh.ShowDialog();
            this.Close();

        }
    }
}
