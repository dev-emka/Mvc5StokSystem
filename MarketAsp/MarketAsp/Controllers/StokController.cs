using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketAsp.Models.EntityFramework;

namespace MarketAsp.Controllers
{
    public class StokController : Controller
    {
        // GET: Stok
        DbMarketStockEntities db=new DbMarketStockEntities();
        public ActionResult Index()
        {
            var stok=db.TblStok.ToList();
            return View(stok);
        }
    }
}