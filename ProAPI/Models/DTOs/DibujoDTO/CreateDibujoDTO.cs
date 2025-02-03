using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProAPI.Models.DTOs.DibujoDTO
{
    public class CreateDibujoDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Max char is 50")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ancho is required")]
        public double Ancho { get; set; }
        [Required(ErrorMessage = "Largo is required")]
        public double Largo { get; set; }
        [Required(ErrorMessage = "Estado is required")]
        [MaxLength(50, ErrorMessage = "Max char is 50")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Peso is required")]
        public int Peso { get; set; }
        [Required(ErrorMessage = "PujaInicial is required")]
        public int PujaInicial { get; set; }
    }
}