using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketAsp.Models.EntityFramework;

namespace MarketAsp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMarketStockEntities db=new DbMarketStockEntities();
        public ActionResult Index()
        {
            var urunler=db.TblUrunler.ToList();
            return View(urunler);
        }

        [HttpGet]
        public ActionResult YeniUrun()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(TblUrunler p)
        {
            db.TblUrunler.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}