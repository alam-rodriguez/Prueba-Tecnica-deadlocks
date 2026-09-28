using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int Id);

        Product CreateProduct(CreateProductDto product);

        Product UpdateProduct(UpdateProductDto product);

        Product DeleteProduct(int Id);
    }
}
