using Jet.Piranha.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace red_rattlesnake.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
    
        public Dbset<Item> Items {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Dbintializer.Initialize(builder);
        }
    }
}
