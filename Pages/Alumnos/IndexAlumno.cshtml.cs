using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaCarreras.Data;
using SistemaCarreras.Models;
using SistemaCarreras.Servicios;


namespace SistemaCarreras.Pages.AlumnosCreate
{
    public class IndexAlumnoModel : PageModel
    {
        public List<Alumno> Alumnos { get; set; }
        public void OnGet()
        {
            var RepoAlumno = new RepositorioCrudJson<Alumno>("alumnos");
            Alumnos = RepoAlumno.ObtenerTodos();
        }
    }
}
