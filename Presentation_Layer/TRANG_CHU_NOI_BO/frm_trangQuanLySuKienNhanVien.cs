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
using Transfer_Object;

namespace Presentation_Layer
{
    public partial class frm_trangQuanLySuKienNhanVien : Form
    {
        public frm_trangQuanLySuKienNhanVien()
        {
            InitializeComponent();
        }
        private SuKienBL suKienBL = new SuKienBL();
        private void frm_trangQuanLySuKienNhanVien_Load(object sender, EventArgs e)
        {
            List<SuKien> danhSachSuKien = suKienBL.LayTatCaSuKien();
            dgv_suKien.DataSource = danhSachSuKien;
        }
    }
}
