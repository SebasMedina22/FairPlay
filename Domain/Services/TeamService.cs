using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.DAL;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestionTorneoFutbol.Domain.Services
{
    public class TeamService: ITeamService
    {
        private readonly DataBaseContext _context;

        public TeamService(DataBaseContext context)
        {
            _context = context;
        }

        //List of teams
        public async Task<IEnumerable<Team>> GetTeamsAsync()
        {                                                      //Modifiqué esto para que salieran los datos de fairplay
            return await _context.Teams.Include(h => h.Players).Include(f=>f.FairPlays).ToListAsync();
        }
        //Teams by id
        public async Task<Team> GetTeamByIdAsync(Guid id)
        {
            return await _context.Teams.Include(h => h.Players)
                .FirstOrDefaultAsync(h => h.Id == id);

        }

    }
}
