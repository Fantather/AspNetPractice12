using AspNetPractice12.Models;

namespace AspNetPractice12.Interface
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
    }
}
