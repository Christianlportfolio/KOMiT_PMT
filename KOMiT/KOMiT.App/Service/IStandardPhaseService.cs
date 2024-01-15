using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public  interface IStandardPhaseService
{
    Task CreatePhase(StandardPhase standardPhase);
}
