using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.MigrationsSample.Models;

namespace RnD.MigrationsSample.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _db = new AppDbContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult Basic()
        {
            return View();
        }

        public JsonResult CategoryRead()
        {
            var models = GetCategories();
            //List<Category> models = GetCategories();
            return Json(models, JsonRequestBehavior.AllowGet);
        }

        //private IEnumerable<Category> GetCategories()
        private List<Category> GetCategories()
        {
            var categories = _db.Categories.ToList().Select(c => new Category { CategoryId = c.CategoryId, Name = c.Name });

            //return categories.AsQueryable();
            return categories.ToList();
        }
    }
}
