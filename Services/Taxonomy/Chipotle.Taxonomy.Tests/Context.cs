using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Chipotle.Taxonomy.Models;
using Chipotle.Taxonomy.Infrastructure;



namespace Chipotle.Taxonomy.Tests
{


    public class Context : IDisposable
    {
        void System.IDisposable.Dispose()
        {
            //after each test ends
            var taxonomyDb = new TaxonomyDb();
            var all = from d in taxonomyDb.Definitions select d;
            taxonomyDb.Definitions.RemoveRange(all);
            taxonomyDb.SaveChanges();
        }
        public Context()
        {
            // before each test start
        }

    }
}
