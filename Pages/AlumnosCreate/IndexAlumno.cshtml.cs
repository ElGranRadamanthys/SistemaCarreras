using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Pages.Alumnos;

namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class IndexAlumnoModel : PageModel
    {
        public List<Alumno> Alumnos { get; set; }
        public void OnGet()
        {
            Alumnos = DatosCompartidos.Alumnos;
        }
    }
}
