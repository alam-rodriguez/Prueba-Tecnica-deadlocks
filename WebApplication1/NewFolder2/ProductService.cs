using WebApplication1.Dtos;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.NewFolder2
{
    public class ProductService : IProductService
    {
        private static readonly List<Product> Products = new();

        public List<Product> GetProducts()
        {
            return Products;
        }

        public Product? GetProduct(int Id)
        {
            if(!Products.Any(x => x.Id == Id))
            {
                return null;
            }
            return Products.Where(x => x.Id == Id).ToList()[0];
        }

        public Product CreateProduct(CreateProductDto dto)
        {

            var newProducto = new Product
            {
                Id = Products.Count + 1,
                CreatedAt = DateTime.UtcNow,
                IsActive = true,
                Name = dto.Name,
                Stock = dto.Stock,
                Price = dto.Price
            };

            Products.Add(newProducto);

            return newProducto;
        }

        public Product? UpdateProduct(UpdateProductDto dto)
        {
            var product = Products.FirstOrDefault(x => x.Id == dto.Id);

            if (product == null)
            {
                return null;
            }

            product.Name = dto.Name;
            product.Stock = dto.Stock;
            product.Price = dto.Price;

            return product;
        }

        public Product? DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return null;
            }

            Products.Remove(product);

            return product;
        }

    }
}
