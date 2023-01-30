using Logıstıc.UILayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Logıstıc.UILayer.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        
        DbLogisticEntities1 db = new DbLogisticEntities1();
        public ActionResult Inbox()
        {
            var mail = Session["CustomerMail"].ToString();
            var values = db.TblMessage.Where(x => x.MessageReceiver == mail).ToList();
            return View(values);
        }

        public ActionResult Outbox()
        {
            var mail = Session["CustomerMail"].ToString();
            var values = db.TblMessage.Where(x => x.MessageReceiver == mail).ToList();
            return View(values);

        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(TblMessage p)
        {
            var mail = Session["CustomerMail"].ToString();

            string mesajiGonderen = db.TblCustomer.Where(x => x.CustomerMail == mail).Select(y => y.CustomerName + " " + y.CustomerSurname).FirstOrDefault();

            string alici = db.TblCustomer.Where(x => x.CustomerMail == p.MessageReceiver).Select(y => y.CustomerName + " " + y.CustomerSurname).FirstOrDefault();

            p.ReceiverName = alici;
            p.SenderName = mesajiGonderen;
            p.MessageSender = mail;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Outbox");
        }
        public ActionResult MessageDetails(int id)
        {
            var values = db.TblMessage.Find(id);
            return View(values);
        }

    }
}