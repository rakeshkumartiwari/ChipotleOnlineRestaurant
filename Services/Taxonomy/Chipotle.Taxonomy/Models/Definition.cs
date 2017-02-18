
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chipotle.Taxonomy.Models
{
    public class Definition : IDefineIngredient
    {
        public int Id { get; set; }
        public string DefinitionId { get; set; }
        public string DefinitionName { get; set; }
        
        public Definition(string definitionId, string definitionName)
        {
            DefinitionId = definitionId;
            DefinitionName = definitionName;
        }
        public Definition()
        {

        }
    }

}