using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipotle.Taxonomy.Infrastructure;
using Xunit;
using Chipotle.Taxonomy.Models;
using System.Data.Entity;

namespace Chipotle.Taxonomy.Tests
{
    public class Context {

        public  Context()
        {
            var taxonomyDb = new TaxonomyDb();
            var all = from c in taxonomyDb.Defini select c;
            dataDb.Table.RemoveRange(all);
            dataDb.SaveChanges();
        }
    
    }
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

            var topping = new Toppings("Toppings");
            var db = new TaxonomyDb();

            db.Definitions.Add(topping);
            db.SaveChanges();

            var savedTopping = db.Definitions.ToList();
            Assert.Equal(1, savedTopping.Count);
        }


        //[Fact]

        public void ICanReadToppings()
        {
            var topping = new Toppings("Toppings");
            var db = new TaxonomyDb();
            db.Definitions.Add(topping);
            db.SaveChanges();
        }
    }
}
