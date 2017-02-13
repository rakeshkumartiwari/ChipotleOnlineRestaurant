using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chipotle.Taxonomy
{
    public class ISeedTaxonomy
    {
        public List<Item> getAllItem()
        {
            List<Item> listItem = new List<Item> { 
            
            new Item{ ItemId="1", Fillings = new Fillings{ FillingsName = new List<string>{"chicken","Rice","Steak","BarbaCoa"} }
            },

            new Item{ ItemId="2",Toppings = new Toppings{ToppingsName= new List<string>{"Guacamole","Tomatillo"} }
            }
           };
            return listItem;

        }
    }
}
