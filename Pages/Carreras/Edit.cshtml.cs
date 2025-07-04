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
        public Carrera? Carrera { get; set; }
        private readonly ServicioCarrera servicio;

        public EditModel()
        {
            servicio = new ServicioCarrera();
        }
        
        public void OnGet(int id)
        {
            var Modalidades = OpcionesModalidad.Lista;

            Carrera? carrera = servicio.BuscarPorId(id);
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

            servicio.Editar(Carrera);

            return RedirectToPage("Index");
        }
    }
}
