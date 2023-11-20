using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestionTorneoFutbol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : Controller
    {

        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        //List of teams
        [HttpGet, ActionName("Get")]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeamsAsync()
        {
            var teams = await _teamService.GetTeamsAsync();

            if (teams == null || !teams.Any())
            {
                return NotFound(); //NotFound = 404 Http Status Code
            }
            return Ok(teams); //Ok = 200 Http Status Code
        }
        //Teams by id
        [HttpGet, ActionName("Get")]
        [Route("GetById")]
        public async Task<ActionResult<Team>> GetTeamByIdAsync(Guid id)
        {
            if (id == null) return BadRequest("Id is required!");

            var team = await _teamService.GetTeamByIdAsync(id);

            if (team == null) return NotFound(); // 404

            return Ok(team); // 200
        }
    }
    }
