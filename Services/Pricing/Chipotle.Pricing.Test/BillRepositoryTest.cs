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
       public void CanSaveBill()
       {
           var billDataSeeder = new BillRepository();

           billDataSeeder.SaveBill("1",new List<LineItem>
           {
               new LineItem{ LineItemId = "Chicken", Quantity = 2},
               new LineItem{LineItemId = "Olives", Quantity = 2},
               new LineItem{LineItemId = "Soda", Quantity = 2}
           });


           
           var savedBill = billDataSeeder.GetBill("1");
           Assert.NotNull(savedBill);
       }
    }
}
