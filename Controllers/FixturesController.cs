using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestionTorneoFutbol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FixturesController : Controller
    {
        private readonly IFixtureService _fixtureService;

        public FixturesController(IFixtureService fixtureService)
        {
            _fixtureService = fixtureService;
        }
        //List of Fixtures
        [HttpGet, ActionName("Get")]
        [Route("GetFixture")]
        public async Task<ActionResult<IEnumerable<Fixture>>> GetFixturesAsync()
        {
            var fixtures = await _fixtureService.GetFixturesAsync();

            if (fixtures == null || !fixtures.Any())
            {
                return NotFound(); //NotFound = 404 Http Status Code
            }
            return Ok(fixtures); //Ok = 200 Http Status Code
        }

        //Generate Fixture based on previously registered Teams

        [HttpPost]
        [Route("GenerateAndSaveFixture")]
        public async Task<ActionResult> GenerateAndSaveFixture()
        {
            try
            {
                await _fixtureService.GenerateAndSaveFixtureAsync();
                return Ok("Fixture generated and saved successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, ex.Message);
            }
        }


    }
}
