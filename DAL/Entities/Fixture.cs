using System.ComponentModel.DataAnnotations;

namespace GestionTorneoFutbol.DAL.Entities
{
    public class Fixture : AuditBase
    {


        public int Round { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }

        //Relationship with the Games table

        [Display(Name = "Games")]
        public ICollection<Game>? Games { get; set; }

    }
}
