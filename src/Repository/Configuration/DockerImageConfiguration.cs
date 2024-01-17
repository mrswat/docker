using DockerTest.Repository.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DockerTest.Repository.Configuration
{
    public class DockerImageConfiguration : IEntityTypeConfiguration<DockerImage>
    {
        public void Configure(EntityTypeBuilder<DockerImage> builder)
        {
            builder.ToTable("dockerimage");
            builder.HasKey(x => x.Id).HasName("id");
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired().HasColumnName("name");
        }
    }
}
