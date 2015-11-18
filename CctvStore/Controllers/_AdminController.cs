using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CctvStore.Controllers
{
    public class _AdminController : Controller
    {
        // GET: _Admin
        public ActionResult Admin()
        {
            ViewBag.Title = "Admin Page";

            return View();
        }
    }
}