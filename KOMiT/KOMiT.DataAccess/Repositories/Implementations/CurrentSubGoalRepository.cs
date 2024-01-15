using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class CurrentSubGoalRepository : ICurrentSubGoalRepository
{
    private DatabaseContext _context;
    public CurrentSubGoalRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal)
    {
        _context.CurrentSubGoals.Add(currentSubGoal);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCurrentSubGoal(int id)
    {

        var currentSubGoal = await _context.CurrentSubGoals
        .Include(subGoal => subGoal.CurrentTasks)
        .FirstOrDefaultAsync(subGoal => subGoal.Id == id);
        if (currentSubGoal.CurrentTasks != null)
        {
            foreach (var currentTask in currentSubGoal.CurrentTasks)
            {
                _context.CurrentTasks.Remove(currentTask);
            }
        }
        _context.CurrentSubGoals.Remove(currentSubGoal);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCurrentSubGoal(CurrentSubGoal currentSubGoal)
    {
        var currentSubGoalWithDependency = await _context.CurrentSubGoals
         .Include(subGoal => subGoal.CurrentTasks)
            .ThenInclude(currentTask => currentTask.ProjectMembers)
         .FirstOrDefaultAsync(subGoal => subGoal.Id == currentSubGoal.Id);

        _context.Entry(currentSubGoalWithDependency).CurrentValues.SetValues(currentSubGoal);
        await _context.SaveChangesAsync();
    }

    public async Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal)
    {
        var currentSubGoalWithDependency = await _context.CurrentSubGoals
         .Include(subGoal => subGoal.CurrentTasks)
            .ThenInclude(currentTask => currentTask.ProjectMembers)
         .FirstOrDefaultAsync(subGoal => subGoal.Id == currentSubGoal.Id);
        _context.Entry(currentSubGoalWithDependency).CurrentValues.SetValues(currentSubGoal);

        foreach (var currentTask in currentSubGoalWithDependency.CurrentTasks)
        {
            var updatedTask = currentSubGoal.CurrentTasks.FirstOrDefault(t => t.Id == currentTask.Id);
            if (updatedTask != null)
            {
                _context.Entry(currentTask).CurrentValues.SetValues(updatedTask);
            }
        }
        await _context.SaveChangesAsync();
    }
}
