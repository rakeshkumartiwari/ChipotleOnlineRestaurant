using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Xunit;

using Chipotle.Taxonomy.Models;
using Chipotle.Taxonomy.Infrastructure;


namespace Chipotle.Taxonomy.Models
{

    public class DefinitionRepositoryTest
    {
        [Fact]

        public void ICanSeedToppings()
        {
            var definitionDataSeeder = new DefinitionRepository();
            definitionDataSeeder.SaveToppings("1", "Toppings");


            var db = new TaxonomyDb();
            var savedDefinitions = db.Definitions.ToList();
            var savedTopping = savedDefinitions.Where(d => d.DefinitionName == "Toppings").First();
            Assert.NotNull(savedTopping);
            Assert.Equal("Toppings", savedTopping.DefinitionName);

        }


        [Fact]

        public void ICanSeedFillings()
        {
            var definitionDataSeeder = new DefinitionRepository();
            definitionDataSeeder.SaveFillings("1", "Fillings");


            var db = new TaxonomyDb();



            var savedDefinitions = db.Definitions.ToList();
            var filling = savedDefinitions.Where(d => d.DefinitionName == "Fillings").First();
            Assert.NotNull(filling);
            Assert.Equal("Fillings", filling.DefinitionName);

        }


        [Fact]

        public void ICanSeedSideDrinks()
        {
            var definitionDataSeeder = new DefinitionRepository();
            definitionDataSeeder.SaveSideDrinks("1", "Sides and Drinks");


            var db = new TaxonomyDb();



            var savedSideDrinks = db.Definitions.ToList();
            var sideDrink = savedSideDrinks.Where(d => d.DefinitionName == "Sides and Drinks").First();
            Assert.NotNull(sideDrink);
            Assert.Equal("Sides and Drinks", sideDrink.DefinitionName);

        }
    }

}