using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class ProjectMemberRepository : IProjectMemberRepository
{
    private DatabaseContext _context;
    public ProjectMemberRepository(DatabaseContext context)
    {
        _context = context;
    }
    public async Task AddProjectMemberToCurrentPhase(int currentPhaseId, int employeeId, ProjectMember projectMember)
    {
        var currentPhase = _context.CurrentPhases.Include(cp => cp.ProjectMembers).Single(x => x.Id == currentPhaseId);
        var employee = _context.Employees.Include(cp => cp.ProjectMembers).Single(x => x.Id == employeeId);
        _context.ProjectMembers.Add(projectMember);
        currentPhase.ProjectMembers.Add(projectMember);
        employee.ProjectMembers.Add(projectMember);

        await _context.SaveChangesAsync();
    }

    public async Task<List<Employee>> GetEmployeesWithoutProjectMemberToCurrentPhase(int id)
    {
        var currentPhase = await _context.CurrentPhases
            .Include(cp => cp.ProjectMembers)
            .ThenInclude(cp => cp.Employees)
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();

        List<Employee> employees = new List<Employee>();

        if (currentPhase != null)
        {
            var currentPhaseEmployeeIds = currentPhase.ProjectMembers
                .SelectMany(pm => pm.Employees.Select(e => e.Id))
                .ToList();

            employees = await _context.Employees
                .Where(e => !currentPhaseEmployeeIds.Contains(e.Id))
                .ToListAsync();
        }

        return employees;
    }
}
