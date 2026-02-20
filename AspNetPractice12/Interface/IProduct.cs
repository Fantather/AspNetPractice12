using AspNetPractice12.Models;

namespace AspNetPractice12.Interface
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        Product GetProduct(int id);
        void UpdateProduct(Product product);
        void UpdateAll(Product[] products);
    }
}
