using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Xunit;

using Chipotle.Taxonomy.Models;
using Chipotle.Taxonomy.Infrastructure;


namespace Chipotle.Taxonomy.Tests
{

    public class DefinitionSeederTest : IClassFixture<Context>
    {

        Context _context;
        public DefinitionSeederTest(Context context)
        {
            _context = context;
        }

        [Fact]

        public void ICanSeedToppings()
        {
            var taxonomySeeder = new TaxonomyDataSeeder();
            taxonomySeeder.SaveToppings("Toppings");


            var db = new TaxonomyDb();
            var savedDefinitions = db.Definitions.ToList();
            var savedTopping = savedDefinitions.Where(d => d.Name == "Toppings").First();
            Assert.NotNull(savedTopping);
            Assert.Equal("Toppings", savedTopping.Name);

        }


        [Fact]

        public void ICanSeedFillings()
        {
            var taxonomySeeder = new TaxonomyDataSeeder();
            taxonomySeeder.SeedFillings("Fillings");

            
            var db = new TaxonomyDb();

          

            var savedDefinitions = db.Definitions.ToList();
            var filling = savedDefinitions.Where(d => d.Name == "Fillings").First();
            Assert.NotNull(filling);
            Assert.Equal("Fillings", filling.Name);

        }


        [Fact]

        public void ICanSeedSideDrinks()
        {
            var taxonomySeeder = new TaxonomyDataSeeder();
            taxonomySeeder.SeedSideDrinks("Side and Drinks");

           
            var db = new TaxonomyDb();

     

            var savedSideDrinks = db.Definitions.ToList();
            var sideDrink = savedSideDrinks.Where(d => d.Name == "Side and Drinks").First();
            Assert.NotNull(sideDrink);
            Assert.Equal("Side and Drinks", sideDrink.Name);

        }
    }
}
