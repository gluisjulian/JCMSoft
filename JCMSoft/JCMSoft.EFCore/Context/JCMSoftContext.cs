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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());
        }
    }
}
