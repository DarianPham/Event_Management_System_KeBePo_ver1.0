using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class DoiTac
    {
       
        public DoiTac(string ma_doi_tac, string ten_doi_tac, string email, string so_dien_thoai, string dia_chi, string loai_hinh)
        {
            this.ma_doi_tac = ma_doi_tac;
            this.ten_doi_tac = ten_doi_tac;
            this.email = email;
            this.so_dien_thoai = so_dien_thoai;
            this.dia_chi = dia_chi;
            this.loai_hinh = loai_hinh;

        }
        public DoiTac() { } // constructor mặc định


        public string ma_doi_tac { get; set; }
        public string ten_doi_tac { get; set; }
        public string email {  get; set; }
        public string so_dien_thoai { get; set; }
        public string dia_chi {  get; set; }
        public string loai_hinh { get; set; }
        public List<DichVu> DanhSachDichVu { get; set; }
    }

}
