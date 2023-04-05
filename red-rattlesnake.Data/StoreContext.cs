using red_rattlesnake.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace red_rattlesnake.Data;
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }
        public DbSet<Item> Items { get; set; }
    }
}