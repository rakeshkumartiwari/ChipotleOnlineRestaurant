using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chipotle.Pricing.Models
{
    public class CalculateSubTotal:ICalculateSubTotal
    {
        public double Calculate(Order order)
        {
            return order.CalculateSubTotal();
        }
    }
}