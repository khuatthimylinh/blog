using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        public ActionResult Statis()
        {
            return View();
        }
        public ActionResult index()
        {
            return View();
        }
        public ActionResult post()
        {
            return View();
        }
    }
}