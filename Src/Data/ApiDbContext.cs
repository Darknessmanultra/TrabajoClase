using Microsoft.EntityFrameworkCore;
using TrabajoClases.Src.Models;

namespace TrabajoClases.Src.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) {}

        public DbSet<Producto> Productos {get;set;}
        public DbSet<Tienda> Tiendas {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}