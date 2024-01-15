using KOMiT.App.Service;
using KOMiT.Core.DTO_s;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CurrentPhaseController : ControllerBase
{
    private readonly ICurrentPhaseService _currentPhaseService;
    public CurrentPhaseController(ICurrentPhaseService currentPhaseService)
    {
        _currentPhaseService = currentPhaseService;
    }

    [HttpGet("GetDetailsById/{id}")]
    public async Task<ActionResult<CurrentPhase>> GetDetailsById(int id)
    {
        try
        {
            var result = await _currentPhaseService.GetDetailsById(id);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }


    [HttpGet("GetCalculatedDays/{id}")]
    public async Task<ActionResult<EstimatedAndRealizedDaysDTO>> GetCalculatedDays(int id)
    {
        try
        {
            var result = await _currentPhaseService.CalculatorEstimatedAndRealizedDaysDTO(id);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }
}
