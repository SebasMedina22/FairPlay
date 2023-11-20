using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.Domain.Interfaces;
using GestionTorneoFutbol.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionTorneoFutbol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
       public GamesController(IGameService gameService)
        {
            _gameService = gameService;
           
        }
        //Get games per round
        [HttpGet, ActionName("Get")]
        [Route("GetByRound")]
        public async Task<ActionResult<IEnumerable<Game>>> GetGameByRoundAsync(int round)
        {
            if (round == null) return BadRequest("Round is required!");

            var games = await _gameService.GetGameByRoundAsync(round);

            if (games == null || !games.Any())
            {
                return NotFound(); // NotFound = 404 Http Status Code
            }

            return Ok(games); // Ok = 200 Http Status Code
        }

        //Games are created based on fixture information
        [HttpPost]
        [Route("CreateGames")]
        public async Task<ActionResult> CreateGamesAsync()
        {
            try
            {
                await _gameService.CreateGamesAsync();
                return Ok("Games generated and saved successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, ex.Message);
            }
        }

        //Edit the games by adding the goals of the result and the referee who directed the game
        [HttpPut, ActionName("Edit")]
        [Route("EditGame")]
        public async Task<ActionResult<Game>> EditGameAsync(Guid id, int goalsA, int goalsB, int docReferee)
        {
            try
            {

                var editedGame = await _gameService.EditGameAsync(id, goalsA, goalsB, docReferee);
               return Ok(editedGame);

            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
