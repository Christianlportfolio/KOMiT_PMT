using KOMiT.App.Service.Implementations;
using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;
using Moq;
using static KOMiT.Core.DTO_s.EstimatedAndRealizedDaysDTO;

namespace KOMiT.Test;

public class CurrentPhaseServiceTest
{
    [Fact]
    public async Task CalculatorEstimatedAndRealizedDaysDTO_ShouldReturnValidDTO()
    {
        // Arrange
        int id = 1;
        var mockRepository = new Mock<ICurrentPhaseRepository>();
        var service = new CurrentPhaseService(mockRepository.Object);

        // Set up mock repository to return expected data
        var mockResult = new CurrentPhase
        {
            EstimatedStartDate = new DateTime(2023, 11, 09),
            EstimatedEndDate = new DateTime(2025, 12, 24),
            CurrentSubGoals = new List<CurrentSubGoal>
                {
                    new CurrentSubGoal
                    { Id = 1, Name = "E2E Test", EstimatedEndDate = new DateTime(2024,01,09), RealizedDate = new DateTime(2024,01,05),
                        CurrentTasks = new List<CurrentTask>
                        { new CurrentTask { Title = "Implementere textfixture for E2E", EstimatedNumberOfDays = new DateTime(2023, 12, 30), RealizedDate = new DateTime(2024, 01, 01)} } },

                     new CurrentSubGoal { Id = 2, Name = "Unit test", EstimatedEndDate = new DateTime(2024,06,09), RealizedDate = new DateTime(2024,11,05),
                        CurrentTasks = new List<CurrentTask>
                        { new CurrentTask { Title = "Implementere unit test", EstimatedNumberOfDays = new DateTime(2024, 07, 30), RealizedDate = new DateTime(2024, 08, 01)} } }
                },
            RealizedDate = new DateTime(2025, 12, 10),
        };
        mockRepository.Setup(repo => repo.GetEstimatedAndRealizedData(id)).ReturnsAsync(mockResult);

        double estimatedCurrentPhaseDays = 776;
        double realizedCurrentPhasesDays = 762;
        double estimatedCurrentSubGoalsDays = 61 + 213;
        double realizedCurrentSubGoalsDays = 57 + 362;
        double estimatedCurrentTasksDays = 51 + 264;
        double realizedCurrentTasksDays = 53 + 266;
        List<CurrentSubGoalsDaysDTO> currentSubGoalsDaysDTOs = new List<CurrentSubGoalsDaysDTO>
            {
                new CurrentSubGoalsDaysDTO {Name = "E2E Test", EstimatedCurrentSubGoalsDays = 61, RealizedCurrentSubGoalsDays = 57},
                new CurrentSubGoalsDaysDTO {Name = "Unit test", EstimatedCurrentSubGoalsDays = 213, RealizedCurrentSubGoalsDays = 362},

            };
        List<CurrentTaskDaysDTO> currentTasksDaysDTO = new List<CurrentTaskDaysDTO>
            {
                new CurrentTaskDaysDTO { Title = "Implementere textfixture for E2E", EstimatedCurrentTaksDays = 51, RealizedCurrentTaksDays = 53 },
                new CurrentTaskDaysDTO { Title = "Implementere unit test", EstimatedCurrentTaksDays = 264, RealizedCurrentTaksDays = 266 }
            };

        // Act
        var result = await service.CalculatorEstimatedAndRealizedDaysDTO(id);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(estimatedCurrentPhaseDays, result.EstimatedCurrentPhaseDaysSum);
        Assert.Equal(realizedCurrentPhasesDays, result.RealizedCurrentPhaseDaysSum);
        Assert.Equal(estimatedCurrentSubGoalsDays, result.EstimatedCurrentSubGoalsDaysSum);
        Assert.Equal(realizedCurrentSubGoalsDays, result.RealizedCurrentSubGoalsDaysSum);
        Assert.Equal(estimatedCurrentTasksDays, result.EstimatedCurrentTaskDaysSum);
        Assert.Equal(realizedCurrentTasksDays, result.RealizedCurrentTaskDaysSum);
        Assert.Collection(result.CurrentSubGoalsDaysDTOs,
           item =>
           {
               Assert.Equal("E2E Test", item.Name);
               Assert.Equal(61, item.EstimatedCurrentSubGoalsDays);
               Assert.Equal(57, item.RealizedCurrentSubGoalsDays);
           },
           item =>
           {
               Assert.Equal("Unit test", item.Name);
               Assert.Equal(213, item.EstimatedCurrentSubGoalsDays);
               Assert.Equal(362, item.RealizedCurrentSubGoalsDays);
           }
        );

        Assert.Collection(result.CurrentTaskDaysDTOs,
           item =>
           {
               Assert.Equal("Implementere textfixture for E2E", item.Title);
               Assert.Equal(51, item.EstimatedCurrentTaksDays);
               Assert.Equal(53, item.RealizedCurrentTaksDays);
           },
           item =>
           {
               Assert.Equal("Implementere unit test", item.Title);
               Assert.Equal(264, item.EstimatedCurrentTaksDays);
               Assert.Equal(266, item.RealizedCurrentTaksDays);
           }
        );
    }
}
