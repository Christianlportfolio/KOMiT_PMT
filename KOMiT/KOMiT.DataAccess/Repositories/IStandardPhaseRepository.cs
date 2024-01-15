using KOMiT.Core.Model;

namespace KOMiT.DataAccess.Repositories;

public interface IStandardPhaseRepository
{
    Task CreatePhase(StandardPhase standardPhase);
}

