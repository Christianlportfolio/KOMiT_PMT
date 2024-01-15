using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CurrentSubGoalController : ControllerBase
{
    private readonly ICurrentSubGoalService _currentSubGoalService;

    public CurrentSubGoalController(ICurrentSubGoalService currentSubGoalService)
    {
        _currentSubGoalService = currentSubGoalService;
    }
    [HttpPost("CreateCurrentSubGoal")]
    public async Task<ActionResult> CreateCurrentSubGoal([FromBody] CurrentSubGoal currentSubGoal)
    {
        try
        {
            await _currentSubGoalService.CreateCurrentSubGoal(currentSubGoal);
            return Ok(currentSubGoal);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpPut("UpdateCurrentSubGoal")]
    public async Task<ActionResult> UpdateCurrentSubGoal([FromBody] CurrentSubGoal currentSubGoal)
    {
        try
        {
            await _currentSubGoalService.UpdateCurrentSubGoal(currentSubGoal);
            return Ok(currentSubGoal);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpPut("FinishCurrentSubGoal")]
    public async Task<ActionResult> FinishCurrentSubGoal([FromBody] CurrentSubGoal currentSubGoal)
    {
        try
        {
            await _currentSubGoalService.FinishCurrentSubGoal(currentSubGoal);
            return Ok(currentSubGoal);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("DeleteCurrentSubGoal/{id}")]
    public async Task<ActionResult> FinishCurrentSubGoal(int id)
    {
        try
        {
            await _currentSubGoalService.DeleteCurrentSubGoal(id);
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }
}
