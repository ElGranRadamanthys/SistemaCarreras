using System.ComponentModel.DataAnnotations;

namespace SistemaCarreras.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Agregue un Nombre")]
        public string? Nombre { get; set; }
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Agregue un Apellido")]
        public string? Apellido { get; set; }
        [Display(Name = "DNI")]
        [Required(ErrorMessage = "Agregue un DNI")]
        public int? Dni { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Agregue su Fecha de nacimiento")]
        public string? FechaNacimiento { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Agregue un Email")]
        public string? Email { get; set; }
    }
}
