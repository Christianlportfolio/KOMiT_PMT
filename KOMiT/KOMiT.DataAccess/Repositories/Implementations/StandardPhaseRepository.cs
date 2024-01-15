using KOMiT.Core.Model;
using KOMiT.DataAccess.Persistence;

namespace KOMiT.DataAccess.Repositories.Implementations;

public class StandardPhaseRepository : IStandardPhaseRepository
{
    private DatabaseContext _context;
    public StandardPhaseRepository(DatabaseContext context)
    {
        _context = context;
    }
    public async Task CreatePhase(StandardPhase standardPhase)
    {
        var result = _context.StandardPhases.Add(standardPhase);
        await _context.SaveChangesAsync();
    }
}
