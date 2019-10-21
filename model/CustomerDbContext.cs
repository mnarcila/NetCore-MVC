using Microsoft.EntityFrameworkCore;
using netcore.model;

namespace netcore.model
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Form> forms { get; set; }
    }
}