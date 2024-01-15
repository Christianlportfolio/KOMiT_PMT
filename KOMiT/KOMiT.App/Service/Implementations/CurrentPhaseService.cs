using KOMiT.Core.DTO_s;
using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using static KOMiT.Core.DTO_s.EstimatedAndRealizedDaysDTO;

namespace KOMiT.App.Service.Implementations;

public class CurrentPhaseService : ICurrentPhaseService
{
    private ICurrentPhaseRepository _currentPhaseRepository;

    public CurrentPhaseService(ICurrentPhaseRepository currentPhaseRepository)
    {
        _currentPhaseRepository = currentPhaseRepository;
    }

    public async Task<CurrentPhase> GetDetailsById(int id)
    {
        return await _currentPhaseRepository.GetDetailsById(id);

    }

    public async Task<EstimatedAndRealizedDaysDTO> CalculatorEstimatedAndRealizedDaysDTO(int id)
    {
        var result = await _currentPhaseRepository.GetEstimatedAndRealizedData(id);

        double estimatedCurrentPhaseDays = CalculateDateDays(result.EstimatedEndDate, result.EstimatedStartDate);
        double realizedCurrentPhasesDays = CalculateRealizedCurrentPhasesDays(result);

        List<double> estimatedCurrentSubGoalsDays = CalculateEstimatedSubGoalsDays(result);
        List<double> realizedCurrentSubGoalsDays = CalculateRealizedCurrentSubGoalsDays(result);
        List<double> estimatedCurrentTasksDays = CalculateEstimatedCurrentTasksDays(result);
        List<double> realizedCurrentTasksDays = CalculateRealizedCurrentTasksDays(result);

        List<CurrentSubGoalsDaysDTO> currentSubGoalsDaysDTOs = CalculateCurrentSubGoalsDTOs(result);
        List<CurrentTaskDaysDTO> currentTasksDaysDTO = CalculateCurrentTasksDTO(result);

        return new EstimatedAndRealizedDaysDTO(
            estimatedCurrentPhaseDays,
            realizedCurrentPhasesDays,
            estimatedCurrentSubGoalsDays.Sum(),
            realizedCurrentSubGoalsDays.Sum(),
            estimatedCurrentTasksDays.Sum(),
            realizedCurrentTasksDays.Sum(),
            currentSubGoalsDaysDTOs,
            currentTasksDaysDTO
        );
    }

    private double CalculateRealizedCurrentPhasesDays(CurrentPhase result)
    {
        return result.RealizedDate.HasValue ? CalculateDateDays(result.RealizedDate.Value, result.EstimatedStartDate) : 0;
    }

    private List<double> CalculateEstimatedSubGoalsDays(CurrentPhase result)
    {
        var estimatedDays = new List<double>();

        foreach (var currentSubGoal in result.CurrentSubGoals)
        {
            estimatedDays.Add(CalculateDateDays(currentSubGoal.EstimatedEndDate, result.EstimatedStartDate));
        }

        return estimatedDays;
    }

    private List<double> CalculateRealizedCurrentSubGoalsDays(CurrentPhase result)
    {
        var realizedDays = new List<double>();

        foreach (var currentSubGoal in result.CurrentSubGoals)
        {
            if (currentSubGoal.RealizedDate.HasValue)
            {
                realizedDays.Add(CalculateDateDays(currentSubGoal.RealizedDate.Value, result.EstimatedStartDate));
            }
        }

        return realizedDays;
    }

    private List<double> CalculateEstimatedCurrentTasksDays(CurrentPhase result)
    {
        var estimatedDays = new List<double>();

        foreach (var currentSubGoal in result.CurrentSubGoals)
        {
            foreach (var currentTask in currentSubGoal.CurrentTasks)
            {
                estimatedDays.Add(CalculateDateDays(currentTask.EstimatedNumberOfDays, result.EstimatedStartDate));
            }
        }

        return estimatedDays;
    }

    private List<double> CalculateRealizedCurrentTasksDays(CurrentPhase result)
    {
        var realizedDays = new List<double>();

        foreach (var currentSubGoal in result.CurrentSubGoals)
        {
            foreach (var currentTask in currentSubGoal.CurrentTasks)
            {
                if (currentTask.RealizedDate.HasValue)
                {
                    realizedDays.Add(CalculateDateDays(currentTask.RealizedDate.Value, result.EstimatedStartDate));
                }
            }
        }

        return realizedDays;
    }

    private List<CurrentSubGoalsDaysDTO> CalculateCurrentSubGoalsDTOs(CurrentPhase result)
    {
        var dtos = new List<CurrentSubGoalsDaysDTO>();

        foreach (var currentSubGoal in result.CurrentSubGoals)
        {
            if (currentSubGoal.RealizedDate.HasValue)
            {
                dtos.Add(new CurrentSubGoalsDaysDTO
                {
                    Name = currentSubGoal.Name,
                    EstimatedCurrentSubGoalsDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, result.EstimatedStartDate),
                    RealizedCurrentSubGoalsDays = CalculateDateDays(currentSubGoal.RealizedDate.Value, result.EstimatedStartDate)
                });
            }
            else
            {
                dtos.Add(new CurrentSubGoalsDaysDTO
                {
                    Name = currentSubGoal.Name,
                    EstimatedCurrentSubGoalsDays = CalculateDateDays(currentSubGoal.EstimatedEndDate, result.EstimatedStartDate),
                    RealizedCurrentSubGoalsDays = 0
                });
            }
        }

        return dtos;
    }

    private List<CurrentTaskDaysDTO> CalculateCurrentTasksDTO(CurrentPhase result)
    {
        var dtos = new List<CurrentTaskDaysDTO>();

        foreach (var currentSubGoal in result.CurrentSubGoals)
        {
            foreach (var currentTask in currentSubGoal.CurrentTasks)
            {
                if (currentTask.RealizedDate.HasValue)
                {
                    dtos.Add(new CurrentTaskDaysDTO
                    {
                        Title = currentTask.Title,
                        EstimatedCurrentTaksDays = CalculateDateDays(currentTask.EstimatedNumberOfDays, result.EstimatedStartDate),
                        RealizedCurrentTaksDays = CalculateDateDays(currentTask.RealizedDate.Value, result.EstimatedStartDate)
                    });
                }
                else
                {
                    dtos.Add(new CurrentTaskDaysDTO
                    {
                        Title = currentTask.Title,
                        EstimatedCurrentTaksDays = CalculateDateDays(currentTask.EstimatedNumberOfDays, result.EstimatedStartDate),
                        RealizedCurrentTaksDays = 0
                    });
                }
            }
        }
        return dtos;
    }


    public double CalculateDateDays(DateTime endDate, DateTime startDate)
    {
        return (endDate - startDate).TotalDays;
    }
}
