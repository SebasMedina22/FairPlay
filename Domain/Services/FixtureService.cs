using GestionTorneoFutbol.DAL.Entities;
using GestionTorneoFutbol.DAL;
using GestionTorneoFutbol.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace GestionTorneoFutbol.Domain.Services
{
    public class FixtureService : IFixtureService
    {
        private readonly DataBaseContext _context;

        public FixtureService(DataBaseContext context)
        {
            _context = context;
        }
        //List of Fixtures
        public async Task<IEnumerable<Fixture>> GetFixturesAsync()
        {

            return await _context.Fixtures.ToListAsync();
        }
        //Generate Fixture based on previously registered Teams
        public async Task GenerateAndSaveFixtureAsync()
        {
            try
            {
                var teams = await _context.Teams.ToListAsync();  //Search the lists of registered teams
                List<Fixture> fixture = GenerateFixture(teams); // An empty Fixture list is created that will receive what is returned by the "GenerateFixture(teams)" method

                _context.Fixtures.AddRange(fixture);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            { 
                throw new Exception("Error generating and saving the fixture", ex);
            }
        }
        //Private method that contains the logic of how to generate a fixture
        private List<Fixture> GenerateFixture(List<Team> teams)//This method receives a list of teams as a parameter
        {
            List<Fixture> fixture = new List<Fixture>(); //an empty list is created to fill

            int numTeams = teams.Count; //The number of teams is counted
            int numRounds = numTeams - 1;//The number of rounds is the number of teams -1

            for (int round = 1; round <= numRounds; round++) //Loop that runs through the number of rounds
            {
                for (int i = 0; i < numTeams / 2; i++)//nested loop that loops through the number of games per round that equals teams/2
                {
                    // Get the names of the two teams for the current game
                    string teamA = teams[i].Name;
                    string teamB = teams[numTeams - 1 - i].Name;
                    // Create a new Fixture object for the current match.
                    Fixture fix = new Fixture
                    {
                        Round = round, // Puedes ajustar la fecha
                        TeamA = teamA,
                        TeamB = teamB
                    };
                    // Add the fixture to the list.
                    fixture.Add(fix);

                }

                // Rotate teams for the next round.
                Team temp = teams[numTeams - 1];
                for (int i = numTeams - 1; i > 1; i--)
                {
                    teams[i] = teams[i - 1];
                }
                teams[1] = temp;
            }
            // Return the list of fixtures for the entire tournament.
            return fixture;
        }

      
    }
}
