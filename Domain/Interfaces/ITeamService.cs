using GestionTorneoFutbol.DAL.Entities;

namespace GestionTorneoFutbol.Domain.Interfaces
{
    public interface ITeamService
    {
        //List of teams
        Task<IEnumerable<Team>> GetTeamsAsync();
        //Teams by id
        Task<Team> GetTeamByIdAsync(Guid id);

    }
}
