using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{

    /// <summary>
    /// This  class represents the Actor with his/her properties
    /// </summary>
    public class Actor:IEntityBase
    {

        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full must be between 3 and 50 chars")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; } 
    }
}
