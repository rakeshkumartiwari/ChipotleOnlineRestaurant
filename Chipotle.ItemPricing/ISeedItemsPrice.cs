using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.ItemPricing
{
    public class ISeedItemsPrice : DbContext
    {
        public IDbSet<ItemPrice> ItemPrices { get; set; }
    }

    public class MyItenPricingInitializer : DropCreateDatabaseIfModelChanges<ISeedItemsPrice>
    {
        protected override void Seed(ISeedItemsPrice context)
        {
            context.ItemPrices.Add(new ItemPrice { Name = "BARRITO", Price = 250.89 });
            context.ItemPrices.Add(new ItemPrice { Name = "BARRITO BOWl", Price = 350.59 });
            context.SaveChanges();

        }
    }
}
