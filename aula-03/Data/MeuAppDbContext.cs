using aula_03.Models;
using Microsoft.EntityFrameworkCore;

namespace aula_03.Data
{
    public class MeuAppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public MeuAppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=meu-app.sqlite");
        }
}