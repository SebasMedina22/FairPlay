using GestionTorneoFutbol.DAL.Entities;

namespace GestionTorneoFutbol.Domain.Interfaces
{
    public interface IFixtureService
    {
        //List of Fixtures
        Task<IEnumerable<Fixture>> GetFixturesAsync();
        //Generate Fixture based on previously registered Teams
        Task GenerateAndSaveFixtureAsync();


    }
}
