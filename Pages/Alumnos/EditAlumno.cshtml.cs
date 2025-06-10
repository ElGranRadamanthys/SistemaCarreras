using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;

namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class EditAlumnoModel : PageModel
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var a in DatosCompartidos.Alumnos)
            {
                if (a.Id == Alumno.Id)
                {
                    a.Nombre = Alumno.Nombre;
                    a.Apellido = Alumno.Apellido;
                    a.Email = Alumno.Email;
                    break;
                }
            }

            return RedirectToPage("Index");
        }
    }
}
