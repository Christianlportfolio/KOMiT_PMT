using System.ComponentModel.DataAnnotations;

namespace KOMiT.Core.Model;

public class StandardPhase
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }

    public ICollection<CurrentPhase> CurrentPhases { get; } = new List<CurrentPhase>();

    public ICollection<StandardSubGoal>? StandardSubGoals { get; set; } = new List<StandardSubGoal>();

    public StandardPhase() : this(0, "", "") { }
    public StandardPhase(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public StandardPhase(int id, string name, string description, ICollection<StandardSubGoal?> standardSubGoals) : this(id, name, description)
    {
        StandardSubGoals = standardSubGoals;
    }


}
