using IdentityDemo.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityDemo.Api.Data.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(p => p.Description)
            .HasMaxLength(500);

        builder.HasMany(p => p.Members)
               .WithOne(up => up.Project)
               .HasForeignKey(up => up.ProjectId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
