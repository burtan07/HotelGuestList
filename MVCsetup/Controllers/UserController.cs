using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;
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
        public ActionResult RegisterUser(UserViewModel userVM)  //calls Map method for VM->BO and sends BOuser to BLL CreateUser Method
        {
            UserBusinessLogic _userBLL = new UserBusinessLogic();
            LogicUser boRegisterUser = Map(userVM);
            _userBLL.CreateUser(boRegisterUser);
            return View("Login");
        }

        static LogicUser Map(UserViewModel userVM)  //Maps userVM to boUser
        {
            LogicUser boRegUser = new LogicUser();

            var type_userVM = userVM.GetType();
            var type_boUser = boRegUser.GetType();

            foreach (var field_userVM in type_userVM.GetFields())
            {
                var field_boUser = type_boUser.GetField(field_userVM.Name);
                field_boUser.SetValue(boRegUser, field_userVM.GetValue(userVM));
            }

            foreach (var property_userVM in type_userVM.GetProperties())
            {
                var property_boUser = type_boUser.GetProperty(property_userVM.Name);
                property_boUser.SetValue(boRegUser, property_userVM.GetValue(userVM));
            }

            return boRegUser;
        }

    }
}