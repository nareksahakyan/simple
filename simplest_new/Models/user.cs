using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simplest_new.Models
{
    public class user
    {
        public int userID { get; set; }
        public virtual string name { get; set; }
        public virtual int IDnumber { get; set; }
        public DateTime birthday { get; set; }

        public user() { }

        public user(string uname, int idnumber , DateTime bday)
        {
            name = uname;
            IDnumber = idnumber;
            birthday = bday;
            
           }

    }
}