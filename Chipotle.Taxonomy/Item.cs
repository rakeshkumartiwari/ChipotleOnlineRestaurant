using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chipotle.Taxonomy
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public Toppings Toppings { get; set; }
        public Fillings Fillings { get; set; }

    }

  
    public class Toppings
    {
        public int Id { get; set; }
        public List<string> ToppingsName { get; set; }

            

    }
    public class Fillings
    {
        public int Id { get; set; }
        public List<string> FillingsName { get; set; }
    }
}