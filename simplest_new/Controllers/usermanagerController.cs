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

            ViewBag.item = usr;
            
            return View(usr);
        }
	}
}