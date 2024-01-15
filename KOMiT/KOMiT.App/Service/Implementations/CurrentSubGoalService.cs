using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;

namespace KOMiT.App.Service.Implementations;

public class CurrentSubGoalService : ICurrentSubGoalService
{
    private ICurrentSubGoalRepository _currentSubGoalRepository;

    public CurrentSubGoalService(ICurrentSubGoalRepository currentSubGoalRepository)
    {
        _currentSubGoalRepository = currentSubGoalRepository;
    }

    public async Task CreateCurrentSubGoal(CurrentSubGoal currentSubGoal)
    {
        await _currentSubGoalRepository.CreateCurrentSubGoal(currentSubGoal);
    }

    public async Task DeleteCurrentSubGoal(int id)
    {
        await _currentSubGoalRepository.DeleteCurrentSubGoal(id);
    }

    public async Task UpdateCurrentSubGoal(CurrentSubGoal currentSubGoal)
    {
        await _currentSubGoalRepository.UpdateCurrentSubGoal(currentSubGoal);
    }

    public async Task FinishCurrentSubGoal(CurrentSubGoal currentSubGoal)
    {
        await _currentSubGoalRepository.FinishCurrentSubGoal(currentSubGoal);
    }
}
