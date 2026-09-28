using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IOrderServicev2
    {
        List<Orders> GetAll();
        Orders CreateOrder(Orders newOrder);
        Orders GetOrderById();
        Orders UpdateOrder();
        Orders DeleteOrder();
    }
}
