using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class County
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele Județului este necesar")]
        [Display(Name = "Nume Județ")]
        public string? Name { get; set; }

        public ICollection<Cinema>? Cinemas { get; set; }
    }
}
