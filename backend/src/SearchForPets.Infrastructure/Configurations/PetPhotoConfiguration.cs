using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchForPets.Domain.Entities.Common;

namespace SearchForPets.Infrastructure.Postgres.Configurations
{
    internal class PetPhotoConfiguration : IEntityTypeConfiguration<PetPhoto>
    {
        public void Configure(EntityTypeBuilder<PetPhoto> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
