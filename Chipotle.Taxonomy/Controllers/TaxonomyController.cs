using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chipotle.Taxonomy.Controllers
{
    public class TaxonomyController : ApiController
    {
        [HttpGet]
        public List<Item> GetAll(string itemId)
        {
            ISeedTaxonomy db = new ISeedTaxonomy();
            var model = db.getAllItem().Where(c => c.ItemId == itemId).ToList();
            
            return model;

        }
    }
   
}
