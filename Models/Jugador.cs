using System.ComponentModel.DataAnnotations;

namespace GameJamApp.Models
{
    public class Jugador
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public string hobbies { get; set; }

        [Display(Name = "¿Ya pagó la matrícula?")]
        public bool PagoMatricula { get; set; }
    }
}