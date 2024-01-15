using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public interface ICurrentSubGoalService
{
    Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal);
    Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal);
    Task UpdateCurrentSubGoal(CurrentSubGoal currentSubGoal);
    Task DeleteCurrentSubGoal(int id);
}
