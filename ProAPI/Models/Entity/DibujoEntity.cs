using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProAPI.Models.Entity
{
    public class DibujoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public double Ancho { get; set; }
        [Required]
        public double Largo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Estado { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public int PujaInicial { get; set; }

    }
}
