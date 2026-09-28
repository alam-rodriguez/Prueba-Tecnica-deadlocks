using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICustomerService
    {
        List<CustomerModel> GetAll();
        CustomerModel CreateCustomer(CustomerModel newCustomer);
        CustomerModel GetCustomerById();
        CustomerModel UpdateCustomer();
        CustomerModel DeleteCustomer();
    }
}
