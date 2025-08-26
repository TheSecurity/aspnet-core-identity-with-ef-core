namespace IdentityDemo.Api.Data.Entities;

public class Project : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public virtual ICollection<UserProject> Members { get; set; } = [];
}
