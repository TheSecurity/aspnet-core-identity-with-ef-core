namespace IdentityDemo.Api.Data.Entities;

public class UserProject : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
    public int ProjectId { get; set; }
    public virtual Project Project { get; set; } = null!;
    public bool IsAdmin { get; set; }
}
