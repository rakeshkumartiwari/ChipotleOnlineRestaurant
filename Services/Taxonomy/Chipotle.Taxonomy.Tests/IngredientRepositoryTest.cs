using System.Collections.Generic;
using System.Linq;
using Chipotle.Taxonomy.Infrastructure;
using Xunit;

namespace Chipotle.Taxonomy.Tests
{
    public class IngredientRepositoryTest : IClassFixture<Context>
    {
        private readonly Context _context;

        public IngredientRepositoryTest(Context context)
        {
            _context = context;
        }

        [Theory, MemberData("IngredientData")]
        public void CanSeedIngredient(string ingredientId, string definitionId)
        {
            var ingredientDataSeeder = new IngredientRepository();

            ingredientDataSeeder.SaveIngrdient(ingredientId, definitionId);
            var db = new TaxonomyDb();
            var saveIngredients = db.Ingredients.ToList();

            Assert.NotNull(saveIngredients);
            Assert.Equal(1, saveIngredients.Count(f => f.IngredientId == ingredientId));
            Assert.Equal(definitionId, saveIngredients.Single(c => c.IngredientId == ingredientId).DefinitionId);


        }
        public static IEnumerable<object[]> IngredientData
        {
            get
            {
                return new[]
                {
                    new object[] {"Chicken", "Fillings"},
                    new object[] {"Olives", "Toppinsg"},
                    new object[] {"Soda", "Sides and Driks"}
                };
            }
        }
    }
}
