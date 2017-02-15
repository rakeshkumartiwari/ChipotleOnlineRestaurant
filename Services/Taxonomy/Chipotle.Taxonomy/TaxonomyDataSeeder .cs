using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using Chipotle.Taxonomy.Models;
using Chipotle.Taxonomy.Infrastructure;

namespace Chipotle.Taxonomy
{
    public class TaxonomyDataSeeder 
    {
        TaxonomyDb db ;
        public TaxonomyDataSeeder()
        {
            db = new TaxonomyDb();
        }

        public void SaveToppings(string name)
        {
            var topping = new Toppings(name);

            db.Definitions.Add(topping);
            db.SaveChanges();
        }

        public void SeedFillings(string name)
        {
            var topping = new Fillings(name);

            db.Definitions.Add(topping);
            db.SaveChanges();
        }

        public void SeedSideDrinks(string name)
        {
            var topping = new SideDrinks(name);

            db.Definitions.Add(topping);
            db.SaveChanges();
        }
    }
}
