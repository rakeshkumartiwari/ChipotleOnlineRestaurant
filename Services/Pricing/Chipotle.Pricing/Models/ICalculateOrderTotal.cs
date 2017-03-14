using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipotle.Pricing.Models
{
   public interface ICalculateOrderTotal
   {
       double Calculate(string orderId);
   }
}
