using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Chipotle.Taxonomy.Models;

namespace Chipotle.Taxonomy.Infrastructure
{
    public class DefinitionRepository
    {

        TaxonomyDb db;
        public DefinitionRepository()
        {
            db = new TaxonomyDb();
        }

        public void SaveToppings(string definitionId, string definitionName)
        {
            var topping = new Toppings(definitionId, definitionName);

            db.Definitions.Add(topping);
            db.SaveChanges();
        }

        public void SaveFillings(string definitionId, string definitionName)
        {
            var topping = new Fillings(definitionId, definitionName);

            db.Definitions.Add(topping);
            db.SaveChanges();
        }

        public void SaveSideDrinks(string definitionId, string definitionName)
        {
            var topping = new SideDrinks(definitionId, definitionName);

            db.Definitions.Add(topping);
            db.SaveChanges();
        }

    }
}