using GestionTorneoFutbol.DAL.Entities;

namespace GestionTorneoFutbol.Domain.Interfaces
{
    public interface IGameService
    {
        //Get games per round
        Task<IEnumerable<Game>> GetGameByRoundAsync(int round);

        //Games are created based on fixture information
        Task CreateGamesAsync();

        //Edit the games by adding the goals of the result and the referee who directed the game
        Task<Game> EditGameAsync(Guid id, int goalsA, int goalsB, int docReferee);
    }
}
