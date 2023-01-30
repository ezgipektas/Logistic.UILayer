using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    [AllowAnonymous]
    public class ProfileController : Controller
    {
        // GET: Profile
        DbLogisticEntities1 db=new DbLogisticEntities1();
        public ActionResult Index()
        {
            var mail = Session["CustomerMail"].ToString();
            var values = db.TblCustomer.Where(x => x.CustomerMail == mail).FirstOrDefault();
            ViewBag.v1 = values.CustomerName;
            ViewBag.v2 = values.CustomerSurname;
            ViewBag.v3 = values.CustomerMail;
            ViewBag.v4 = values.CustomerPhone;
            return View(values);
        }
    }
}