using PracticeRabbitMQ.Models;

namespace PracticeRabbitMQ.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public Product AddProduct(Product product);
        public Product UpdateProduct(Product product);
        public bool DeleteProduct(int id);
    }
}
