using GestionTorneoFutbol.DAL;
using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestionTorneoFutbol.Domain.Services
{
    public class FairPlayService : IFairPlayService
    {
        private readonly DataBaseContext _context;
        public FairPlayService(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<FairPlay> EditFairPlayAsync(Guid teamId, int redCards, int yellowCards)
        {
            try
            {
                var fairPlay = await _context.FairPlays.FirstOrDefaultAsync(f => f.TeamId == teamId);

                if (fairPlay == null)
                {
                    // To handle the case where the FairPlay object for the team is not found.
                    return null;
                }

                // Update the cards and the modification date
                fairPlay.ModifiedDate = DateTime.Now;
                fairPlay.RedCard += redCards;
                fairPlay.YellowCard += yellowCards;

                // Calculate the points automatically.
                fairPlay.Points = CalculatePointsFairPlay(fairPlay.YellowCard, fairPlay.RedCard);

                await _context.SaveChangesAsync(); // Guardar en la base de datos

                return fairPlay;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }

        public async Task<IEnumerable<FairPlay>> GetFairPlayAsync()
        {
            var fairPlays = await _context.FairPlays.ToListAsync();

            // Calculate the points automatically before returning the results.
            foreach (var fairPlay in fairPlays)
            {
                fairPlay.Points = CalculatePointsFairPlay(fairPlay.YellowCard, fairPlay.RedCard);
            }

            // Order the fairPlays by points in ascending order (from menor to mayor).
            var orderedFairPlays = fairPlays.OrderBy(fp => fp.Points);

            return orderedFairPlays;
        }

        #region Private Methods
        private int CalculatePointsFairPlay(int yellowCards, int redCards)
        {
            // The logic is to add 5 points for each yellow card and 10 points for each red card
            int YellowPoints = yellowCards * 5;
            int RedPoints = redCards * 10;

            // Add up the total points
            int TotalPoints = YellowPoints + RedPoints;

            return TotalPoints;
        }
        #endregion
    }
}
