using System.ComponentModel.DataAnnotations;

namespace GestionTorneoFutbol.DAL.Entities
{
    public class Game : AuditBase
    {
        [Required(ErrorMessage = "Field {0} is required!")]
        public int Round { get; set; }

        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public int? GoalsA { get; set; }
        public int? GoalsB { get; set; }
        public long? DocReferee { get; set; }

        //Relationship with the Fixture table

        public Fixture? Fixture { get; set; }

        [Display(Name = "Id Fixture")]
        public Guid FixtureId { get; set; }



    }

}
