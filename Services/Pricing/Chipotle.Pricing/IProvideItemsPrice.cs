using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.Pricing
{
    public class IProvideItemsPrice
    {
        public List<ItemPrice> getAllIemsPrice(int id)
        {
            ISeedItemsPrice db = new ISeedItemsPrice();
            return db.ItemPrices.Where(i => i.Id == id).ToList();
        }

    }
}
