using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBLL
{
    public class LoginBLL
    {
        public bool LoginManage(string name, string pass)
        {
            bool retValue = false;
            if (name == "admin" && pass == "123")
            {
                retValue = true;
            }
            return retValue;
        }
    }
}
