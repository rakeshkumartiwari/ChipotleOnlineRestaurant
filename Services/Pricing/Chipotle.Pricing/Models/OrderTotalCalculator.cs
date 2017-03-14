using Chipotle.Pricing.Infrastructure;

namespace Chipotle.Pricing.Models
{
     //1.Identify Dependancy
    //2.All dependancy should be visible.
    //3.Dependacy Always shoud be Interface.
    public class OrderTotalCalculator : ICalculateOrderTotal
    {
        private readonly IOrderRepository _repository;
        private readonly ITaxDirectoryRepository _taxDirectoryRepository;

        public OrderTotalCalculator(IOrderRepository repository,ITaxDirectoryRepository taxDirectoryRepository)
        {
            _repository = repository;
            _taxDirectoryRepository = taxDirectoryRepository;
        }

        public double Calculate(string orderId)
        {
            var order = _repository.GetOrder(orderId);
            var tax = _taxDirectoryRepository.GetTaxByStateName(order.StateName);
            return order.CalculateTotal(tax);
        }
    }
}