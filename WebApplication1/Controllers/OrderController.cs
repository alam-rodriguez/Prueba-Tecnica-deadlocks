using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly IOrderServicev2 _orderService;

        public OrderController(IOrderServicev2 orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var orders = _orderService.GetAll();
            return Ok(orders);
        }

        [HttpPost]
        public ActionResult Create(Orders customer)
        {
            var customers = _orderService.CreateOrder(customer);

            return CreatedAtAction(
                nameof(Get),
                new { id = customers.Id },
                customers
            );
        }

    }
}
