using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using simplest_new.Models;

namespace simplest_new.Controllers
{
    public class retrieveController : Controller
    {
        //
        // GET: /retrieve/
        public ActionResult Index()
        {

            var db = new usermangerContext();

            var query = from b in db.users orderby b.name select b;

            ViewBag.UListdb = query;

            return View();
        }
	}
}