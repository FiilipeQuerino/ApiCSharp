using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Model;

namespace PrimeiraApi.Infra
{
    public class ContextoBanco : DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "server=localhost;" +
              "Port=;Database=;" +
              "User Id=postgres" +
              "Password=123;"
              );
    }
}
