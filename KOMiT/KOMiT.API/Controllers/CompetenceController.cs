using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetenceController : ControllerBase
{
    private readonly ICompetenceService _competenceService;
    public CompetenceController(ICompetenceService competenceService)
    {
        _competenceService = competenceService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<ICollection<Competence>>> GetAll()
    {
        var result = await _competenceService.GetAll();
        return Ok(result);
    }

    [HttpGet("GetDetails")]
    public async Task<ActionResult<ICollection<Competence>>> GetDetails()
    {
        var result = await _competenceService.GetDetails();
        return Ok(result);
    }
}
