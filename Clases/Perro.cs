using System.ComponentModel.DataAnnotations;

namespace ExamenFinal.Clases
{
    public class Perro : Animal
    {
        [Required] public string? raza {  get; set; }

        [Required] public string? tamaño { get; set; }

        public Perro()
        {
            this.especie = "Perro";
        }
    }
}
