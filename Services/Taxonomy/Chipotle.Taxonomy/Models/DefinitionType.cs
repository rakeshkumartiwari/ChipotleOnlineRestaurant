using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.Taxonomy.Models
{
    public class DefinitionType
    {
        public int Id { get; set; }
        public string DefinitionId { get; set; }


        public DefinitionType(string definitionId)
        {
            // TODO: Complete member initialization
            this.DefinitionId = definitionId;
        }


        public DefinitionType()
        {

        }
    }
}
