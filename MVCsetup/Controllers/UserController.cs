using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCsetup.Models;
using BusinessLogicLayer;
using BusinessLogicLayer.BusinessObjects;


namespace MVCsetup.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(UserViewModel userVM)
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegisterUser(UserViewModel userVM)
        {
            return View();
        }
    }
}