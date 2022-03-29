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
    public class Actor
    {

        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; } 
    }
}
