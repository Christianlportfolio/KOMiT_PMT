using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public interface IProjectMemberService
{
    Task AddProjectMemberToCurrentPhase(int currentPhaseId, int employeeId, ProjectMember projectMember);
    Task<List<Employee>> GetEmployeesWithoutProjectMemberToCurrentPhase(int id);
}
