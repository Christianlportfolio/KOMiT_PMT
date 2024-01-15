using System.ComponentModel.DataAnnotations;

namespace KOMiT.Core.Model;

public class Employee
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string JobPosition { get; set; }
    [Required]
    public string Email { get; set; }

    public ICollection<ProjectMember>? ProjectMembers { get; set; } = new List<ProjectMember>();

    public ICollection<Competence>? Competences { get; set; }

    public Employee() { }

    public Employee(int id, string name, string jobPosition, string email, ICollection<Competence>? competences)
    {
        Id = id;
        Name = name;
        JobPosition = jobPosition;
        Email = email;
        Competences = competences;
    }

}
