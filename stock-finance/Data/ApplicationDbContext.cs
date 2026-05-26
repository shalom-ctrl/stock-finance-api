using Microsoft.EntityFrameworkCore;
using stock_finance.Models;

namespace stock_finance.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextoptions)
            : base(dbContextoptions)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
