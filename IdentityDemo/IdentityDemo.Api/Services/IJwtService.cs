using IdentityDemo.Api.Data.Entities;

namespace IdentityDemo.Api.Services;

public interface IJwtService
{
    Task<string> GenerateTokenAsync(User user);
}