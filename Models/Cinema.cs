using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class Cinema
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele Cinema-ului este necesar")]
        [Display(Name = "Nume Cinema")]
        public string? Name { get; set; }
    }
}
