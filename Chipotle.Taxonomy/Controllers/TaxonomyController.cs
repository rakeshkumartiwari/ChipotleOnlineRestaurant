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
            return new List<Item>{
            new Item{ ItemId="1", Type="Filling"},

            new Item{ ItemId="2", Type="Toppings"}
            }.Where(c => c.ItemId == itemId).ToList();

        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Type { get; set; }

    }
}
