using Microsoft.EntityFrameworkCore;

namespace BlueHorizon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ia> Ias { get; set; }
        public DbSet<Organizacao> Organizacoes { get; set; }
        public DbSet<Registro> Registros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração de relacionamentos e constraints
        }
    }
}
