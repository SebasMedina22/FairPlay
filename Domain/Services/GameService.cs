using GestionTorneoFutbol.DAL;
using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestionTorneoFutbol.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly DataBaseContext _context;

        public GameService(DataBaseContext context)
        {
            _context = context;
        }
        //Get games per round
        public async Task<IEnumerable<Game>> GetGameByRoundAsync(int round)
        {

            return await _context.Games
                .Where(h => h.Round == round)
                .ToListAsync();

        }

        //Games are created based on fixture information
        public async Task CreateGamesAsync()
        {
            try
            {
                var fixture = await _context.Fixtures.ToListAsync(); //Search the lists of registered fixture
                List<Game> games = GenerateGames(fixture); // An empty Game list is created that will receive what is returned by the "GenerateGames(fixture)" method


                _context.Games.AddRange(games);


                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al generar y guardar los juegos", ex);
            }
        }
        //Private method that contains the logic of how to generate a fixture
        private List<Game> GenerateGames(List<Fixture> fixture) //This method receives a list of fixture as a parameter
        {
            List<Game> games = new List<Game>(); //an empty list is created to fill

            // Iterate through each fixture to create corresponding games.
            foreach (var fix in fixture)
            {
                // Create a new Game object for the current fixture.
                var game = new Game
                {
                    Round = fix.Round,
                    TeamA = fix.TeamA,
                    TeamB = fix.TeamB,
                    FixtureId = fix.Id
                };
                // Add the generated game to the list.
                games.Add(game);
            }
            // Return the list of games for all fixtures.
            return games;
        }
        //Edit the games by adding the goals of the result and the referee who directed the game

        public async Task<Game> EditGameAsync(Guid id, int goalsA, int goalsB, int docReferee)
        {
            try
            {
                // Retrieve the game from the database based on its unique identifier.
                var game = await _context.Games.FirstOrDefaultAsync(o => o.Id == id);
                game.ModifiedDate = DateTime.Now; //Create the modification date
                game.GoalsA = goalsA; 
                game.GoalsB = goalsB;
                game.DocReferee = docReferee;

                await _context.SaveChangesAsync();


                return game;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }

        }


    }
}
