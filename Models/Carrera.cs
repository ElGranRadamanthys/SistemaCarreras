using System.ComponentModel.DataAnnotations;

namespace SistemaCarreras.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Display(Name = "Duracion en Años")]
        [Required]
        public int DuracionAnios { get; set; }
        [Display(Name = "Titulo Otorgado")]
        [Required]
        public string? TituloOtorgado { get; set; }
        [Required]
        public string? Modalidad { get; set; } // virtual, presencial o hibrida
    }
}
