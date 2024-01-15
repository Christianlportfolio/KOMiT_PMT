using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class CurrentPhaseRepository : ICurrentPhaseRepository
{
    private DatabaseContext _context;
    public CurrentPhaseRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<CurrentPhase> GetDetailsById(int id)
    {
        var result = _context.CurrentPhases
    .Where(x => x.Id == id)
    .Select(cp => new CurrentPhase
    (
        cp.Id,
        cp.Status,
        cp.EstimatedStartDate,
        cp.EstimatedEndDate,
        cp.Comment,
        cp.RealizedDate,
        cp.ProjectId,
        cp.StandardPhaseId,
        new StandardPhase
        (
            cp.StandardPhase.Id,
            cp.StandardPhase.Name,
            cp.StandardPhase.Description
        ),
        cp.CurrentSubGoals.Select(csg => new CurrentSubGoal(
            csg.Id,
            csg.Name,
            csg.Description,
            csg.Status,
            csg.EstimatedEndDate,
            csg.Comment,
            csg.RealizedDate,
            csg.CurrentTasks.Select(ct => new CurrentTask(
                ct.Id,
                ct.Title,
                ct.Description,
                ct.Status,
                ct.EstimatedNumberOfDays,
                ct.Comment,
                ct.RealizedDate,
                ct.CurrentSubGoalId,
                ct.ProjectMembers.Select(pm => new ProjectMember(
                pm.Id,
                pm.ProjectRole,
                pm.ProjectMemberStatus,
                pm.Employees.Select(e => new Employee(
                    e.Id,
                    e.Name,
                    e.JobPosition,
                    e.Email,
                    e.Competences.Select(c => new Competence(
                        c.Id,
                        c.Title,
                        c.Description,
                        c.Experience
                    )).ToList()
                )).ToList()
            )).ToList()
            )).ToList()
          )).ToList()
        .ToList(),
        cp.ProjectMembers.Select(pm => new ProjectMember(
                pm.Id,
                pm.ProjectRole,
                pm.ProjectMemberStatus,
                pm.Employees.Select(e => new Employee(
                    e.Id,
                    e.Name,
                    e.JobPosition,
                    e.Email,
                    e.Competences.Select(c => new Competence(
                        c.Id,
                        c.Title,
                        c.Description,
                        c.Experience
                    )).ToList()
                )).ToList()
            )).ToList()));
        return await result.SingleOrDefaultAsync();
    }

    public async Task<CurrentPhase> GetEstimatedAndRealizedData(int id)
    {
        var result = await _context.CurrentPhases
         .Where(x => x.Id == id)
         .Select(cp => new CurrentPhase
         {
             EstimatedStartDate = cp.EstimatedStartDate,
             EstimatedEndDate = cp.EstimatedEndDate,
             CurrentSubGoals = cp.CurrentSubGoals.Select(csg => new CurrentSubGoal
             {
                 Name = csg.Name,
                 EstimatedEndDate = csg.EstimatedEndDate,
                 RealizedDate = csg.RealizedDate,
                 CurrentTasks = csg.CurrentTasks.Select(ct => new CurrentTask
                 {
                     Title = ct.Title,
                     EstimatedNumberOfDays = ct.EstimatedNumberOfDays,
                     RealizedDate = ct.RealizedDate
                 }).ToList()
             }).ToList()
         })
         .SingleOrDefaultAsync();
        return result;
    }
}
