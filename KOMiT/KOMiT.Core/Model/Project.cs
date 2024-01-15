using KOMiT.Core.Model.Enum;

namespace KOMiT.Core.Model;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProjectType ProjectType { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedStartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string? Comment { get; set; }
    public DateTime? RealizedDate { get; set; }

    public ICollection<CurrentPhase>? CurrentPhases { get; set; } = new List<CurrentPhase>();


    public Project()
    {
        EstimatedStartDate = DateTime.Now;
        EstimatedEndDate = DateTime.Now;
    }

    public Project(int id, string name, string description, ProjectType projectType, Priority priority, Status status, DateTime estimatedStartDate, DateTime estimatedEndDate, string? comment, DateTime? realizedDate, ICollection<CurrentPhase>? currentPhases)
    {
        Id = id;
        Name = name;
        Description = description;
        ProjectType = projectType;
        Priority = priority;
        Status = status;
        EstimatedStartDate = estimatedStartDate;
        EstimatedEndDate = estimatedEndDate;
        Comment = comment;
        RealizedDate = realizedDate;
        CurrentPhases = currentPhases;
    }
}
