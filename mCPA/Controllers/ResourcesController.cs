using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mCPA.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult EBooks()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }
    }
}