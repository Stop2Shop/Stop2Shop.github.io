using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stop2ShopCL;

namespace Stop2ShopDAL
{
    public class RoleDH
    {
        Stop2ShopContext context;
        public RoleDH()
        {
            context = new Stop2ShopContext();
        }
        public string FetchRole(RoleDO _RoleDO)
        {
            string role = "";
            try
            {
                role = (from c in context.tbl_ROLE where c.ROLE_ID == _RoleDO.ROLE_ID select c.ROLE_NAME).FirstOrDefault();
            }
            catch (Exception e)
            {

                role = "";
            }
            return role;
        }
    }
}
