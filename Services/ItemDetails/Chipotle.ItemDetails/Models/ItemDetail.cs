namespace Chipotle.ItemDetails.Models
{
  public  class ItemDetail
    {
      public int Id { get; set; }
      public string ItemId { get; set; }
      public string Name { get; set; }

      public ItemDetail(string itemId, string name)
      {
          this.ItemId = itemId;
          this.Name = name;
      }

      public ItemDetail()
      {
          
      }
    }
}
