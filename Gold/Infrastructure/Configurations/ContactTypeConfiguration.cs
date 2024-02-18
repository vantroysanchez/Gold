using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;
using Gold.Models;

namespace Gold.Infrastructure.Configurations
{
    public class ContactTypeConfiguration : IEntityTypeConfiguration<ContactType>
    {
        public void Configure(EntityTypeBuilder<ContactType> builder)
        {
            builder.ToTable(nameof(ContactType), "Person");
        }
    }
}
