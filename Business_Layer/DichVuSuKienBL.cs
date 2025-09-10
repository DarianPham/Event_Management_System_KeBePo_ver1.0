using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;
namespace Business_Layer
{
    public class DichVuSuKienBL
    {
        private DichVuSuKienDL dl = new DichVuSuKienDL();

        public void Them(DichVuSuKien item)
        {
            dl.ThemDichVuSuKien(item);
        }

        public List<DichVuSuKien> LayTheoSuKien(string maSuKien)
        {
            return dl.LayTheoMaSuKien(maSuKien);
        }
    }
}
