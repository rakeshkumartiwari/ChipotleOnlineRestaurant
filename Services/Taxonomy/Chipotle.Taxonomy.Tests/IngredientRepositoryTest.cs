using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using Chipotle.Taxonomy.Infrastructure;
using Chipotle.Taxonomy.Models;

namespace Chipotle.Taxonomy.Models
{
  public  class IngredientRepositoryTest
    {
       [Fact]
        public void ICanSeedIngredient()
        {
            var ingredientDataSeeder = new IngredientRepository();
            ingredientDataSeeder.SaveIngrdient("Chicken", "Fillings");
            ingredientDataSeeder.SaveIngrdient("Olives", "Toppinsg");
            ingredientDataSeeder.SaveIngrdient("Soda", "Sides and Driks");

            var db = new TaxonomyDb();
            var saveIngredients = db.Ingredients.ToList();
            Assert.NotNull(saveIngredients);
            
            Assert.Equal(3, saveIngredients.Count);
           
            Assert.Equal(1, saveIngredients.Count(f => f.IngredientId == "Chicken"));
            Assert.Equal("Fillings", saveIngredients.Where(c => c.IngredientId == "Chicken").Single().DefinitionId);

            Assert.Equal(1, saveIngredients.Count(f => f.IngredientId == "Olives"));
            Assert.Equal("Toppinsg", saveIngredients.Where(c => c.IngredientId == "Olives").Single().DefinitionId);
            Assert.Equal(1, saveIngredients.Count(f => f.IngredientId == "Soda"));
            Assert.Equal("Sides and Driks", saveIngredients.Where(c => c.IngredientId == "Soda").Single().DefinitionId);
        }
    }
}
