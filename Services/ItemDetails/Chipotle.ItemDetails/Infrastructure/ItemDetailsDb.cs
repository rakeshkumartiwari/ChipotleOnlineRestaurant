using System.Data.Entity;
using Chipotle.ItemDetails.Models;

namespace Chipotle.ItemDetails.Infrastructure
{
    public class ItemDetailsDb:DbContext
    {
        public ItemDetailsDb():base("Chipotle.ItemDetails")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ItemDetailsDb>());
        }
        public DbSet<ItemDetail> ItemDetails { get; set; }
    }
}