using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public interface IProjectService
{
    Task<ICollection<Project>> GetAll();
    Task<Project> GetDetailsById(int id);
    Task CreateProject(Project project);
    Task DeleteProject(int id);
    Task UpdateProject(Project project);
    Task FinishProject(Project project);
}

