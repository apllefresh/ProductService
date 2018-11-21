using Microsoft.EntityFrameworkCore;
using DataAccess.Contract.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace DataAccess.EF
{
    public class DataAccessContext : DbContext
    {
        public DbSet<Product> product { get; set; }
        public DbSet<ProductGroup> productGroup { get; set; }
        public DbSet<Department> department { get; set; }
        
        public string ConnectionString { get; }

        public DataAccessContext(IConfiguration configuration) => ConnectionString = configuration.GetSection("ConnectionStrings:ProductsConnection")
           .Value;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new NpgsqlConnection(ConnectionString);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseNpgsql(connection);
        }
    }
}
