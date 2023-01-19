using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class Ticket
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Prenumele este necesar")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Numele este necesar")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Cinema-ul este necesar")]
        public int CinemaID { get; set; }
        public Cinema Cinema { get; set; }

        [Required(ErrorMessage = "Filmul este necesar")]
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

    }
}
