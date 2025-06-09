using System.ComponentModel.DataAnnotations;

namespace ExamenFinal.Clases
{
    public class Animal
    {
        public static int cantidadAnimal { get; set; } = 0;

        [Required(ErrorMessage =
        "Ingrese un nombre valido")] public string? nombre { get; set; }

        [Required(ErrorMessage =
        "Ingrese una especie valida")]public string? especie { get; set; }

        [Required]
        [Range(1,70,ErrorMessage ="Ingrese una edad valida")]public int? edad { get; set; }
    }
}
