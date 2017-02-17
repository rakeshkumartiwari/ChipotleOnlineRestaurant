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
            db.Ingredients.Add(new Ingredient { IngrdientId = "1", Item = new Fillings { Name = "Fillings" } });
            db.Ingredients.Add(new Ingredient { IngrdientId = "2", Item = new Toppings { Name = "Toppings" } });
            db.Ingredients.Add(new Ingredient { IngrdientId = "3", Item = new SideDrinks { Name = "Side and Drinks" } });
            
            db.SaveChanges();
        }


    }
}
