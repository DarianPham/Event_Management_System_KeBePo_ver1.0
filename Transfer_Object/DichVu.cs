using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class DichVu
    {
        public DichVu(string ma_dich_vu, string ten_dich_vu, string gia, string ma_doi_tac)
        {
            this.ma_dich_vu = ma_dich_vu;
            this.ten_dich_vu = ten_dich_vu;
            this.gia = gia;
            this.ma_doi_tac = ma_doi_tac;
        }
        public DichVu() { } // constructor mặc định

        public string ma_dich_vu {  get; set; }
        public string ten_dich_vu { get;set; }
        public string gia {  get; set; }
        public string ma_doi_tac {  get; set; }
    }
}
