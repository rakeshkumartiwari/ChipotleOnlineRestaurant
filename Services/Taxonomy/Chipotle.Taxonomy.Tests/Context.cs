using System;
using System.Data.Entity;
using Chipotle.Taxonomy.Infrastructure;

namespace Chipotle.Taxonomy.Tests
{


    public class Context : IDisposable
    {
        void System.IDisposable.Dispose()
        {
            ////after each test ends
            //var taxonomyDb = new TaxonomyDb();
            //var all = from d in taxonomyDb.Definitions select d;
            //taxonomyDb.Definitions.RemoveRange(all);
            //taxonomyDb.SaveChanges();

            Database.SetInitializer(new DropCreateDatabaseAlways<TaxonomyDb>()); 
        }

        public Context()
        {
            // before each test start
        }

    }
}
