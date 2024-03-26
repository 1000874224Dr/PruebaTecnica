using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Data
{
    public class Elemento
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El peso es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El peso debe ser mayor a uno")]

        public int Peso { get; set; }

        [Required(ErrorMessage = "Las calorías son obligatorias")]
        [Range(1, int.MaxValue, ErrorMessage = "Las calorías deben ser mayores a uno")]
        public int Calorias { get; set; }
       

    }
    
}
