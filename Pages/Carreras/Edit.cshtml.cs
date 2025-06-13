using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Helpers;

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

            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == id)
                {
                    Carrera = c;
                    break;

                }
            }
        }

        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == Carrera.Id)
                {
                    c.Nombre = Carrera.Nombre;
                    c.Modalidad = Carrera.Modalidad;
                    c.DuracionAnios = Carrera.DuracionAnios;
                    c.TituloOtorgado = Carrera.TituloOtorgado;
                    break;
                }
            }

            return RedirectToPage("Index");
        }
    }
}
