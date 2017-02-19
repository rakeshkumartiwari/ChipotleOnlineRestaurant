using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Chipotle.Taxonomy.Models;

namespace Chipotle.Taxonomy.Infrastructure
{
    public class MealRepository
    {
        TaxonomyDb db;
        public MealRepository()
        {
            db = new TaxonomyDb();
        }
        public void SaveMeal(string mealId, List<DefinitionType> definations)
        {
            var meal = new Meal(mealId, definations);
            db.Meals.Add(meal);
            db.SaveChanges();
        }
    }
}