using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Chipotle.Pricing.Models;

namespace Chipotle.Pricing.Infrastructure
{
    public class OrderRepository
    {
        private PricingDb db;

        public OrderRepository()
        {
            db = new PricingDb();
        }

        public void SaveOrder(string billId, List<LineItem> lineItems,string stateName)
        {
            var order = new Order(billId, lineItems,stateName);
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public Order GetOrder(string orderId)
        {
            var orders = db.Orders.Include(l => l.LineItems).Single(b => b.OrderId == orderId);
            return orders;
        }

        public double GetSubTotal(Order order)
        {
            double subTotal = 0.0;
            foreach (var item in order.LineItems)
            {
                subTotal += item.UnitPrice*item.Quantity;
            }
            return subTotal;
        }

        public double GetTotal(Order order,double tax)
        {
            double total = 0.0;
            total = GetSubTotal(order) + tax;
            return total;
        }
    }
}