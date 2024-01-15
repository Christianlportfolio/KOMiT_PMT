using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class ProjectRepository : IProjectRepository
{
    private DatabaseContext _context;


    public ProjectRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Project>> GetAll()
    {
        var result = _context.Projects.Select(x => new Project(
          x.Id,
          x.Name,
          x.Description,
          x.ProjectType,
          x.Priority,
          x.Status,
          x.EstimatedStartDate,
          x.EstimatedEndDate,
          x.Comment,
          x.RealizedDate,
          x.CurrentPhases.Select(cp => new CurrentPhase(
              cp.Id,
              cp.Status,
              cp.EstimatedStartDate,
              cp.EstimatedEndDate,
              cp.Comment,
              cp.RealizedDate,
              cp.ProjectId,
              cp.StandardPhase.Id,
                  new StandardPhase(
                cp.StandardPhase.Id,
                cp.StandardPhase.Name,
                cp.StandardPhase.Description
            )
          )).ToList()
      ));
        return await result.ToListAsync();
    }

    public async Task<Project> GetDetailsById(int id)
    {
        var result = _context.Projects
            .Where(x => x.Id == id)
            .Select(p => new Project
            (p.Id,
             p.Name,
             p.Description,
             p.ProjectType,
             p.Priority,
             p.Status,
             p.EstimatedStartDate,
             p.EstimatedEndDate,
             p.Comment,
             p.RealizedDate,
             p.CurrentPhases.Select(cp => new CurrentPhase(
              cp.Id,
              cp.Status,
              cp.EstimatedStartDate,
              cp.EstimatedEndDate,
              cp.Comment,
              cp.RealizedDate,
              cp.ProjectId,
              cp.StandardPhase.Id,
                  new StandardPhase(
                cp.StandardPhase.Id,
                cp.StandardPhase.Name,
                cp.StandardPhase.Description
            )
          )).ToList()
      ));

        return await result.SingleOrDefaultAsync();
    }
    public async Task CreateProject(Project project)
    {
        var result = _context.Projects.Add(project);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProject(int Id)
    {
        var project = await _context.Projects
        .Include(p => p.CurrentPhases)
         .ThenInclude(currentPhase => currentPhase.ProjectMembers)
            .Include(p => p.CurrentPhases).ThenInclude(x => x.CurrentSubGoals)
             .ThenInclude(x => x.CurrentTasks)

        .FirstOrDefaultAsync(p => p.Id == Id);
        if (project.CurrentPhases != null)
        {
            foreach (var currentPhases in project.CurrentPhases)
            {
                foreach (var projectMembers in currentPhases.ProjectMembers)
                {
                    _context.ProjectMembers.Remove(projectMembers);
                }
                foreach (var currenSubGoals in currentPhases.CurrentSubGoals)
                {
                    _context.CurrentSubGoals.Remove(currenSubGoals);
                    foreach (var currentTasks in currenSubGoals.CurrentTasks)
                    {
                        _context.CurrentTasks.Remove(currentTasks);
                    }
                }
                _context.CurrentPhases.Remove(currentPhases);
            }
        }
        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProject(Project project)
    {
        var projectWithDependency = await _context.Projects
            .Include(p => p.CurrentPhases)
            .ThenInclude(currentPhase => currentPhase.ProjectMembers)
            .Include(p => p.CurrentPhases).ThenInclude(x => x.CurrentSubGoals)
            .ThenInclude(x => x.CurrentTasks)
            .FirstOrDefaultAsync(p => p.Id == project.Id);

        _context.Entry(projectWithDependency).CurrentValues.SetValues(project);
        await _context.SaveChangesAsync();
    }

    public async Task FinishProject(Project project)
    {
        var projectWithDependency = await _context.Projects
            .Include(p => p.CurrentPhases)
            .ThenInclude(currentPhase => currentPhase.ProjectMembers)
            .Include(p => p.CurrentPhases).ThenInclude(x => x.CurrentSubGoals)
            .ThenInclude(x => x.CurrentTasks)
            .FirstOrDefaultAsync(p => p.Id == project.Id);
        _context.Entry(projectWithDependency).CurrentValues.SetValues(project);

        foreach (var currentPhase in projectWithDependency.CurrentPhases)
        {
            var updatedPhase = project.CurrentPhases.FirstOrDefault(t => t.Id == currentPhase.Id);
            if (updatedPhase != null)
            {
                _context.Entry(currentPhase).CurrentValues.SetValues(updatedPhase);
            }

        }
        await _context.SaveChangesAsync();
    }
}


