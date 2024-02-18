using Gold.Interfaces;
using Gold.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Gold.Infrastructure
{
    public class GoldDbContext : DbContext, IGoldDbContext
    {
        public GoldDbContext(DbContextOptions<GoldDbContext> options) : base(options) { }

        public DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
