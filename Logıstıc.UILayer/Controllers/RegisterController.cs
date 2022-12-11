using Logıstıc.UILayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    public class RegisterController : Controller
    {
        DbLogisticEntities1 db=new DbLogisticEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblCustomer p)
        {
            db.TblCustomer.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Login");

        }
        public PartialViewResult PartialHead()
        {
            return PartialView();

        }
    }
}