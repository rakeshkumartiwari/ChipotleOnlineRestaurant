using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chipotle.Taxonomy
{
    public class Toppings: IDefineIngredient 
    {
        public string Name { get; set; }
        public Toppings(string name)
        {
            Name = name;
        }
    }
}
