﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Data
{
   public class UserDao
    {
       public User user;
        public UserDao()
        {
            user = new User();
            user.ID = 1;
            user.UserName = "admin";
            user.PassWord = "admin";
            user.Remember = true;

            
        }
    }
}
