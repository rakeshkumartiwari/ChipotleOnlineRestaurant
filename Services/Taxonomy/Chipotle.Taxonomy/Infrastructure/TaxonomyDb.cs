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
        public DbSet<Definition> Definitions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<DefinitionType> DefinitionTypes { get; set; }
        
    }
}