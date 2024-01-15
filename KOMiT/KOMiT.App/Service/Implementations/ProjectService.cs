using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;

namespace KOMiT.App.Service.Implementations;

public class ProjectService : IProjectService
{
    private IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<ICollection<Project>> GetAll()
    {
        return await _projectRepository.GetAll();
    }

    public async Task<Project> GetDetailsById(int id)
    {
        return await _projectRepository.GetDetailsById(id);
    }

    public async Task CreateProject(Project project)
    {
        await _projectRepository.CreateProject(project);
    }

    public async Task DeleteProject(int id)
    {
        await _projectRepository.DeleteProject(id);
    }

    public async Task UpdateProject(Project project)
    {
        await _projectRepository.UpdateProject(project);
    }

    public async Task FinishProject(Project project)
    {
        await _projectRepository.FinishProject(project);
    }
}
