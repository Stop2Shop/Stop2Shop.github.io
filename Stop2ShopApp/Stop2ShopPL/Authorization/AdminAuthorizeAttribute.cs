using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stop2ShopCL;

namespace Stop2ShopPL.Authorization
{
    public class AdminAuthorizeAttribute: AuthorizeAttribute
    {
        DatabaseUtills dbUtils;
        public AdminAuthorizeAttribute()
        {
            dbUtils = new DatabaseUtills();
        }
        //Default url for unauthorize access
        private string notifyUrl = "/Home/Index";

        public string NotifyUrl
        {
            get { return notifyUrl; }
            set { notifyUrl = value; }
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool status = false;
            try
            {
                var roleId = HttpContext.Current.Session["userRole"];
                if (roleId == null)
                {
                    status = false;
                }
                else
                {
                    //Check if the user is an admin
                    var role=dbUtils.FetchRole(Convert.ToInt32( roleId));
                    if (role == "Admin")
                        status = true;
                    else
                        status = false;
                }
            }
            catch (Exception e)
            {

                status=false;
            }

            return status;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult(NotifyUrl);
        }
    }

}