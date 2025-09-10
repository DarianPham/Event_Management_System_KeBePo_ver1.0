using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Business_Layer
{
    public class SuKienBL
    {
        private SuKienDL suKienDL = new SuKienDL();

        public List<SuKien> LayTatCaSuKien()
        {
            return suKienDL.LayDanhSachSuKien();
        }
    }
}
