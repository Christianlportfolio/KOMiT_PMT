using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    private readonly IProjectService _projectService;
    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<ICollection<Project>>> GetAll()
    {
        var result = await _projectService.GetAll();
        return Ok(result);
    }

    [HttpGet("GetDetailsById/{id}")]
    public async Task<ActionResult<Project>> GetDetailsById(int id)
    {
        var result = await _projectService.GetDetailsById(id);
        return Ok(result);
    }

    [HttpPost("CreateProject")]
    public async Task<ActionResult> CreateProject([FromBody] Project project)
    {
        await _projectService.CreateProject(project);
        return Ok(project);
    }

    [HttpPut("UpdateProject")]
    public async Task<ActionResult> UpdateProject([FromBody] Project project)
    {
        await _projectService.UpdateProject(project);
        return Ok(project);
    }

    [HttpPut("FinishProject")]
    public async Task<ActionResult> FinishProject([FromBody] Project project)
    {
        await _projectService.FinishProject(project);
        return Ok(project);
    }

    [HttpDelete("DeleteProject/{Id}")]
    public async Task<ActionResult> DeleteProject(int Id)
    {
        await _projectService.DeleteProject(Id);
        return Ok();
    }
}
