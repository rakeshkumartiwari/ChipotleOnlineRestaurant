using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using Chipotle.Taxonomy.Infrastructure;
using Chipotle.Taxonomy.Models;

namespace Chipotle.Taxonomy.Tests
{
   public class MealRepositoryTest
    {
       [Fact]
       public void ICanSeedMeal()
       {
           var taxonomySeeder = new TaxonomyDataSeeder();
           taxonomySeeder.SaveMeal("1", new List<DefinitionType> { new DefinitionType { DefinitionId = "Fillings" } });
        
       }

       
    }
}
