using IdentityDemo.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityDemo.Api.Data.Configurations;

public class UserProjectConfiguration : IEntityTypeConfiguration<UserProject>
{
    public void Configure(EntityTypeBuilder<UserProject> builder)
    {
        builder.HasKey(up => new { up.UserId, up.ProjectId });
        builder.HasOne(up => up.User)
               .WithMany(u => u.Projects)
               .HasForeignKey(up => up.UserId)
               .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(up => up.Project)
               .WithMany(p => p.Members)
               .HasForeignKey(up => up.ProjectId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
