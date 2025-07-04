using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Servicios;
using SistemaCarreras.Helpers;

namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class EditAlumnoModel : PageModel
    {
        
        [BindProperty]
        public Alumno? Alumno { get; set; }
        private readonly ServicioAlumno servicio;
        public EditAlumnoModel()
        {
            servicio = new ServicioAlumno();
        }
        public void OnGet(int id)
        {
            Alumno? alumno = servicio.BuscarPorId(id);
            if (alumno != null)
            {
                Alumno = alumno;
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            servicio.Editar(Alumno);
            return RedirectToPage("IndexAlumno");
        }
    }
}
