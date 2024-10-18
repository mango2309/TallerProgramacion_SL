using System.ComponentModel.DataAnnotations;

namespace TallerProgramacion_SL.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre debe contener letras")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="La posicion es obligatoria")]
        [StringLength(50, ErrorMessage = "La posición no puede tener más de 50 caracteres.")]
        public string Posicion { get; set; }

        [Range(16, 45, ErrorMessage = "La edad del jugador debe estar entre 16 y 45 años.")]
        public int Edad {  get; set; }

        [Required(ErrorMessage = "El ID del equipo es obligatorio.")]
        public int EquipoId { get; set; }

        public Equipo Equipo { get; set; }



    }
}
