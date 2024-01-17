using DockerTest.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace DockerTest.Repository
{
    public sealed class DockerDbContext : DbContext
    {
        public DbSet<DockerImage> DockerImages { get; set; }

        public DockerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DockerDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
