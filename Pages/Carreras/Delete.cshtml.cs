using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Servicios;

namespace SistemaCarreras.Pages.Carreras
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        private readonly ServicioCarrera servicio;
        public DeleteModel()
        {
            servicio = new ServicioCarrera();
        }

        public IActionResult OnGet(int id)
        {
            var carrera= servicio.BuscarPorId(id);
            if (carrera == null)
            {
               return RedirectToPage("Index");
            }

            Carrera = carrera;
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            servicio.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}