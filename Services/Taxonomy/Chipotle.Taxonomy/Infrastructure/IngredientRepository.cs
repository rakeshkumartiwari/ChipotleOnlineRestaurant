using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Chipotle.Taxonomy.Models;

namespace Chipotle.Taxonomy.Infrastructure
{
    public class IngredientRepository
    {
        TaxonomyDb db;
        public IngredientRepository()
        {
             db = new TaxonomyDb();
        }
        public void SaveIngrdient(string ingerdientId, string definitionId)
        {
            var ingredient = new Ingredient(ingerdientId, definitionId);
            db.Ingredients.Add(ingredient);
            db.SaveChanges();
        }

    }
}