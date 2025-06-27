using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Helpers;
using SistemaCarreras.Servicios;

namespace SistemaCarreras.Pages.Carreras
{
    public class EditModel : PageModel
    {
        public List<string> Modalidades { get; set; } = new List<string>();
        [BindProperty]
        public Carrera Carrera { get; set; }
        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.Lista;

            Carrera? carrera = ServicioCarrera.BuscarPorId(id);
            if (carrera != null)
            {
                Carrera = carrera;
            }
        }

        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            ServicioCarrera.EditarCarrera(Carrera);

            return RedirectToPage("Index");
        }
    }
}
