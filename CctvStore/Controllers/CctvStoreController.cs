using CctvStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CctvStore.Controllers
{
    public class CctvStoreController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CctvStore
        [ChildActionOnly]
        public ActionResult SubCategoryMenu()
        {
            var subcategories = db.SubCategories.ToList();
            return PartialView(subcategories);
        }
    }
}