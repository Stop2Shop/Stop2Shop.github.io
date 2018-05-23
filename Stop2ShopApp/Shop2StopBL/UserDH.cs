using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop2StopDAL;

namespace Stop2ShopBL
{
    public class UserDH
    {
        Stop2ShopContext DbContext = new Stop2ShopContext();
        public bool LoginValidate(string username, string EncryptPwd, int RoleId)
        {
            var result = DbContext.Proc_UserAuthenticate(username, EncryptPwd, RoleId);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
