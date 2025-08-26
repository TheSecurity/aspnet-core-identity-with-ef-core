using IdentityDemo.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityDemo.Api.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(u => u.Projects)
               .WithOne(up => up.User)
               .HasForeignKey(up => up.UserId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
