using ControleFrotas.Models.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ControleFrotas.Models.Insfrastructure.Context
{
    public class ControleFrotaContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<MotoristaVeiculo> MotoristasVeiculos { get; set; }

        public ControleFrotaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigurationEntities(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }

        protected void ConfigurationEntities(ModelBuilder modelBuilder)
        {
            ConfigurationTableMotoristaVeiculo(modelBuilder);

            ConfigurationTableMotorista(modelBuilder);

            ConfigurationEntitiesTableVeiculo(modelBuilder);

        }

        protected void ConfigurationTableMotoristaVeiculo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MotoristaVeiculo>()
                .HasKey(mv => new { mv.VeiculoId, mv.MotoristaId });

            modelBuilder.Entity<MotoristaVeiculo>()
                .Property(mv => mv.VeiculoId)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<MotoristaVeiculo>()
               .Property(mv => mv.MotoristaId)
               .HasColumnType("varchar(50)");

        }

        protected void ConfigurationTableMotorista(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Motorista>()
              .HasKey(m => m.MotoristaId);

            modelBuilder.Entity<Motorista>()
               .Property(m => m.MotoristaId)
               .HasColumnType("varchar(50)");

            modelBuilder.Entity<Motorista>()
               .Property(m => m.Nome)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder.Entity<Motorista>()
               .Property(m => m.Cnh)
               .HasColumnType("varchar(10)")
               .IsRequired();

            modelBuilder.Entity<Motorista>()
               .Property(m => m.Cnh)
               .HasColumnType("varchar(10)")
               .IsRequired();

            modelBuilder.Entity<Motorista>()
               .Property(m => m.ValidadeCnh)
               .HasColumnType("datetime")
               .IsRequired();

            modelBuilder.Entity<Motorista>()
               .Property(m => m.Ativo)
               .HasColumnType("bit")
               .IsRequired();

        }

        protected void ConfigurationEntitiesTableVeiculo(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
                .HasKey(mv => mv.VeiculoId);

            modelBuilder.Entity<Veiculo>()
               .Property(mv => mv.VeiculoId)
               .HasColumnType("varchar(50)");

            modelBuilder.Entity<Veiculo>()
               .Property(mv => mv.Modelo)
               .HasColumnType("varchar(50)");

            modelBuilder.Entity<Veiculo>()
               .Property(mv => mv.Placa)
               .HasColumnType("varchar(20)");

            modelBuilder.Entity<Veiculo>()
               .Property(mv => mv.Ano)
               .HasColumnType("int");

        }
    }
}
