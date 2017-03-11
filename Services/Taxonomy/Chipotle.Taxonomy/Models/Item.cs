namespace Chipotle.Taxonomy.Models
{
   public class Item
    {
        
       public int Id { get; set; }
       public string ItemId { get; set; }
       public ItemType ItemType { get; set; }

       public Item(string itemId, ItemType itemType)
       {
           ItemId = itemId;
           ItemType = itemType;
       }

       public Item()
       {
           
       }

       
    }
}
