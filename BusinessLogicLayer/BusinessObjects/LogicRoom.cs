﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BusinessObjects
{
    public class LogicRoom
    {
        public int RoomID { get; set; }
        public int RoomNum { get; set; }
        public string GuestName { get; set; }
        public decimal Price { get; set; }
        public int UserID { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public string RoomType { get; set; }
        public bool Smoking { get; set; }
        public bool Pets { get; set; }
    }
}