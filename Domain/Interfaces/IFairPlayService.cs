using GestionTorneoFutbol.DAL.Entities;

namespace GestionTorneoFutbol.Domain.Interfaces
{
    public interface IFairPlayService
    {
        Task<IEnumerable<FairPlay>> GetFairPlayAsync();
        Task<FairPlay> EditFairPlayAsync(Guid teamId, int redCards, int yellowCards);
    }
}
