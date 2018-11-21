using Microsoft.EntityFrameworkCore;
using DataAccess.Contract.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace DataAccess.EF
{
    public class DataAccessContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Product> product { get; set; }
        public DbSet<ProductGroup> productGroup { get; set; }
        public DbSet<Department> department { get; set; }

        public DataAccessContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new NpgsqlConnection(_connectionString);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseNpgsql(connection);
        }
    }
}
