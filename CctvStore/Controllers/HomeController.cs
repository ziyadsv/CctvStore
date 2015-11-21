using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CctvStore.Models;

namespace CctvStore.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult OnlineSupport()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Title = "Admin Page";

            return View();
        }
        public ActionResult HomeSpecification()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string path = Server.MapPath("~/images" + file.FileName);
                file.SaveAs(path);
                ViewBag.path = path;
            }
            else
            {
                ViewBag.path = "NO file recieved";
            }
            return View();
        }
    }
}
