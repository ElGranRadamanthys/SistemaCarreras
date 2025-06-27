using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Servicios;


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

        

        public IActionResult OnPost()
        {
            /*if (DatosCompartidosAlumno.Alumnos.Any(a => a.Email == Alumno.Email))
            {
                ModelState.AddModelError("Alumno.Email", "Ya existe un alumno con este email.");
            }

            if (DatosCompartidosAlumno.Alumnos.Any(a => a.Dni == Alumno.Dni))
            {
                ModelState.AddModelError("Alumno.Dni", "Ya existe un alumno con este DNI.");
            }*/

            if (!ModelState.IsValid)
            {
                return Page();
            }

            ServicioAlumno.AgregarAlumno(Alumno);
            return RedirectToPage("IndexAlumno");

        }
    }
}

