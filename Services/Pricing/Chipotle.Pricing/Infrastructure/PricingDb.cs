using System.Data.Entity;
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
       public IDbSet<Order> Orders { get; set; }
       public IDbSet<LineItem> LineItems { get; set; }
       public IDbSet<TaxDirectory> TaxDirectories { get; set; }
    }
}
