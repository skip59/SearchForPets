using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class RequsitesConfiguration : IEntityTypeConfiguration<Requisites>
    {
        public void Configure(EntityTypeBuilder<Requisites> builder)
        {
            builder.HasKey(r => r.Id);
        }
    }
}
