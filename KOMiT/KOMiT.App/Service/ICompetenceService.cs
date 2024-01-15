using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public interface ICompetenceService
{
    Task<ICollection<Competence>> GetAll();
    Task<ICollection<Competence>> GetDetails();
}
