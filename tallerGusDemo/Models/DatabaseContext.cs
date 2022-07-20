using Microsoft.EntityFrameworkCore;

namespace tallerGusDemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Car> d_car { get; set; }
    }
}
