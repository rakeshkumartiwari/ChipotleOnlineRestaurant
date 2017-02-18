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
            var taxonomySeeder = new TaxonomyDataSeeder();
            taxonomySeeder.SaveIngrdient("1", "Fillings");

            var db = new TaxonomyDb();
            var saveIngredient = db.Ingredients.ToList();
            var savedFillings = db.Ingredients.Where(f => f.DefinitionId == "Fillings").First();
            Assert.NotNull(savedFillings);
            Assert.Equal("Fillings", savedFillings.DefinitionId);
        }
    }
}
