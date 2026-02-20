using AspNetPractice12.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetPractice12.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> context) : base(context)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
