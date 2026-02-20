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

        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        public void UpdateProduct(Product product)
        {
            Product product2 = GetProduct(product.Id);
            product2.Name = product.Name;
            product2.Category = product.Category;
            product2.RetailPrice = product.RetailPrice;
            product2.PurchasePrice = product.PurchasePrice;
        }
    }
}
