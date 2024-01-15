using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface IProjectRepository
{
    Task<ICollection<Project>> GetAll();
    Task<Project> GetDetailsById(int id);
    Task CreateProject(Project project);
    Task UpdateProject(Project project);
    Task FinishProject(Project project);
    Task DeleteProject(int id);
}
