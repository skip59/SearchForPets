using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SearchForPets.Domain.Entities.SpeciesContext.SpeciesEntity;
using SearchForPets.Domain.Entities.VolunteerContext.VolunteerEntity;

namespace SearchForPets.Infrastructure.Postgres.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Specie> Species { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSnakeCaseNamingConvention()
                .UseLoggerFactory(CreateLoggerFactory())
                .EnableSensitiveDataLogging();
        }

        private static ILoggerFactory CreateLoggerFactory() =>
        LoggerFactory.Create(builder => builder.AddConsole());
    }
}
