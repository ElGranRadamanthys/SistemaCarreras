using SistemaCarreras.Models;
using SistemaCarreras.Pages.Alumnos;
namespace SistemaCarreras.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
        public static List<Alumno> Alumnos { get; set; } = new();
    }
}
