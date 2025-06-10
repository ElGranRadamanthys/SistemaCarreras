using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Models;

namespace SistemaCarreras.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Carrera> Carreras { get; set; } = new();
        public List<Alumno> Alumnos { get; set; } = new();

        public void OnGet()
        {
            var carreraUno = new Carrera
            {
                Id = 1,
                Nombre = "Analista de sistemas",
                Modalidad = "Hibrida",
                DuracionAnios = 3,
                TituloOtorgado = "Analista de sistemas"
            };

            var carreraDos = new Carrera
            {
                Id = 2,
                Nombre = "Analista de sistemas",
                Modalidad = "Hibrida",
                DuracionAnios = 3,
                TituloOtorgado = "Analista de sistemas"
            };

            var carreraTres = new Carrera
            {
                Id = 3,
                Nombre = "Analista de sistemas",
                Modalidad = "Hibrida",
                DuracionAnios = 3,
                TituloOtorgado = "Analista de sistemas"
            };

            Carreras.Add(carreraUno);
            Carreras.Add(carreraDos);
            Carreras.Add(carreraTres); 


        }
    }
}
