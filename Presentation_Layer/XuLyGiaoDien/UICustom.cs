using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.XuLyGiaoDien
{
    public class UICustom
    {
        //Bo cong nha
        public static void BoCong(Control control, int radius)
        {
            if (control == null || radius <= 0) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                int width = control.Width;
                int height = control.Height;

                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(width - radius, 0, radius, radius, 270, 90);
                path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
                path.AddArc(0, height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);
            }

            control.Invalidate();
        }


    }
}
