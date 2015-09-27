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
            var usr = new user("Narek", 10001);
            var usr1 = new user("Barek", 10002);
            var usr2 = new user("Karek", 10003);

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