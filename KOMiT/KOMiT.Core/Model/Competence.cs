namespace KOMiT.Core.Model
{
    public class Competence
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public Competence() { }
        public Competence(int id, string title, string description, string experience)
        {
            Id = id;
            Title = title;
            Description = description;
            Experience = experience;
        }

    }
}