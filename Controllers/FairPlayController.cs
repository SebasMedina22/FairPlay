using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionTorneoFutbol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FairPlayController : Controller
    {
        private readonly IFairPlayService _fairPlay;

        public FairPlayController(IFairPlayService fairPlayService)
        {
            _fairPlay = fairPlayService;
        }

        [HttpGet, ActionName("Get")]
        [Route("GetCards")]
        public async Task<ActionResult<IEnumerable<FairPlay>>> GetFairPlayAsync()
        {
            var cards = await _fairPlay.GetFairPlayAsync();

            if (cards == null || !cards.Any())
            {
                return NotFound(); //NotFound = 404 Http Status Code
            }
            return Ok(cards); //Ok = 200 Http Status Code
        }

        [HttpPut, ActionName("Edit")]
        [Route("Edit")]
        public async Task<ActionResult<FairPlay>> EditFairPlayAsync(FairPlay fairPlay, Guid teamId, int redCards, int yellowCards)
        {
            try
            {

                var editedFairPlay = await _fairPlay.EditFairPlayAsync(teamId, redCards, yellowCards);

                return Ok(editedFairPlay);

            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
