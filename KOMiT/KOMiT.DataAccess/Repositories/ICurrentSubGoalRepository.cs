using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface ICurrentSubGoalRepository
{
    Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal);
    Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal);
    Task UpdateCurrentSubGoal(CurrentSubGoal currentSubGoal);
    Task DeleteCurrentSubGoal(int id);
}
