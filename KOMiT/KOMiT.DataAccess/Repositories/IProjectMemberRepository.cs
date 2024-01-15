using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface IProjectMemberRepository
{
    Task AddProjectMemberToCurrentPhase(int currentPhaseId, int employeeId, ProjectMember projectMember);
    Task<List<Employee>> GetEmployeesWithoutProjectMemberToCurrentPhase(int id);
}
