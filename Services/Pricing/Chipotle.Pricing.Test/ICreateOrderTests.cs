using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipotle.Pricing.Infrastructure;
using Chipotle.Pricing.Models;
using Xunit;

namespace Chipotle.Pricing.Test
{
    public class OrderCreater : ICreateOrder
    {
        private readonly IOrderRepository _orderRepository;

        public OrderCreater(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Create(string orderId)
        {
            var order = new Order(orderId);
            _orderRepository.SaveOrder(order);
        }
    }

    public interface ICreateOrder
    {
        void Create(string orderId);
    }

    public class CreateOrderTests
    {

        private OrderCreater OrderCreater { get; set; }

        public void CanCreateOrderWithOrderId()
        {
            const string orderId = "12";
            var orderRepository = new OrderInMemoryRepository();

            OrderCreater = new OrderCreater(orderRepository);
            OrderCreater.Create(orderId);

            Assert.NotNull(orderRepository.GetOrder("12"));
        }
    }
}
