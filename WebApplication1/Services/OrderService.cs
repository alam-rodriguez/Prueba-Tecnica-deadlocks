using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.NewFolder2
{
    public class OrderService : IOrderServicev2


    {
        // private static readonly List<CustomerModel> Customer = new List<CustomerModel>();
        private static readonly List<Orders> Orders = new();

        public Orders CreateOrder(Orders newOrder)
        {
            Orders.Add(newOrder);

            return newOrder;
        }

        public Orders DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {
            return Orders;
        }

        public Orders GetOrderById()
        {
            throw new NotImplementedException();
        }

        public Orders UpdateOrder()
        {
            throw new NotImplementedException();
        }

    }
}
