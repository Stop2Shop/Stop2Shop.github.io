using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stop2ShopCL;
using Stop2ShopDAL;

namespace Stop2ShopBL
{
    public class RoleManager
    {
        public string FetchRole(RoleDO _RoleDO)
        {
            string role = "";
            RoleDH _RoleDH;
            try
            {
                _RoleDH = new RoleDH();
                role = _RoleDH.FetchRole(_RoleDO);
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                _RoleDH = null;
            }

            return role;
        }
    }
}