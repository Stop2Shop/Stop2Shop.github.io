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
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            Session["userRole"] = collection["rbCustomerType"];
            return View();
        }

        [ActionName("LoginValidate")]
        [HttpPost]
        public ActionResult Login(UserLogin user)
        {
            UserDO _UserDO = new UserDO();
            _UserDO.EmailId = user.EmailId;
            _UserDO.Password = user.Password;
            _UserDO.RoleId = user.RoleId;
            UserManager _UserManager = new UserManager();
            bool IsAuthenticated = _UserManager.LoginValidate(_UserDO);
            if(IsAuthenticated)
            {
                //return RedirectToAction("Login", "Home");
                ModelState.AddModelError("", "Login Authentication Success");
                return View("Login");
            }
            else
            {
                ModelState.AddModelError("", "Login Authentication Failed");
                return View("Login");
            }
            
        }
        // GET: Home/Details/5
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
