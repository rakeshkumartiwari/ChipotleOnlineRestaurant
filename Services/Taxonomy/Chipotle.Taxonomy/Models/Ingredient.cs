namespace Chipotle.Taxonomy.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string IngredientId { get; set; }
        public string DefinitionId { get; set; }
        public Ingredient(string ingredientId, string definitionId)
        {
            IngredientId = ingredientId;
            DefinitionId = definitionId;
        }
      
        public Ingredient()
        {

        }
    }
}
