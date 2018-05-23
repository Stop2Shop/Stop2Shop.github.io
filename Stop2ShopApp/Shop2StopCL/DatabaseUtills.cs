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
        CommonUtills CUtil;
        UserDH _UserDH;
        public DatabaseUtills()
        {
            CUtil = new CommonUtills();
            _UserDH = new UserDH();
        }
        public bool IsAuthenticated(string UserName,String Password,int RoleId)
        {
            bool isAuthenticated = false;
            try
            {
               
                
                string strEncryptedPwd = CUtil.EncryptRijndael(Password);
                isAuthenticated = _UserDH.LoginValidate(UserName, strEncryptedPwd, RoleId);
            }
            catch (Exception e)
            {

                isAuthenticated=false;
            }
          
            return isAuthenticated;
        }
        public string FetchRole(int roleId)
        {
            string role = "";
            try
            {
                role = _UserDH.FetchRole(roleId);
            }
            catch (Exception)
            {

                role="";
            }
            return role;
        }
    }
}
