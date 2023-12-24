using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketAsp.Models.EntityFramework;

namespace MarketAsp.Controllers
{
    public class FiyatController : Controller
    {
        // GET: Fiyat
        DbMarketStockEntities db=new DbMarketStockEntities();
        [HttpGet]
        public ActionResult FiyatGuncelle()
        {
            List<SelectListItem> urunler= (from i in db.TblUrunler.ToList()
                                           select new SelectListItem
                                           {
                                               Text=i.UrunIsim,
                                               Value=i.UrunBarkod.ToString()
                                           }).ToList();
            ViewBag.urunler = urunler;
            
            return View();
        }
    }
}