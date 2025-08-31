namespace IdentityDemo.Api.Services;

public interface ICurrentUserContext
{
    int? GetCurrentUserId();
    string? GetCurrentUserEmail();
}