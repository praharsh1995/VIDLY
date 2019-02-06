using System.Data.Entity;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
            : base("ApplicationDbContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }

}
