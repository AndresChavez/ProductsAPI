using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using MaterialsAPI.Entities;


namespace ProductsAPI.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("ProductsAPIDatabase"));
        }

        //public DbSet<Material> Materials { get; set; }
    }
}
