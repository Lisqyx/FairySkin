﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FairySkin.Controllers
{
    public class PurchaseOrderController : Controller
    {
        // GET: PurchaseOrder
        public ActionResult PurchaseOrder()
        {
            return View();
        }
        public ActionResult PurchaseOrderNew()
        {
            return View();
        }
    }
}