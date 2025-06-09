using System.ComponentModel.DataAnnotations;

namespace ExamenFinal.Clases
{
    public class Ave:Animal
    {
        [Required(ErrorMessage ="Seleccione una opcion valida")]
        public string pico { get; set; }

        public bool? vuela { get; set; }
    }
}
