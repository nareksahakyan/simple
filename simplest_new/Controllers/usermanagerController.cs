using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using simplest_new.Models;

namespace simplest_new.Controllers
{
    public class usermanagerController : Controller
    {
        //
        // GET: /usermanager/
        public ActionResult Index()
        {
            var usr = new user("Narek", 10001, new DateTime(2001,5,9));
            var usr1 = new user("Barek", 10002, new DateTime(1991,6,5));
            var usr2 = new user("Karek", 10003, new DateTime(1999,5,6));

            var db = new usermangerContext();

            db.users.Add(usr);
            db.users.Add(usr1);
            db.users.Add(usr2);
            db.SaveChanges();


            List<user> user_list = new List<user>() { usr, usr1, usr2 };

            ViewBag.UList = user_list;

            return View();
        }
	}
}