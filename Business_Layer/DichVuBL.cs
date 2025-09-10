using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;
using System.Data.SqlClient;
using Data_Layer;

namespace Business_Layer
{
    public class DichVuBL
    {
        private DichVuDL dichVuDL = new DichVuDL();        
        public List<DichVu> LayDichVuTheoDoiTac(string maDoiTac)
        {
            return dichVuDL.LayDichVuTheoDoiTac(maDoiTac);
        }
        public void ThemDichVu(List<DichVu> danhSachDV)
        {
            dichVuDL.ThemDichVu(danhSachDV);
        }
        public void CapNhatDanhSachDichVu(List<DichVu> ds)
        {
            dichVuDL.CapNhatDanhSachDichVu(ds);
        }
    }
}
