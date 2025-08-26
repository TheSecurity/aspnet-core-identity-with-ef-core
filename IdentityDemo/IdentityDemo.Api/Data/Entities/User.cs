using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Api.Data.Entities;

public class User : IdentityUser<int>
{
    public int? Age { get; set; }
    public virtual ICollection<UserProject> Projects { get; set; } = [];
}
