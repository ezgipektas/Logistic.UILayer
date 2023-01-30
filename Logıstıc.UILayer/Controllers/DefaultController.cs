using Logıstıc.UILayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Logıstıc.UILayer.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbLogisticEntities1 db = new DbLogisticEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult Navbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            ViewBag.v1 = db.TblCustomer.Count();
            ViewBag.v2 = db.TblOrder.Count();
            ViewBag.v3 = db.TblCity.Count();
            ViewBag.v4 = db.TblTestimonial.Count();
            return PartialView();
        }
    }
}
