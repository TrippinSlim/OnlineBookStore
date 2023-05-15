using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Order> Orders => Set<Order>();
    }
}
