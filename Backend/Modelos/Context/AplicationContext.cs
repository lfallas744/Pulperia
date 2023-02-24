using Microsoft.EntityFrameworkCore;


namespace Backend.Modelos.Context
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }

        //TODO: Ver estandares de c#
        DbSet<Producto> _productos { get; set; } 
        DbSet<Usuario> _usuarios { get; set; }
        DbSet<Proveedor> _proveedores { get; set; }


    }
}

