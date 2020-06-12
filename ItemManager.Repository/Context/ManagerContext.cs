using ItemManager.Domain.Entities;
using ItemManager.Domain.ValueObjects;
using ItemManager.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ItemManager.Infrastructure.Context
{
    public class ManagerContext : DbContext
    {
        private readonly ConfigurationKeys _configurationKeys;

        public ManagerContext(ConfigurationKeys configurationKeys)
        {
            _configurationKeys = configurationKeys;
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            modelBuilder.ApplyConfiguration(new ItemMapping());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Integrated Security = true; initial catalog = Rocketz;");
            base.OnConfiguring(optionBuilder);
        }
    }
}
