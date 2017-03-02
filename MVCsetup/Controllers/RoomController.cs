using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;
using BusinessLogicLayer;
using BusinessLogicLayer.BusinessObjects;

namespace Hotel.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateRoomReserve()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateRoomReserve(RoomViewModel RoomVM)
        {

            return View();
        }
    }
}