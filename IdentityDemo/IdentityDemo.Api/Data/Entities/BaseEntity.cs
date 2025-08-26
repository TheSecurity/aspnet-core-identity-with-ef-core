using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Api.Data.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
