using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Business_Layer
{

    public class KhachHangBL
    {
        private NguoiDungDL nguoiDungDL = new NguoiDungDL();
        private KhachHangDL khachHangDL = new KhachHangDL();

        public bool DangKyKhachHang(NguoiDungTO nd, KhachHangTO kh)
        {
            bool successND = nguoiDungDL.ThemNguoiDung(nd);
            if (!successND) return false;

            return khachHangDL.ThemKhachHang(kh);
        }
        public string GetMaKhachHangFromNguoiDung(string maNguoiDung)
        {
            return khachHangDL.GetMaKhachHangByMaNguoiDung(maNguoiDung);
        }

    }
}
