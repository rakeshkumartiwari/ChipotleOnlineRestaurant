
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chipotle.Taxonomy.Models
{
    public class Definition : IDefineIngredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}