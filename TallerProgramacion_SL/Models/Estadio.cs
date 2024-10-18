using System.ComponentModel.DataAnnotations;

namespace TallerProgramacion_SL.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(200, ErrorMessage = "La dirección no puede tener más de 200 caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria.")]
        [StringLength(100, ErrorMessage = "La ciudad no puede tener más de 100 caracteres.")]
        public string Ciudad { get; set; }

        [Range(1000, 100000, ErrorMessage = "La capacidad debe ser entre 1,000 y 100,000 personas.")]
        public int Capacidad { get; set; }
    }
}
