using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simplest_new.Models
{
    public class user
    {
        public int userID { get; set; }
        public string name { get; set; }
        public int IDnumber { get; set; }

        public user(string uname, int idnumber)
        {
            name = uname;
            IDnumber = idnumber;
            
           }

    }
}