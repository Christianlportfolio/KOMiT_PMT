namespace KOMiT.Core.DTO_s;

public class EstimatedAndRealizedDaysDTO
{
    public double EstimatedCurrentPhaseDaysSum { get; set; } = 0;
    public double RealizedCurrentPhaseDaysSum { get; set; } = 0;
    public double EstimatedCurrentSubGoalsDaysSum { get; set; } = 0;
    public double RealizedCurrentSubGoalsDaysSum { get; set; } = 0;
    public double EstimatedCurrentTaskDaysSum { get; set; } = 0;
    public double RealizedCurrentTaskDaysSum { get; set; } = 0;

    public ICollection<CurrentSubGoalsDaysDTO> CurrentSubGoalsDaysDTOs { get; set; }
    public class CurrentSubGoalsDaysDTO
    {
        public string Name { get; set; }
        public double EstimatedCurrentSubGoalsDays { get; set; } = 0;
        public double RealizedCurrentSubGoalsDays { get; set; } = 0;
    }

    public ICollection<CurrentTaskDaysDTO> CurrentTaskDaysDTOs { get; set; }
    public class CurrentTaskDaysDTO
    {
        public string Title { get; set; }
        public double EstimatedCurrentTaksDays { get; set; } = 0;
        public double RealizedCurrentTaksDays { get; set; } = 0;
    }

    public EstimatedAndRealizedDaysDTO()
    {

    }
    public EstimatedAndRealizedDaysDTO(double estimatedCurrentPhaseDaysSum, double realizedCurrentPhaseDaysSum, double estimatedCurrentSubGoalsDaysSum, double realizedCurrentSubGoalDaysSum, double estimatedCurrentTaskDaysSum, double realizedCurrentTaskDaysSum, ICollection<CurrentSubGoalsDaysDTO> currentSubGoalsDaysDTOs, ICollection<CurrentTaskDaysDTO> currentTaskDaysDTOs)
    {
        EstimatedCurrentPhaseDaysSum = estimatedCurrentPhaseDaysSum;
        RealizedCurrentPhaseDaysSum = realizedCurrentPhaseDaysSum;
        EstimatedCurrentSubGoalsDaysSum = estimatedCurrentSubGoalsDaysSum;
        RealizedCurrentSubGoalsDaysSum = realizedCurrentSubGoalDaysSum;
        EstimatedCurrentTaskDaysSum = estimatedCurrentTaskDaysSum;
        RealizedCurrentTaskDaysSum = realizedCurrentTaskDaysSum;
        CurrentSubGoalsDaysDTOs = currentSubGoalsDaysDTOs;
        CurrentTaskDaysDTOs = currentTaskDaysDTOs;
    }

}
