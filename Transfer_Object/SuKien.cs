using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class SuKien
    {
        public string ma_su_kien { get; set; }
        public DateTime? ngay_dat { get; set; }
        public DateTime? ngay_bat_dau { get; set; }
        public string trang_thai { get; set; }
        public string ma_khach_hang { get; set; }
        public string ma_nhan_vien { get; set; }
        public string ma_loai { get; set; }

        public SuKien() { }

        public SuKien(string ma_su_kien, DateTime? ngay_dat, DateTime? ngay_bat_dau, string trang_thai, string ma_khach_hang, string ma_nhan_vien, string ma_loai)
        {
            this.ma_su_kien = ma_su_kien;
            this.ngay_dat = ngay_dat;
            this.ngay_bat_dau = ngay_bat_dau;
            this.trang_thai = trang_thai;
            this.ma_khach_hang = ma_khach_hang;
            this.ma_nhan_vien = ma_nhan_vien;
            this.ma_loai = ma_loai;
        }
    }
}
