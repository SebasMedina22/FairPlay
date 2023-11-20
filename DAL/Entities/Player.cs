using System.ComponentModel.DataAnnotations;

namespace GestionTorneoFutbol.DAL.Entities
{
    public class Player : AuditBase
    {
        [Display(Name = "Identification document")]
        [Required(ErrorMessage = "Field {0} is required!")]
        public long Document { get; set; }

        [Display(Name = "Player")]
        [MaxLength(60, ErrorMessage = "The field {0} must have a maximum of {1} character")]
        [Required(ErrorMessage = "Field {0} is required!")]
        public string Name { get; set; }

        [Display(Name = "Shirt number")]
        [Required(ErrorMessage = "Field {0} is required!")]
        [Range(0, 99, ErrorMessage = "The shirt number must be from 0 to 99")]
        public int? Number { get; set; }

        [Required(ErrorMessage = "Field {0} is required!")]
        public int? Goals { get; set; }

        [Required(ErrorMessage = "Field {0} is required!")]
        public bool State { get; set; } //The status indicates whether the player is active or not.


        //Relationship with the Teams table
        public Team? Team { get; set; }

        [Display(Name = "Id Team")]
        public Guid TeamId { get; set; } //FK
    }

}
