﻿using Login.DataUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Data
{
   public class Const
    {
      static  public List<User> ListUser = new List<User>();
      static  public String Pathfile = String.Format(@"{0}\DanhSachUser.ini", Application.StartupPath);
      static  public List<String> CheckuserName = new List<string>();
      static public List<String> CheckEmail = new List<string>();
      static public User User = new User();
      static public User UserLogin = new User();
    }
}
