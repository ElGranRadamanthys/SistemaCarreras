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
        public Alumno Alumno { get; set; }
        public void OnGet(int id)
        {
            Alumno? alumno = ServicioAlumno.BuscarPorId(id);
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
            ServicioAlumno.EditarAlumno(Alumno);
            return RedirectToPage("IndexAlumno");
        }
    }
}
