using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface ICompetenceRepository
{
    Task<ICollection<Competence>> GetAll();
    Task<ICollection<Competence>> GetDetails();
}
