using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GestionTorneoFutbol.DAL.Entities
{
    public class FairPlay:AuditBase
    {
        [Required(ErrorMessage = "Field {0} is required!")]
        [Display(Name = "Date")]
        public int? Date { get; set; }

        [Display(Name = "Red cards")]
        [Required(ErrorMessage = "Field {0} is required!")]
        public int RedCard { get; set; }

        [Display(Name = "Yellow Cards")]
        [Required(ErrorMessage = "Field {0} is required!")]
        public int YellowCard { get; set; }

        [Display(Name = "Points")]
        public int Points { get; set; }

        //Relationship with the Teams table
        public Team? Team { get; set; }

        [Display(Name = "Id Team")]
        public Guid TeamId { get; set; } //FK
    }
}
