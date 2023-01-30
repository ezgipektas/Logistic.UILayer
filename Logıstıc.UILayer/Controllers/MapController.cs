using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    public class MapController : Controller
    {
        DbLogisticEntities1 db = new DbLogisticEntities1();
        // GET: Map
        public ActionResult Index()
        {
            var values = db.TblMap.ToList();
            return View(values);
        }
    }
}