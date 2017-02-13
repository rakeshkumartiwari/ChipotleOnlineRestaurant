using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.ItemDetails
{
   public class ISeedItems:DbContext
    {
        public void Seed(ISeedItems context)
        {
            context.Items.Add(new Item { Name = "BARRITO", Url = "~/Images/barrito.jpg" });
            context.Items.Add(new Item { Name = "BARRITO BOWL", Url = "~/Images/barritoBowl.jpg" });
            context.SaveChanges();
        }
        public IDbSet<Item> Items { get; set; }
    }
}
