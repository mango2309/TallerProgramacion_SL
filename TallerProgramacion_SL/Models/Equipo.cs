using System.ComponentModel.DataAnnotations;

namespace TallerProgramacion_SL.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria.")]
        [StringLength(100, ErrorMessage = "La ciudad no puede tener más de 100 caracteres.")]
        public string Ciudad { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El número de títulos debe ser un valor positivo.")]
        public int Titulos { get; set; }

        [Required(ErrorMessage = "Debe especificar si acepta extranjeros.")]
        public bool AceptaExtranjeros { get; set; }

    }
}
