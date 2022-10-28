using Microsoft.EntityFrameworkCore;

namespace aula_03.Data
{
    public class MeuAppDbContext : DbContext
    {
        public string DbPath { get; }

        public MeuAppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "meu-app.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        }
}