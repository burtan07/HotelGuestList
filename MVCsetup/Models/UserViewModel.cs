﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class UserViewModel
    {
        public UserModel User { get; set; }
        public List<UserModel> Users { get; set; }
    }
}