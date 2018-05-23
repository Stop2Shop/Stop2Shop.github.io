using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stop2ShopBL;


namespace Stop2ShopCL
{
    public class DatabaseUtills
    {
        public bool IsAuthenticated(string UserName,String Password,int RoleId)
        {
            bool IsAuthenticated = false;
            CommonUtills CUtil = new CommonUtills();
            UserDH _UserDH = new UserDH();
            string strEncryptedPwd = CUtil.EncryptRijndael(Password);
            IsAuthenticated = _UserDH.LoginValidate(UserName, strEncryptedPwd, RoleId);
            return IsAuthenticated;
        }
    }
}
