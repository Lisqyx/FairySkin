using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FairySkin.Controllers
{
    public class StocksController : Controller
    {
        // GET: Stocks
        public ActionResult StockAdjustment()
        {
            return View();
        }
        public ActionResult StockAdjustmentNew()
        {
            return View();
        }
        public ActionResult StockReconciliation()
        {
            return View();
        }
        public ActionResult StockReplacement()
        {
            return View();
        }
        public ActionResult StockReplacementNew()
        {
            return View();
        }
        public ActionResult StockReturn()
        {
            return View();
        }
        public ActionResult StockReturnNew()
        {
            return View();
        }
        public ActionResult DefectiveStocksReport()
        {
            return View();
        }
        public ActionResult BranchTransfer()
        {
            return View();
        }
        public ActionResult BranchTransferNew()
        {
            return View(); 
        }
    }
}