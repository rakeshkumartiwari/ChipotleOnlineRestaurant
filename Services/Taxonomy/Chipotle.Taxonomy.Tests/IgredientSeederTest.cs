using Chipotle.Taxonomy.Infrastructure;
using Chipotle.Taxonomy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chipotle.Taxonomy.Tests
{
    public class IngredientSeederTest 
    {
        
        [Fact]
        public void ICanSeedIngredient()
        {
            var db = new TaxonomyDb();
            db.Ingredients.Add(new Ingredient { IngrdientId = "1", Definitions = new Fillings { Id = 1} });
            db.Ingredients.Add(new Ingredient { IngrdientId = "2", Definitions = new Toppings { Id = 2} });
            db.Ingredients.Add(new Ingredient { IngrdientId = "3", Definitions = new SideDrinks { Id = 3} });
            
            db.SaveChanges();
        }


    }
}
