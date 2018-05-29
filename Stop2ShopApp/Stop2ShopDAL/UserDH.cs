using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stop2ShopCL;

namespace Stop2ShopDAL
{
    public class UserDH
    {
        Stop2ShopContext context;
        public UserDH()
        {
            context = new Stop2ShopContext();
        }
        public bool ValidateUser(UserDO _UserDo)
        {
            bool result = false;
            try
            {
                var validationResult = (from ur in context.tbl_USER_ROLE
                                        join u in context.tbl_USER
                                        on ur.USER_PROFILE_ID equals u.USER_PROFILE_ID
                                        where ur.ROLE_ID==_UserDo.RoleId &&
                                        ur.USER_PROFILE_ID==_UserDo.EmailId &&
                                        u.PASSWORD==_UserDo.Password select ur) ;
                if (validationResult.Count() != 0)
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

    }
}