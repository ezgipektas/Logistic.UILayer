using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    public class CityController : Controller
    {
        DbLogisticEntities1 db=new DbLogisticEntities1();
        public ActionResult Index()
        {
            var values =db.TblCity.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(TblCity p)
        {
            db.TblCity.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCity(int id)
        {
            var values = db.TblCity.Find(id);
            db.TblCity.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCity(int id)
        {
            var values = db.TblCity.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCity(TblCity p)
        {
            var values = db.TblCity.Find(p.CityID);
            values.CityName = p.CityName;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}