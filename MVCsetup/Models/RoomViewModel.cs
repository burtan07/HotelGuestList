using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class RoomViewModel
    {
        public RoomModel SingleRoom { get; set; }
        public List<RoomModel> RoomList { get; set; }
    }
}