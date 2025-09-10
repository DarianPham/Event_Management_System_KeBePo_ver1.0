using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;
using System.Data.SqlClient;

namespace Business_Layer
{
    public class DoiTacBL
    {
        private DoiTacDL doiTacDL = new DoiTacDL();

        public List<DoiTac> TimKiemVaLoc(string keyword, string loaiHinh)
        {
            return doiTacDL.TimKiemVaLoc(keyword, loaiHinh);
        }
        public List<DoiTac> GetDoiTacs()
        {
            return doiTacDL.GetDoiTacs();
        }
        public List<DoiTac> LayThongTin(string ma)
        {
            return doiTacDL.LayThongTinDoiTac(ma);
        }
        public List<DoiTac> LayTatCaDoiTac()
        {
            return doiTacDL.LayTatCaDoiTac();
        }

        public List<DoiTac> LayDoiTacTheoLoaiHinh(string loaiHinh)
        {
            return doiTacDL.LayDoiTacTheoLoaiHinh(loaiHinh);
        }
        public List<string> LayDanhSachLoaiHinh()
        {
            return doiTacDL.LayDanhSachLoaiHinh();
        }
        public string ThemDoiTac(DoiTac dt)
        {
            return doiTacDL.ThemDoiTac(dt); // giả sử DAL là nơi thao tác SQL, và nó trả về mã đối tác mới
        }

        public string GetMaDoiTacMoi()
        {
            //return doiTacDL.GetMaDoiTacMoi();
            List<DoiTac> ds = doiTacDL.LayTatCaDoiTac();
            int max = 0;
            foreach (var item in ds)
            {
                if (item.ma_doi_tac.StartsWith("DT"))
                {
                    if (int.TryParse(item.ma_doi_tac.Substring(2), out int so))
                    {
                        if (so > max)
                            max = so;
                    }
                }
            }

            return $"DT{(max + 1).ToString("D2")}";
        }
       public void Delete(string maDoiTac)
        {
           doiTacDL.Delete(maDoiTac);
        }     
        public void CapNhatDoiTac(DoiTac dt)
        {
            doiTacDL.CapNhatDoiTac(dt);
        }
    }
}

