using Gold.Models;
using Microsoft.EntityFrameworkCore;

namespace Gold.Interfaces
{
    public interface IGoldDbContext
    {
        DbSet<ContactType> ContactTypes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}