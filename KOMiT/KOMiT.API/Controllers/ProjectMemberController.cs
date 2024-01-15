using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectMemberController : ControllerBase
{
    private readonly IProjectMemberService _projectMemberService;

    public ProjectMemberController(IProjectMemberService projectMemberService)
    {
        _projectMemberService = projectMemberService;
    }
    [HttpPost("AddProjectMemberToCurrentPhase/{currentPhaseId}/{employeeId}")]
    public async Task<ActionResult> AddProjectMemberToCurrentPhase(int currentPhaseId, int employeeId, [FromBody] ProjectMember projectMember)
    {
        try
        {
            await _projectMemberService.AddProjectMemberToCurrentPhase(currentPhaseId, employeeId, projectMember);
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpGet("GetEmployeesWithoutProjectMemberToCurrentPhase/{id}")]
    public async Task<ActionResult<List<Employee>>> GetEmployeesWithoutProjectMemberToCurrentPhase(int id)
    {
        try
        {
            var result = await _projectMemberService.GetEmployeesWithoutProjectMemberToCurrentPhase(id);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }
}
