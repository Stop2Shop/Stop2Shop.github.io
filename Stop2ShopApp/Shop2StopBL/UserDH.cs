using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stop2ShopDAL;


namespace Stop2ShopBL
{
    public class UserDH
    {
        CommonDal dal;
        public UserDH()
        {
           dal = new CommonDal();
        }
       
         
        public bool LoginValidate(string username, string EncryptPwd, int RoleId)
        {
            bool result = false;
            try
            {
                result = dal.ValidateUser(username, EncryptPwd, RoleId);
            }
            catch (Exception)
            {

                result=false;
            }
            return result;
            
            
        }

        public string FetchRole(int roleId)
        {
            string role="";
            try
            {
                role = dal.FetchRole(roleId);
            }
            catch (Exception e)
            {

                throw;
            }

            return role;
        }


    }
}
