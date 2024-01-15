using KOMiT.Core.Model.Enum;

namespace KOMiT.Core.Model;

public class CurrentPhase
{
    public int Id { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedStartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    //FK bliver lavet her (ProjectId)
    public int? ProjectId { get; set; }
    public Project? Project { get; set; }

    public ICollection<CurrentSubGoal>? CurrentSubGoals { get; set; }

    public ICollection<ProjectMember>? ProjectMembers { get; set; }

    //FK bliver lavet her (StandardPhaseId)
    public int StandardPhaseId { get; set; }
    public StandardPhase StandardPhase { get; set; }

    public CurrentPhase()
    {
    }

    public CurrentPhase(int id, Status status, DateTime estimatedStartDate, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, int? projectId, int standardPhaseId, StandardPhase standardPhase)
    {
        Id = id;
        Status = status;
        EstimatedStartDate = estimatedStartDate;
        EstimatedEndDate = estimatedEndDate;
        Comment = comment;
        RealizedDate = realizedDate;
        ProjectId = id;
        StandardPhaseId = standardPhaseId;
        StandardPhase = standardPhase;
    }

    public CurrentPhase(int id, Status status, DateTime estimatedStartDate, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, int? projectId, int standardPhaseId, StandardPhase standardPhase, ICollection<CurrentSubGoal>? currentSubGoals, ICollection<ProjectMember>? projectMembers) : this(id, status, estimatedStartDate, estimatedEndDate, comment, realizedDate, projectId, standardPhaseId, standardPhase)
    {
        CurrentSubGoals = currentSubGoals;
        ProjectMembers = projectMembers;
    }
}
