using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipotle.Pricing.Infrastructure;
using Chipotle.Pricing.Models;
using Xunit;

namespace Chipotle.Pricing.Test
{
   public class BillRepositoryTest
    {
       [Fact]
       public void CanSeedBill()
       {
           var billDataSeeder = new BillRepository();

           billDataSeeder.SaveBill("1",new List<LineItem>
           {
               new LineItem{ LineItemId = "Chicken", Quantity = 2},
               new LineItem{LineItemId = "Olives", Quantity = 2},
               new LineItem{LineItemId = "Soda", Quantity = 2}
           });


           var db = new PricingDb();
           var billSaved = db.Bills.Include(l => l.LineItems).Single(b => b.BillId == "1");
           Assert.NotNull(billSaved);
       }
    }
}
