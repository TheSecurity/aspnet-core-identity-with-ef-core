using IdentityDemo.Api.Models;

namespace IdentityDemo.Api.Services;

public interface IProjectService
{
    Task<int> CreateProjectAsync(CreateProjectRequestModel model);
    Task<ProjectResultModel?> GetProjectAsync(int projectId);
    Task<IEnumerable<ProjectResultModel>> GetUserProjectsAsync();
}