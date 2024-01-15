namespace KOMiT.Core.Model;

public class StandardTask
{   
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public int? StandardSubGoalId { get; set; }
    public StandardSubGoal? StandardSubGoal { get; set; }

    public StandardTask() { }
    public StandardTask(int id, string title, string description) 
    { 
        Id = id;
        Title = title;
        Description = description;
    }
}
