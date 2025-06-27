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
        [BindProperty]
        public Carrera Carrera { get; set; }
       // public List<string> Modalidades { get; set; } = new List<string>();
        
        public void OnGet(int id)
        {
            var Modalidades = OpcionesModalidad.Lista;

            Carrera? carrera = ServicioCarrera.BuscarPorId(id);
            if (carrera != null)
            {
                Carrera = carrera;
            }
        }

        public IActionResult OnPost()
        {
            var Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            ServicioCarrera.EditarCarrera(Carrera);

            return RedirectToPage("Index");
        }
    }
}
