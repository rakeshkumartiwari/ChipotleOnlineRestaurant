using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chipotle.Taxonomy.Models
{
    public class Ingredient
    {

        public Ingredient(string ingredientId, string definitionId)
        {
            this.IngredientId = ingredientId;
            this.DefinitionId = definitionId;
        }
        public int Id { get; set; }
        public string IngredientId { get; set; }
        public string DefinitionId { get; set; }
        public Ingredient()
        {

        }
    }
}
