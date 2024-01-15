using KOMiT.Core.Model.Enum;

namespace KOMiT.Core.Model;
    public class CurrentTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime EstimatedNumberOfDays { get; set; }
        public string? Comment{ get; set; } 
        public DateTime? RealizedDate { get; set; }

        public int? CurrentSubGoalId { get; set; }
        public CurrentSubGoal? CurrentSubGoal { get; set; }
        public ICollection<ProjectMember>? ProjectMembers { get; set; }


        public CurrentTask() { }

        public CurrentTask(int id, string title, string description, Status status, DateTime estimatedNumberofDays, string? comment, DateTime? realizedDate, int? currentSubGoalId, ICollection<ProjectMember> projektMembers)
        {
            Id = id;
            Title = title; 
            Description = description;
            Status = status;
            EstimatedNumberOfDays= estimatedNumberofDays;
            Comment = comment;
            RealizedDate = realizedDate;
            CurrentSubGoalId = currentSubGoalId;
            ProjectMembers = projektMembers;
    }

}

