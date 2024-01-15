using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class CompetenceRepository : ICompetenceRepository
{
    private DatabaseContext _context;
    public CompetenceRepository(DatabaseContext context)
    {
        _context = context;
    }
    public async Task<ICollection<Competence>> GetAll()
    {
        var result = await _context.Competences
            .Select(x => new Competence
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Experience = x.Experience,
                Employee = new Employee { Id = x.Id, Name = x.Employee.Name }
            })
            .ToListAsync();

        return result;
    }

    public async Task<ICollection<Competence>> GetDetails()
    {
        var result = await _context.Competences
            .Select(c => new Competence
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                Experience = c.Experience
            })
            .ToListAsync();

        return result;
    }

}
