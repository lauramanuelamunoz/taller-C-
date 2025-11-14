using CRUDNativo.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNativo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación Cliente - Venta
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Ventas)
                .HasForeignKey(v => v.ClienteId);

            // Relación Producto - Venta
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Producto)
                .WithMany(p => p.Ventas)
                .HasForeignKey(v => v.ProductoId);
        }
    }
}
