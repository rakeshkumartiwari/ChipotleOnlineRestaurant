using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
   public class PricingDb:DbContext
    {
        public PricingDb():base("Chipotle.PricingDb")
        {
            Database.SetInitializer<PricingDb>(new DropCreateDatabaseAlways<PricingDb>());
        }
        public IDbSet<ItemPrice> ItemPrices { get; set; }
    }
}
