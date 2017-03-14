using System.Collections.Generic;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public interface IOrderRepository
    {
        void SaveOrder(string orderId, List<LineItem> lineItems, string stateName);
        Order GetOrder(string orderId);
    }
}