using System.ComponentModel.DataAnnotations;

namespace ExamenFinal.Clases
{
    public class Perro : Animal
    {
        [Required] public string? especie {  get; set; }

        [Required] public string? tamaño { get; set; }
    }
}
