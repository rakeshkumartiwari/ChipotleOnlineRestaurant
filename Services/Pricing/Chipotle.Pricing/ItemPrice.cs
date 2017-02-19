﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.Pricing
{
   public class ItemPrice
    {
       public ItemPrice(string itemId, double price)
       {
           this.ItemId = itemId;
           this.Price = price;
       }
        public int Id { get; set; }
        public string ItemId { get; set; }
        public double Price { get; set; }

       public ItemPrice()
       {
            
       }
    }
}
