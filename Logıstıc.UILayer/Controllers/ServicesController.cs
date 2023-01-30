using Logıstıc.UILayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logıstıc.UILayer.Controllers
{
    [AllowAnonymous]
    public class ServicesController : Controller
    {
        DbLogisticEntities1 db = new DbLogisticEntities1();
        public ActionResult Index()
        {
            return View();
        }
    }
}
