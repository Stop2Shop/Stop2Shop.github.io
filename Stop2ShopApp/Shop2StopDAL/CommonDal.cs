
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop2ShopDAL
{
    public class CommonDal
    {
        Stop2ShopContext context;
        public CommonDal()
        {
            context = new Stop2ShopContext();
        }
        public bool ValidateUser(string username, string EncryptPwd, int RoleId)
        {
            bool result = false;
            try
            {
                var validationResult = context.Proc_UserAuthenticate(username, EncryptPwd, RoleId);
                if (validationResult != null)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception e)
            {

                result = false;
            }
            return result;
        }

        public string FetchRole(int roleId)
        {
            string role = "";
            try
            {
                role = (from c in context.tbl_ROLE where c.ROLE_ID == roleId select c.ROLE_NAME).FirstOrDefault();
            }
            catch (Exception e)
            {

                role="";
            }
            return role;
        }
    }
}
