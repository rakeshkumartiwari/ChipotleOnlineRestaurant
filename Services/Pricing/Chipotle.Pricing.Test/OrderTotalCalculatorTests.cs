using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipotle.Pricing.Models;
using Xunit;

namespace Chipotle.Pricing.Test
{

    //var arr = new Array(); 
    //arr["order1"]= order;
    // var users = [];

    //get(userid) { return this.users[userid];}
    //save(user) {  this.users[user.userid]= user;}


    public class OrderTotalCalculatorTests
    {
        public void I_Can_Calculate_Total_For_An_Order()
        {
            const string orderId = "1";
            const string stateName = "NJ";
            var lineItems = new List<LineItem> { new LineItem { Id = 12, ItemId = "P1", LineItemId = "12", Quantity = 2, UnitPrice = 20 } };
            var order = new Order(orderId, lineItems, stateName);
            var orderRepository = new OrderInMemoryRepository();

            var taxDirectoryRepsitory = new TaxDirectoryInMemoryRepository();
            var taxDirectory = new TaxDirectory("NJ", 10);

            orderRepository.SaveOrder(order);

            taxDirectoryRepsitory.SaveTaxDirectory(taxDirectory);

            var orderTotalCalculator = new OrderTotalCalculator(orderRepository, new TaxDirectoryInMemoryRepository());

            var total = orderTotalCalculator.Calculate(orderId);

            Assert.Equal(44, total);
        }
    }
}
