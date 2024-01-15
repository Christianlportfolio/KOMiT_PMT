using KOMiT.Core.Model;
using KOMiT.DataAccess.Repositories;

namespace KOMiT.App.Service.Implementations;

public class CompetenceService : ICompetenceService
{
    private ICompetenceRepository _competenceRepository;

    public CompetenceService(ICompetenceRepository competenceRepository)
    {
        _competenceRepository = competenceRepository;
    }
    public async Task<ICollection<Competence>> GetAll()
    {
        return await _competenceRepository.GetAll();
    }

    public async Task<ICollection<Competence>> GetDetails()
    {
        return await _competenceRepository.GetDetails();
    }
}
