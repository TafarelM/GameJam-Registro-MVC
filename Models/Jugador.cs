using System.ComponentModel.DataAnnotations;

namespace GameJamProyecto.Models
{
    public class Jugador
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public string Hobbies { get; set; }

        public bool PagoRealizado { get; set; }
    }
}