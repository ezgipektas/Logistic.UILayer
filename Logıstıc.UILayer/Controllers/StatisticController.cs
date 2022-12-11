using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logıstıc.UILayer.Models;

namespace Logıstıc.UILayer.Controllers
{
    public class StatisticController : Controller
    {
        DbLogisticEntities1 db=new DbLogisticEntities1();

        public ActionResult Index()
        {
            //v1 toplam sipariş sayısı
            //v2 , 1 numaralı müşterinin sipariş sayısı
            //v3 Ankara'Id değeri
            //v4 çıkış şehri ankara olan sipariş sayısı
            //v5 siparişlerden kazanılan toplam para
            //v6 ortalama sipariş tutarı
            //v7 kitap ürününün toplam tutarı
            ViewBag.v1 = db.TblOrder.Count();
            ViewBag.v2 = db.TblOrder.Where(x => x.OrderCustomer == 1).Count();
            ViewBag.v3 = db.TblCity.Where(x => x.CityName == "Ankara").Select(y => y.CityID).FirstOrDefault();
            int id = db.TblCity.Where(x => x.CityName == "Ankara").Select(y => y.CityID).FirstOrDefault();
            ViewBag.v4 = db.TblOrder.Where(x => x.FromCity == id).Count();
            ViewBag.v5 = db.TblOrder.Sum(x => x.OrderPrice);
            ViewBag.v6 = db.TblOrder.Average(x => x.OrderPrice);
            ViewBag.v7 = db.TblOrder.Where(x => x.OrderProduct == "Kitap").Sum(y => y.OrderPrice);
            return View();


        }
    }
}