
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
                var validationResult = context.Proc_UserAuthenticate(_UserDo.EmailId, _UserDo.Password, _UserDo.RoleId);
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

    }
}
