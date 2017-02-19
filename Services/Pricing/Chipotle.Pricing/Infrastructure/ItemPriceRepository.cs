using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
  public  class ItemPriceRepository
    {
        private PricingDb db;

        public ItemPriceRepository()
        {
                db=new PricingDb();
        }

        public void SaveItemPrice(string itemId,double price)
        {
            var itemPrice = new ItemPrice(itemId, price);

            db.ItemPrices.Add(itemPrice);
            db.SaveChanges();
        }
    }
}
