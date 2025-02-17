using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(c=>c.Codigo);
            modelBuilder.Entity<Categoria>().Property(c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Produto>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Produto>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Fornecedor>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Fornecedor>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Secretaria>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Secretaria>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Entrada>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Entrada>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<Saida>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Saida>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<ItensEntrada>().HasKey(c => c.Codigo);
            modelBuilder.Entity<ItensEntrada>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            modelBuilder.Entity<ItensSaida>().HasKey(c => c.Codigo);
            modelBuilder.Entity<ItensSaida>().Property(propertyExpression: static c => c.Codigo).ValueGeneratedOnAdd();
            




        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Secretaria> Secretaria { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<ItensEntrada> itensEntrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<ItensSaida> ItensSaida { get; set; }

    }
}
