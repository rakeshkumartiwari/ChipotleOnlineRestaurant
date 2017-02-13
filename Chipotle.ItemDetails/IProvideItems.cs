using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.ItemDetails
{
   public class IProvideItems
    {
        public List<Item> getAllItems()
        {
            ISeedItems db = new ISeedItems();
            return db.Items.ToList();

        }
    }
}
