using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public interface IPricingDb : IDisposable, IObjectContextAdapter
    {
        IDbSet<ItemPrice> ItemPrices { get; set; }
        IDbSet<Order> Orders { get; set; }
        IDbSet<LineItem> LineItems { get; set; }
        IDbSet<TaxDirectory> TaxDirectories { get; set; }
    }
}