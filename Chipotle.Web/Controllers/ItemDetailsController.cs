using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chipotle.ItemDetails;

namespace Chipotle.Web.Controllers
{
    public class ItemDetailsController : Controller
    {
        public ActionResult Index()
        {
            IProvideItems objIProvideItem = new IProvideItems();
            var model = objIProvideItem.getAllItems();
           // return View("_ItemDetails_Dahsboard", model);
            return View("_ItemDetails_Dahsboard", model);
        }
    }
}