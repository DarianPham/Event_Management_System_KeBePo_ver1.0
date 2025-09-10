using Presentation_Layer.TRANG_CHU_NOI_BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.TRANG_CHU_KHACH_HANG.Dat_Su_Kien
{
    public partial class frm_demoDatSuKien : Form
    {
        private frm_trangThongTinKhachHang frm_trangTTKH;
        public frm_demoDatSuKien(frm_trangThongTinKhachHang parenForm)
        {
            InitializeComponent();
            frm_trangTTKH = parenForm;
        }
        private void frm_demoDatSuKien_Load(object sender, EventArgs e)
        {

        }

        private void frm_demoDatSuKien_Click(object sender, EventArgs e)
        {
            frm_trangTTKH.GoiFormChucNang(new frm_khachHang_datSuKien());
        }
    }
}
