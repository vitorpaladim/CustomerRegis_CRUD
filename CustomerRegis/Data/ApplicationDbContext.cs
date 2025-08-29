using Microsoft.EntityFrameworkCore;
using CustomerRegis.Models;

    namespace CustomerRegis.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Customer> Customer { get; set; }
        }
    }
