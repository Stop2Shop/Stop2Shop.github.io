using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stop2ShopPL.Models;
using Stop2ShopBL;
using Stop2ShopCL;

namespace Stop2ShopPL.Controllers
{
    public class HomeController : Controller
    {
        log4net.ILog logger;
        public HomeController()
        {
            logger = log4net.LogManager.GetLogger("File");
        }
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        //      (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // GET: Home
        public ActionResult Index()
        {
            try
            {

            }
            catch (Exception e)
            {

                logger.Error(e);


            }
            return View();

        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {

            UserLogin _UserLogin = new UserLogin();
            _UserLogin.UserType = Convert.ToInt32(collection["rbCustomerType"]);
            return View(_UserLogin);


        }
        [HttpPost]
        public ActionResult LoginValidate(UserLogin user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserDO _UserDO = new UserDO();
                    RoleDO _RoleDO = new RoleDO();
                    _UserDO.EmailId = user.EmailId;
                    _UserDO.Password = user.Password;
                    _UserDO.RoleId = user.UserType;
                    _RoleDO.ROLE_ID = Convert.ToInt16(_UserDO.RoleId);
                    UserManager _UserManager = new UserManager();
                    RoleManager _RoleManager = new RoleManager();
                    bool IsAuthenticated = _UserManager.LoginValidate(_UserDO);
                    if (IsAuthenticated)
                    {
                        Session["UserId"] = _UserDO.EmailId;
                        Session["UserRole"] = _RoleManager.FetchRole(_RoleDO);
                        return View("Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Login Authentication Failed");
                        UserLogin _UserLogin = new UserLogin();
                        _UserLogin.UserType = Convert.ToInt16(user.UserType);
                        return View("Login", _UserLogin);
                    }
                }
                else
                {
                    UserLogin _UserLogin = new UserLogin();
                    _UserLogin.UserType = Convert.ToInt16(user.UserType);
                    return View("Login", _UserLogin);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
