using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chipotle.Taxonomy.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string IngrdientId { get; set; }
        public Definition Item { get; set; }

       

    }


}
