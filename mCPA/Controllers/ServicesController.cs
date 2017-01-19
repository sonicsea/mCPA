using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mCPA.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Individual()
        {
            return View();
        }

        public ActionResult Business()
        {
            return View();
        }

        public ActionResult Resolution()
        {
            return View();
        }
    }
}