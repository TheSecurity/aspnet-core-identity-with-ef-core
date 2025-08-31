using IdentityDemo.Api.Data;
using IdentityDemo.Api.Data.Entities;
using IdentityDemo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemo.Api.Services;

public class ProjectService : IProjectService
{
    private readonly AppDbContext _context;
    private readonly ICurrentUserContext _currentUserContext;

    public ProjectService(AppDbContext context, ICurrentUserContext currentUserContext)
    {
        _context = context;
        _currentUserContext = currentUserContext;
    }

    public async Task<int> CreateProjectAsync(CreateProjectRequestModel model)
    {
        var currentUserId = _currentUserContext.GetCurrentUserId()!.Value;

        var project = new Project
        {
            Name = model.Name,
            Description = model.Description,
            Members = [
                new UserProject
                {
                    UserId = currentUserId,
                    IsAdmin = true
                }
            ]
        };

        _context.Projects.Add(project);

        await _context.SaveChangesAsync();

        return project.Id;
    }

    public async Task<ProjectResultModel?> GetProjectAsync(int projectId)
    {
        var currentUserId = _currentUserContext.GetCurrentUserId()!.Value;

        var project = await _context.Projects
            .FirstOrDefaultAsync(x => x.Id == projectId && x.Members.Any(y => y.UserId == currentUserId));

        if (project == null)
        {
            return null;
        }

        return new ProjectResultModel
        {
            Id = project.Id,
            Name = project.Name,
            Description = project.Description
        };
    }

    public async Task<IEnumerable<ProjectResultModel>> GetUserProjectsAsync()
    {
        var currentUserId = _currentUserContext.GetCurrentUserId()!.Value;

        return await _context.Projects
            .Where(x => x.Members.Any(y => y.UserId == currentUserId))
            .Select(project => new ProjectResultModel
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description
            })
            .ToListAsync();
    }
}