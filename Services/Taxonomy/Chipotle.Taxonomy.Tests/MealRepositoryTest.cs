using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using Chipotle.Taxonomy.Infrastructure;
using Chipotle.Taxonomy.Models;
using System.Data.Entity;

namespace Chipotle.Taxonomy.Tests
{
    public class MealRepositoryTest
    {
        [Fact]
        public void ICanSeedMeal()
        {
            var mealDataSeeder = new MealRepository();
            mealDataSeeder.SaveMeal("BARRITO",
                new List<DefinitionType> {
              new DefinitionType { DefinitionId = "Fillings" },
               new DefinitionType{ DefinitionId = "Toppings"},
               new DefinitionType{ DefinitionId = "Sides and Drinks"} 
           });


            var db = new TaxonomyDb();
            var savedMeal = ((IDbSet<Meal>)(db.Meals)).Include(m=>m.Definitions).Single(f => f.MealId == "BARRITO");
            Assert.NotNull(savedMeal);
            Assert.NotNull(savedMeal.Definitions);
            Assert.Equal(3, savedMeal.Definitions.Count);
            Assert.Equal(1, savedMeal.Definitions.Count(f => f.DefinitionId == "Fillings"));
            Assert.Equal(1, savedMeal.Definitions.Count(f => f.DefinitionId == "Toppings"));
            Assert.Equal(1, savedMeal.Definitions.Count(f => f.DefinitionId == "Sides and Drinks"));
        }


    }
}
