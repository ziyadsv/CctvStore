using CctvStore.Models;
using CctvStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CctvStore.Controllers
{
    public class _CctvStoreController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CctvStore
        [ChildActionOnly]
        public ActionResult SubCategoryMenu()
        {
            var subcategories = db.SubCategories.ToList();
            return PartialView(subcategories);
        }

        public ActionResult ProductList(string Categoriesstring, string SubCategoriesstring, string ProductString)
        {
            var viewmodel = new CatalogCategoryVM();
            var catalog = db.Catalogs.ToList();
            var category = db.Categories.ToList();
            var subcategory = db.SubCategories.ToList();                
            var product = db.Products.ToList();
            viewmodel.Catalogs = catalog;
            viewmodel.Category = category;
            viewmodel.SubCategory = subcategory;
            viewmodel.Product = product;

            if (Categoriesstring != null)
            {
                ViewBag.category = Categoriesstring;
                viewmodel.Category = viewmodel.Catalogs.Where(e => e.CatalogName == Categoriesstring).SingleOrDefault().Categories;
            }

            if (SubCategoriesstring != null)
            {
                ViewBag.subcategory = SubCategoriesstring;
                viewmodel.SubCategory = viewmodel.Category.Where(r => r.CategoryName == SubCategoriesstring).Single().SubCategories;
              
            }

            if(ProductString != null)
            {
                ViewBag.Product = ProductString;
                viewmodel.Product = viewmodel.SubCategory.Where(d => d.SubCategoryName == ProductString).SingleOrDefault().Products;
            }
            return View(viewmodel);
        }
    }
}