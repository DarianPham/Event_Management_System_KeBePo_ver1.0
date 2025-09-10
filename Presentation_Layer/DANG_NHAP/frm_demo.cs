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
    public partial class frm_demo : Form
    {
        public frm_demo()
        {
            InitializeComponent();
        }

        private void pnl_demo_dangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Loading demo = new frm_Loading();
            demo.ShowDialog();
            this.Close();
        }

        private void pnl_demo_dangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Loading demo = new frm_Loading();
            demo.ShowDialog();
            this.Close();
        }
    }
}
