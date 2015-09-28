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
        private usermangerContext db = new usermangerContext();
        //
        // GET: /usermanager/
        public ActionResult Index()
        {
            var usr = new user("Narek", 10001, new DateTime(2001,5,9));
            var usr1 = new user("Barek", 10002, new DateTime(1991,6,5));
            var usr2 = new user("Karek", 10003, new DateTime(1999,5,6));          

            db.users.Add(usr);
            db.users.Add(usr1);
            db.users.Add(usr2);
            db.SaveChanges();


            List<user> user_list = new List<user>() { usr, usr1, usr2 };

            ViewBag.UList = user_list;

            return View();
        }

        //
        //  GET:    /usermanager/addUser
        public ActionResult addUser()
        {
            return View();
        }

        // POST:   /usermanager/addUser

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addUser([Bind(Include = "name, IDnumber,birthday")] user user)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            return View(user);
        }
    


	}
}