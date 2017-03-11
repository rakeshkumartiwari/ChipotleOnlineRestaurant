namespace Chipotle.Pricing.Models
{
   public class LineItem
    {
       public int Id { get; set; }
       public string LineItemId { get; set; }
       public string ItemId { get; set; }
       public double UnitPrice { get; set; }
       public int Quantity { get; set; }

     
       public LineItem()
       {
           
       }
    }
}