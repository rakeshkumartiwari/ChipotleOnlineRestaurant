using Chipotle.ItemPricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chipotle.Web.Controllers
{
    public class ItemPriceController : Controller
    {
        // GET: ItemPrice
        public ActionResult Index(int id)
        {
            IProvideItemsPrice objIProvideItemsPrice = new IProvideItemsPrice();
            var model = objIProvideItemsPrice.getAllIemsPrice(id);
            return View("_ItemPrice",model);
        }
    }
}