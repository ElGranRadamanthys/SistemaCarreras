using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Models;
using SistemaCarreras.Data;
using SistemaCarreras.Helpers;

namespace SistemaCarreras.Pages.Carreras
{
    public class CreateModel : PageModel
    {

        
        
        public void OnGet()
        {
            Modalidades = OpcionesModalidad.Lista;
        }
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new(); 

        //public static List<Carrera> listaCarreras = new List<Carrera>();

        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Carrera.Id = DatosCompartidos.ObtenerNuevoId();
            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("Index");
        }
    }
}
