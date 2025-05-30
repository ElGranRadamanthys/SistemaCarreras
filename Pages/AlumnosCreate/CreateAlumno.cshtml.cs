using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Pages.Alumnos;

namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class CreateAlumnoModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public Alumno Alumno { get; set; }

        //public static List<Carrera> listaCarreras = new List<Carrera>();

        public static int ultimoId = 0;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ultimoId++;
            Alumno.Id = ultimoId;
            DatosCompartidos.Alumnos.Add(Alumno);
            return RedirectToPage("IndexAlumno");

        }
    }
}

