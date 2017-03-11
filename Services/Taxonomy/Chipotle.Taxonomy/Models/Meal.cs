using System.Collections.Generic;

namespace Chipotle.Taxonomy.Models
{
   public class Meal
    {
        public int Id { get; set; }
        public string MealId { get; set; }
        public List<DefinitionType> Definitions { get; set; }

        public Meal(string mealId, List<DefinitionType> definations)
        {
            
            MealId = mealId;
            Definitions = definations;
        }
        

        public Meal()
        {

        }

    }
    
}
