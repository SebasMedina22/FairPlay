using System.ComponentModel.DataAnnotations;

namespace GestionTorneoFutbol.DAL.Entities
{
    public class Team : AuditBase
    {


        [Display(Name = "Team")]
        [MaxLength(60, ErrorMessage = "The field {0} must have a maximum of {1} character")]
        [Required(ErrorMessage = "Field {0} is required!")]
        public string Name { get; set; }

        [Display(Name = "Technical director")]
        [MaxLength(60, ErrorMessage = "The field {0} must have a maximum of {1} character")]
        [Required(ErrorMessage = "Field {0} is required!")]
        public string Technical { get; set; }


        //Relationship with the players table

        [Display(Name = "Players")]
        public ICollection<Player>? Players { get; set; }

        //Relationship with the FairPlay table
        [Display(Name = "Fair Play")]
        public ICollection<FairPlay>? FairPlays { get; set; }

    }
}
