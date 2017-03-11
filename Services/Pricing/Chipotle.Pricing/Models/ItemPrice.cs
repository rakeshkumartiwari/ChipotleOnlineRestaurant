namespace Chipotle.Pricing.Models
{
    public class ItemPrice
    {
        public ItemPrice(string itemId, double price)
        {
            ItemId = itemId;
            Price = price;
        }
        public int Id { get; set; }
        public string ItemId { get; set; }
        public double Price { get; set; }

        public ItemPrice()
        {
                
        }
    }

   
}