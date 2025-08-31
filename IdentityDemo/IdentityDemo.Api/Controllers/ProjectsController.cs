using IdentityDemo.Api.Models;
using IdentityDemo.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDemo.Api.Controllers;

public class ProjectsController : ApiControllerBase
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpPost]
    public async Task<ActionResult<ProjectResultModel>> CreateProject(CreateProjectRequestModel model)
    {
        var projectId = await _projectService.CreateProjectAsync(model);

        return CreatedAtAction(nameof(GetProject), new { id = projectId }, projectId);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectResultModel>> GetProject(int id)
    {
        var project = await _projectService.GetProjectAsync(id);
        
        if (project is null)
        {
            return NotFound("Project not found or you don't have access to it.");
        }

        return Ok(project);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProjectResultModel>>> GetUserProjects()
    {
        var projects = await _projectService.GetUserProjectsAsync();
        return Ok(projects);
    }
}