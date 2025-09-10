using Presentation_Layer.TRANG_CHU_KHACH_HANG;
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
    public partial class frm_trangChuKhachHang: Form
    {
        public frm_trangChuKhachHang()
        {
            InitializeComponent();
      
        }
        public void GoiFormChucNang(Form frm)
        {
           pnl_trangChuKhachHang.Controls.Clear();            // Xóa control cũ
            frm.TopLevel = false;                // Không phải top-level form
            frm.FormBorderStyle = FormBorderStyle.None; // Không viền
            frm.Dock = DockStyle.Fill;           // Chiếm hết Panel
            pnl_trangChuKhachHang.Controls.Add(frm);           // Thêm vào Panel
            frm.Show();                          // Hiển thị
        }

        private void frm_trangChuKhachHang_Load(object sender, EventArgs e)
        {
            GoiFormChucNang(  new frm_trangKhachHang(this));
        }
    }
}
