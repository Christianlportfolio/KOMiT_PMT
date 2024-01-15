using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface ICurrentPhaseRepository
{
    Task<CurrentPhase> GetDetailsById(int id);
    Task<CurrentPhase> GetEstimatedAndRealizedData(int id);
}
