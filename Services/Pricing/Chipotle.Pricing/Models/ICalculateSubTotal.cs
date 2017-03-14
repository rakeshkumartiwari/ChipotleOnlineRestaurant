namespace Chipotle.Pricing.Models
{
   public interface ICalculateSubTotal
   {
       double Calculate(Order order);
   }
}
