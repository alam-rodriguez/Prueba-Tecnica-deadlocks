using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        //private static readonly List<Product> Products = new();
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{Id}")]
        public ActionResult GetOne([FromRoute] int Id)
        {
            var product = _productService.GetProduct(Id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(CreateProductDto dto)
        {

            var createProducto = _productService.CreateProduct(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = createProducto.Id },
                createProducto
            );
        }

        [HttpPut]
        public IActionResult Update(UpdateProductDto dto)
        {

            var updateProducto = _productService.UpdateProduct(dto);

            if (updateProducto == null)
            {
                return NotFound();
            }

            return Ok(updateProducto);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] int Id)
        {

            var deleteProducto = _productService.DeleteProduct(Id);

            if (deleteProducto == null)
            {
                return NotFound();
            }

            return Ok(deleteProducto);
        }


    }
}
