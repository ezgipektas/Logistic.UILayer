using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    [Authorize]
       
    public class OrderController : Controller
    {
        DbLogisticEntities1 db=new DbLogisticEntities1();
        
        // GET: Order
        public ActionResult Index()
        {
            var values = db.TblOrder.ToList();
            return View(values);
        }
        public ActionResult DeleteOrder(int id)
        {
            var values=db.TblOrder.Find(id);
            db.TblOrder.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
                
        }
    }
}