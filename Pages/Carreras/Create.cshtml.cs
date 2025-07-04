using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Helpers;
using SistemaCarreras.Servicios;

namespace SistemaCarreras.Pages.Carreras
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new List<string>();

        private readonly ServicioCarrera servicio;

        public CreateModel()
        {
            servicio = new ServicioCarrera(); 
        }
        
        

        //public static List<Carrera> listaCarreras = new List<Carrera>();

        public void OnGet()
        {
            Modalidades = OpcionesModalidad.Lista;
        }
        

        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Carrera);
            return RedirectToPage("Index");
        }
    }
}
