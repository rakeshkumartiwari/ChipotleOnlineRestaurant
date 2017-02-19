using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


using Chipotle.Taxonomy.Models;

namespace Chipotle.Taxonomy.Infrastructure
{
    public class TaxonomyDb : DbContext
    {
        public TaxonomyDb():base("Chipotle.TaxonomyDb")
        {
            Database.SetInitializer<TaxonomyDb>(new DropCreateDatabaseAlways<TaxonomyDb>());
        }
        public IDbSet<Definition> Definitions { get; set; }
        public IDbSet<Ingredient> Ingredients { get; set; }
        public IDbSet<Meal> Meals { get; set; }
        public IDbSet<DefinitionType> DefinitionTypes { get; set; }
        
    }
}