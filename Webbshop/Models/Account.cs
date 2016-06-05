using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webbshop.Models
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public int userid { get; set; }
        public bool admin { get; set; }
    }
}