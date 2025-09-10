using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Business_Layer
{
    public class QLTK_BL
    {
        public QLTK_DL taiKhoanDAL = new QLTK_DL(); // Gọi DL để lấy dữ liệu từ SQL

        public List<string> LayTenTaiKhoan(string accountType)
        {
            return taiKhoanDAL.LayTenTuBoLoc(accountType); // Chuyển xử lý sang DAL
        }



        public TaiKhoanBoLocQLTK LayThongTinTaiKhoanTheoTen(string hoTen, string loaiTaiKhoan)
        {
            return taiKhoanDAL.LayThongTinTaiKhoanTheoTen(hoTen, loaiTaiKhoan);
        }
    }
}
