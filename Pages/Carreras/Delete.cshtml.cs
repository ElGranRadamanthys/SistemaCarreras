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
        public IActionResult OnGet(int id)
        {
            var carrera= ServicioCarrera.BuscarPorId(id);
            if (carrera == null)
            {
               return RedirectToPage("Index");
            }

            Carrera = carrera;
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            ServicioCarrera.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}