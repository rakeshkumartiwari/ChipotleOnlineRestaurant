using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PricingDb _pricingDb;

        public OrderRepository(PricingDb pricingDb)
        {
            _pricingDb = pricingDb;
        }

        public void SaveOrder(string orderId, List<LineItem> lineItems, string stateName)
        {
            var order = new Order(orderId, lineItems, stateName);
            _pricingDb.Orders.Add(order);
            _pricingDb.SaveChanges();
        }

        public void SaveOrder(Order order)
        {
            var fetchedOrder = _pricingDb.Orders.Single(o => o.OrderId.Equals(order.OrderId));

            if (fetchedOrder == null)
            {
                _pricingDb.Orders.Add(order);
            }

            fetchedOrder.LineItems = order.LineItems;
            fetchedOrder.StateName = order.StateName;

            _pricingDb.SaveChanges();
        }

        public Order GetOrder(string orderId)
        {
            var orders = _pricingDb.Orders.Include(l => l.LineItems).Single(b => b.OrderId == orderId);
            return orders;
        }


    }
}