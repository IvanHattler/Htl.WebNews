using Htl.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Htl.Data
{
    public class UpdateContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Update> Updates { get; set; }
#if DEBUG
        public UpdateContext()
        {
            _connectionString = "Server=localhost;Database=htl;User ID=pgroot;Password=1234;Port=5433;";
        }
#endif
        public UpdateContext(string connectionString)
        {
            _connectionString = connectionString
                ?? throw new ArgumentNullException(nameof(connectionString));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(_connectionString);
        }
    }
}
