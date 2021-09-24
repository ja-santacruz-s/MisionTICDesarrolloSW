using Microsoft.EntityFrameworkCore;
using GanaderiaWeb.App.Dominio;

namespace GanaderiaWeb.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ganadero> Ganaderos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = GanaderiaWebTest");

            }

        }

    }
}