using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Pages.Carreras;
using SistemaCarreras.Servicios;


namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class CreateAlumnoModel : PageModel
    {
        
        [BindProperty]
        public Alumno Alumno { get; set; }
        private readonly ServicioAlumno servicio;
        public CreateAlumnoModel()
        {
            servicio = new ServicioAlumno();
        }

        
        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            

            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Alumno);
            return RedirectToPage("IndexAlumno");

        }
    }
}

