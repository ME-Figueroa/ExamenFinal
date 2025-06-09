using System.ComponentModel.DataAnnotations;

namespace ExamenFinal.Clases
{
    public class Gato:Animal
    {
        [Required(ErrorMessage ="Ingrese una opcion valida")]
        public string? pelaje { get; set; }

        public bool? domestico { get; set; }
    }
}
