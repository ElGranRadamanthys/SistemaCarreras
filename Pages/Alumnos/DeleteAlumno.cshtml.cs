using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Servicios;
using SistemaCarreras.Helpers;
using SistemaCarreras.Pages;


namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class DeleteAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }
        private readonly ServicioAlumno servicio;
        public DeleteAlumnoModel()
        {
            servicio = new ServicioAlumno();
        }

        public IActionResult OnGet(int id)
        {
            var alumno= servicio.BuscarPorId(id);
            if (alumno == null)
            {
                return RedirectToPage("IndexAlumno");
            }

            Alumno = alumno;
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            servicio.EliminarPorId(id);
            return RedirectToPage("IndexAlumno");
        }
    }
}
