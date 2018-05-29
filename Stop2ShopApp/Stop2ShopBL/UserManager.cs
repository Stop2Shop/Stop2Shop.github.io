using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stop2ShopDAL;
using Stop2ShopCL;

namespace Stop2ShopBL
{
    public class UserManager
    {
        public UserManager()
        {
        }

        public bool LoginValidate(UserDO _UserDo)
        {
            bool result = false;
            CommonUtills _CommonUtills;
            UserDH _UserDH;
            try
            {
                _CommonUtills = new CommonUtills();
                _UserDH = new UserDH();
                _UserDo.Password = _CommonUtills.EncryptRijndael(_UserDo.Password);
                result = _UserDH.ValidateUser(_UserDo);
            }
            catch (Exception ex)
            {

                result = false;
            }
            finally
            {
                _CommonUtills = null;
                _UserDH = null;
            }
            return result;


        }


    }
}