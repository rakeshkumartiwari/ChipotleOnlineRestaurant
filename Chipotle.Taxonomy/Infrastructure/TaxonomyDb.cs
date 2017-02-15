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
        public IDbSet<Definition> Definitions { get; set; }
    }
}