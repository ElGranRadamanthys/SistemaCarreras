using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SistemaCarreras.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Es necesario un nombre")]
        public string? Nombre { get; set; }
        [Display(Name = "Duracion en Años")]
        [Required(ErrorMessage = "Es necesario una duracion")]
        [Range(5, 7, ErrorMessage = "Debe tener entre 5 y 7 años")]
        public int? DuracionAnios { get; set; }
        [Display(Name = "Titulo Otorgado")]
        [Required(ErrorMessage = "Es necesario el nombre del titulo")]
        public string? TituloOtorgado { get; set; }
        [Required(ErrorMessage = "Es necesario especificar la modalidad")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 y 20 letras")]
        public string? Modalidad { get; set; } // virtual, presencial o hibrida
    }
}
