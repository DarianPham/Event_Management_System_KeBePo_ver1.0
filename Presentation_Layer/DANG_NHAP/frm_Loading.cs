using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.DANG_NHAP
{
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void frm_Loading_Load(object sender, EventArgs e)
        {

        }

        private void frm_Loading_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap demo = new DangNhap();
            demo.ShowDialog();
            this.Close();
        }
    }
}
