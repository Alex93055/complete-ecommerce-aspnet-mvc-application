using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace eTickets.Models
{

    /// <summary>
    /// Class Producer  with its properties
    /// </summary>
    public class Producer
    {


        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
