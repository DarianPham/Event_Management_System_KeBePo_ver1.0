using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Business_Layer
{
    public class LoginBL
    {
        public bool Login(TaiKhoan acc)
        {
            try
            {
                return (new LoginDL().Login(acc));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
