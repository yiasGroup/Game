using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBLL
{
    public class LoginBLL
    {
        public string LoginManage(string name, string pass)
        {
            SysUserInfo user = new SysUserInfo();
            if (name == "admin" && pass == "123")
            {
                user.UserID = "admin";
                user.UserName = "管理员";
                user.Roles = new List<SysUserRole>();
                user.Roles.Add(new SysUserRole() { RoleName = "后台管理员" });
                return user.ToString();
            }
            return "";
        }
    }
}
