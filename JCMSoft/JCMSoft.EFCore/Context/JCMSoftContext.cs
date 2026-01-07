using JCMSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JCMSoft.EFCore.Context
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
            
        //}

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(x => {
                x.Property(x => x.Nome).HasMaxLength(100).IsRequired();
                x.Property(x => x.Descricao).HasMaxLength(200).IsRequired();

                x.HasData(
                    new Departamento { DepartamentoId = 1, Nome = "Financeiro", Descricao = "Gestão de Finanças" },
                    new Departamento { DepartamentoId = 2, Nome = "Marketing", Descricao = "Promoção de Projetos" },
                    new Departamento { DepartamentoId = 3, Nome = "RH", Descricao = "Recursos Humanos" },
                    new Departamento { DepartamentoId = 4, Nome = "Suporte", Descricao = "Atendimento ao cliente" }
                    );
            });

            modelBuilder.Entity<Funcionario>(x =>
            {
                x.Property(x => x.Nome).HasMaxLength(100).IsRequired();
                x.Property(x => x.Cargo).HasMaxLength(100).IsRequired();
            });
        }
    }
}
