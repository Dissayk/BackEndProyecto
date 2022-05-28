using BackEndProyecto.Model;
using Microsoft.EntityFrameworkCore;

namespace BackEndProyecto.Data
{
    public class CompanyApiContext : DbContext
    {
        public CompanyApiContext (DbContextOptions<CompanyApiContext> options) : base(options)
        {

        }

        public DbSet<BackEndProyecto.Model.Employee> Employee { get; set; }
        public DbSet<BackEndProyecto.Model.Product> Product { get; set; }
        public DbSet<BackEndProyecto.Model.Supplier> Supplier { get; set; }

    }
}
