using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;

namespace KOMiT.App.Service.Implementations;

public class ProjectMemberService : IProjectMemberService
{
    private IProjectMemberRepository _projectMemberRepository;

    public ProjectMemberService(IProjectMemberRepository projectMemberRepository)
    {
        _projectMemberRepository = projectMemberRepository;
    }
    public async Task AddProjectMemberToCurrentPhase(int currentPhaseId, int employeeId, ProjectMember projectMember)
    {
        await _projectMemberRepository.AddProjectMemberToCurrentPhase(currentPhaseId, employeeId, projectMember);
    }

    public async Task<List<Employee>> GetEmployeesWithoutProjectMemberToCurrentPhase(int id)
    {
        var result = await _projectMemberRepository.GetEmployeesWithoutProjectMemberToCurrentPhase(id);
        return result;
    }
}
