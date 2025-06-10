using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;

namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class DeleteAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }
        public void OnGet(int id)
        {
            foreach (var a in DatosCompartidos.Alumnos)
            {
                if (a.Id == id)
                {
                    Alumno = a;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            Alumno alumnoAEliminar = null;

            foreach (var a in DatosCompartidos.Alumnos)
            {
                if (a.Id == Alumno.Id)
                {
                    alumnoAEliminar = a;
                    break;
                }
            }

            if (alumnoAEliminar != null)
            {
                DatosCompartidos.Alumnos.Remove(alumnoAEliminar);

            }
            return RedirectToPage("Index");
        }
    }
}
