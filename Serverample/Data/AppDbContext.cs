using Microsoft.EntityFrameworkCore;

namespace Serverample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Add your DbSets here when you create entity models
        // Example: public DbSet<User> Users { get; set; }
    }
}