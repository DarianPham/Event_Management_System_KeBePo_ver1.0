using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
   public class DichVuSuKien
    {
       
            public string ma_su_kien { get; set; }
            public string ma_dich_vu { get; set; }
            public decimal gia { get; set; }

        public DichVuSuKien(string ma_su_kien, string ma_dich_vu, decimal gia)
        {
            this.ma_su_kien = ma_su_kien;
            this.ma_dich_vu = ma_dich_vu;
            this.gia = gia;
        }

        public DichVuSuKien()
        {
        }
    }
}
