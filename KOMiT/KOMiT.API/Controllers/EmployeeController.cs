using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<ICollection<Project>>> GetAll()
    {
        var result = await _employeeService.GetAll();
        return Ok(result);
    }

    [HttpPost("CreateEmployee")]
    public async Task<ActionResult> CreateEmployee([FromBody] Employee employee)
    {
        await _employeeService.CreateEmployee(employee);
        return Ok(employee);
    }
}
