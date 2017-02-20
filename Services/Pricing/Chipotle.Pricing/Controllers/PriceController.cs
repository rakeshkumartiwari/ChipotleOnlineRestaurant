using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chipotle.Pricing.Infrastructure;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Controllers
{
    public class PriceController : ApiController
    {
        [HttpGet]
        public double Get()
        {
            
            var billRepo = new BillRepository();
            billRepo.SaveBill("1", new List<LineItem>
           {
               new LineItem{ LineItemId = "Chicken", Quantity = 2},
               new LineItem{LineItemId = "Olives", Quantity = 2},
               new LineItem{LineItemId = "Soda", Quantity = 2}
           });

            Bill bill = billRepo.GetBill("1");


            var itemRepo = new ItemPriceRepository();

            itemRepo.SaveItemPrice("Chicken",150.50);
            itemRepo.SaveItemPrice("Olives",79.50);
            itemRepo.SaveItemPrice("Soda", 35.75);

            var itemPrice = itemRepo.GetItemPrice();

            double total = (from items in bill.LineItems from item in itemPrice where items.LineItemId == item.ItemId select item.Price*items.Quantity).Sum();
            return total;
        }
    }
}
