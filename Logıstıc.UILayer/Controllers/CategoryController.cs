using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    public class CategoryController : Controller
    {
        DbLogisticEntities1 db=new DbLogisticEntities1();
        public ActionResult Index()
        {
           var values= db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory p)
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}