
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chipotle.Taxonomy.Models
{
    public class Definition : IDefineIngredient
    {
        public Definition(string name)
        {
            if(string.IsNullOrWhiteSpace(name)) throw new Exception("Defintion needs name");
            Name = name;
        }
        public Definition()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

}