using System.Collections.Generic;
using Chipotle.Pricing.Infrastructure;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Test
{
    public class OrderInMemoryRepository : IOrderRepository
    {
        static readonly IDictionary<string, Order> Orders = new Dictionary<string, Order>();
        public void SaveOrder(string orderId, List<LineItem> lineItems, string stateName)
        {

        }

        public Order GetOrder(string orderId)
        {
            return Orders[orderId];
        }

        public void SaveOrder(Order order)
        {
            Orders[order.OrderId] = order;
        }
    }
}