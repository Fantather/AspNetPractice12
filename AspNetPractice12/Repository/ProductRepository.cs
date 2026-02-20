using AspNetPractice12.Data;
using AspNetPractice12.Interface;
using AspNetPractice12.Models;

namespace AspNetPractice12.Repository
{
    public class ProductRepository : IProduct
    {
        private ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }
    }
}
