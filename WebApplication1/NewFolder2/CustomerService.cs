using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.NewFolder2
{
    public class CustomerService : ICustomerService


    {
        // private static readonly List<CustomerModel> Customer = new List<CustomerModel>();
        private static readonly List<CustomerModel> Customer = new();


        public CustomerModel CreateCustomer(CustomerModel newCustomer)
        {
            Customer.Add(newCustomer);

            return newCustomer;
        }

        public CustomerModel DeleteCustomer()
        {
            throw new NotImplementedException();
        }

        public List<CustomerModel> GetAll()
        {
            return Customer;
        }

        public CustomerModel GetCustomerById()
        {
            throw new NotImplementedException();
        }

        public CustomerModel UpdateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
