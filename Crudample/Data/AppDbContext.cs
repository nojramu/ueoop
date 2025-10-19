using Microsoft.EntityFrameworkCore;

namespace BlazorSQLiteDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Student> Students => Set<Student>();
    }
}