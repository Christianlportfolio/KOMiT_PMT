using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StandardPhaseController : ControllerBase
{
    private readonly IStandardPhaseService _standardPhaseService;

    public StandardPhaseController(IStandardPhaseService standardPhaseService)
    {
        _standardPhaseService = standardPhaseService;
    }
    [HttpPost("CreatePhase")]
    public async Task<ActionResult> CreatePhase([FromBody] StandardPhase standardPhase)
    {
        await _standardPhaseService.CreatePhase(standardPhase);
        return Ok(standardPhase);
    }
}
