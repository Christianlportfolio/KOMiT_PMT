using KOMiT.Core.DTO_s;
using KOMiT.Core.Model;

namespace KOMiT.App.Service;

public interface ICurrentPhaseService
{
    Task<CurrentPhase> GetDetailsById(int id);
    Task<EstimatedAndRealizedDaysDTO> CalculatorEstimatedAndRealizedDaysDTO(int id);
}
