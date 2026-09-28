using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        [HttpPost]
        public ActionResult Create(CustomerModel customer)
        {
            var customers = _customerService.CreateCustomer(customer);

            return CreatedAtAction(
                nameof(Get),
                new { id = customers.Id },
                customers
            );
        }

    }
}
