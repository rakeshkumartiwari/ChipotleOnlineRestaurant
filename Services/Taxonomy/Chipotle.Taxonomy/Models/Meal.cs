using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chipotle.Taxonomy.Models
{
   public class Meal
    {
        public int Id { get; set; }
        public string MealId { get; set; }
        public List<DefinitionType> Definitions { get; set; }

        public Meal(string mealId, List<DefinitionType> definations)
        {
            // TODO: Complete member initialization
            this.MealId = mealId;
            this.Definitions = definations;
        }
        

        public Meal()
        {

        }

    }
    
}
