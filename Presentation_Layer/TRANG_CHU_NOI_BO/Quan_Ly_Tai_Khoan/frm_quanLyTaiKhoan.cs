using Business_Layer;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer_Object;

namespace Presentation_Layer.TRANG_CHU_NOI_BO.Quan_Ly_Tai_Khoan
{
    public partial class frm_quanLyTaiKhoan : Form

    {
        //private TaiKhoanBL taiKhoanBL = new TaiKhoanBL();


        private QLTK_BL QLTK_BL = new QLTK_BL();



        private void Form_Load(object sender, EventArgs e)
        {
            if (pnl_trangQuanLyTaiKhoan_themTaiKhoan == null)
            {
                pnl_trangQuanLyTaiKhoan_themTaiKhoan = new KryptonPanel();
                pnl_trangQuanLyTaiKhoan_themTaiKhoan.StateCommon.Color1 = Color.Transparent; // Ẩn khi khởi động
                this.Controls.Add(pnl_trangQuanLyTaiKhoan_themTaiKhoan); // Thêm Panel vào Form
            }



        }

        public frm_quanLyTaiKhoan()
        {
            InitializeComponent();
            // Gắn sự kiện khi chọn loại tài khoản
            cbb_trangQuanLyTaiKhoan_loc.SelectedIndexChanged += ComboBoxLoaiTaiKhoan_SelectedIndexChanged;
            dgv_quanLyTaiKhoan_bangLocTimKiem.CellDoubleClick += dgvDanhSachTaiKhoan_CellDoubleClick;


        }

        private void ComboBoxLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbb_trangQuanLyTaiKhoan_loc.SelectedItem.ToString();

            // Kiểm tra nếu chưa có cột, thì thêm cột vào trước
            if (dgv_quanLyTaiKhoan_bangLocTimKiem.Columns.Count == 0)
            {
                dgv_quanLyTaiKhoan_bangLocTimKiem.Columns.Add("HoTen", "Họ Tên"); // Cột Họ Tên
            }

            dgv_quanLyTaiKhoan_bangLocTimKiem.Rows.Clear(); // Xóa dữ liệu cũ

            // Lấy danh sách tài khoản từ BLL
            QLTK_BL taiKhoanBLL = new QLTK_BL();
            List<string> danhSachTaiKhoan = taiKhoanBLL.LayTenTaiKhoan(selectedType);



            // Thêm dữ liệu vào đúng cột
            foreach (var acc in danhSachTaiKhoan)
            {
                dgv_quanLyTaiKhoan_bangLocTimKiem.Rows.Add(acc);
            }

        }

        private void dgvDanhSachTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy họ tên từ hàng được chọn
                string hoTen = dgv_quanLyTaiKhoan_bangLocTimKiem.Rows[e.RowIndex].Cells["ho_ten"].Value.ToString();

                // Lấy loại tài khoản từ ComboBox
                string loaiTaiKhoan = cbb_trangQuanLyTaiKhoan_loc.SelectedItem?.ToString() ?? "Admin";

                // Gọi BLL để lấy thông tin tài khoản từ bảng phù hợp
                TaiKhoanBoLocQLTK taiKhoan = QLTK_BL.LayThongTinTaiKhoanTheoTen(hoTen, loaiTaiKhoan);

                if (taiKhoan != null)
                {
                    // Hiển thị thông tin lên TextBox
                    lbl_frmQuanLyTaiKhoan_ten.Text = taiKhoan.HoTen;
                    txt_frmQuanLyTaiKhoan_Sđt.Text = taiKhoan.SoDienThoai;
                    txt_frmQuanLyTaiKhoan_email.Text = taiKhoan.Email;



                    if (loaiTaiKhoan != "Admin") // Không hiển thị địa chỉ nếu là Admin
                    {
                        txt_frmQuanLyTaiKhoan_diaChi.Text = taiKhoan.DiaChi;
                    }
                    else
                    {
                        txt_frmQuanLyTaiKhoan_diaChi.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void frm_quanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Khi form tải lên, tất cả các ô thông tin chỉ xem
            txt_frmQuanLyTaiKhoan_diaChi.ReadOnly = true;
            txt_frmQuanLyTaiKhoan_email.ReadOnly = true;
            txt_frmQuanLyTaiKhoan_Sđt.ReadOnly = true;


            if (pnl_trangQuanLyTaiKhoan_themTaiKhoan == null)
            {
                pnl_trangQuanLyTaiKhoan_themTaiKhoan = new KryptonPanel();
                pnl_trangQuanLyTaiKhoan_themTaiKhoan.StateCommon.Color1 = Color.Transparent; // Ẩn khi khởi động
                this.Controls.Add(pnl_trangQuanLyTaiKhoan_themTaiKhoan); // Thêm Panel vào Form
            }

        }




        private void btn_trangQuanLyTaiKhoan_sửa_Click(object sender, EventArgs e)
        {

        }
        private (string tenDangNhap, string matKhau) LayThongTinNguoiDung()
        {
            if (pnl_addKhachHang.Visible)
                return (txt_addKhachHang_tenDangNhap.Text, txt_addKhachHang_matKhau.Text);

            if (pnl_addNhanVien.Visible)
                return (txt_addNhanVien_tenDangNhap.Text, txt_addNhanVien_matKhau.Text);

            if (pnl_addAdmin.Visible)
                return (txt_addAdmin_tenDangNhap.Text, txt_addAdmin_matKhau.Text);

            return ("", ""); // Nếu không có panel nào mở
        }


        private void btn_trangQuanLyTaiKhoan_luu_Click(object sender, EventArgs e)
        {


        }
        private string XacDinhLoaiTaiKhoan()
        {
            if (pnl_addAdmin.Visible) return "Admin";
            if (pnl_addKhachHang.Visible) return "KhachHang";
            if (pnl_addNhanVien.Visible) return "NhanVien";
            return "";
        }



        private void AnTatCaPanel()
        {
            pnl_addAdmin.Visible = false;
            pnl_addNhanVien.Visible = false;
            pnl_addKhachHang.Visible = false;

        }


        private void btn_addKhachHang_OK_Click(object sender, EventArgs e)
        {
            var nd = new NguoiDungTO(
    txt_addKhachHang_tenDangNhap.Text,
    txt_addKhachHang_matKhau.Text,
    "khách hàng"
);

            var kh = new KhachHangTO(
     txt_addKhachHang_tenDangNhap.Text,
     txt_addKhachHang_hoTen.Text,
     txt_addKhachHang_diaChi.Text,
     txt_addKhachHang_email.Text,
     txt_addKhachHang_soDienThoai.Text
 );

            var bl = new KhachHangBL(); // ✅ Khởi tạo đối tượng
            if (bl.DangKyKhachHang(nd, kh)) // ✅ Gọi method
            {
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btn_addAmin_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            pnl_addAdmin.Parent.Visible = true;  // Hiển thị phần chứa panel
            pnl_addAdmin.Visible = true;
        }

        private void btn_addKhachHang_Click_1(object sender, EventArgs e)
        {
            AnTatCaPanel();
            pnl_addKhachHang.Parent.Visible = true;  // Hiển thị phần chứa panel
            pnl_addKhachHang.Visible = true;
        }

        private void btn_addNhanVien_Click_1(object sender, EventArgs e)
        {
            AnTatCaPanel();
            pnl_addNhanVien.Parent.Visible = true;  // Hiển thị phần chứa panel
            pnl_addNhanVien.Visible = true;
        }
    }
}
