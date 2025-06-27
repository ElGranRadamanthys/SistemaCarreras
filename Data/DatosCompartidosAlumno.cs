using System.Text.Json;
using SistemaCarreras.Models;


namespace SistemaCarreras.Data

{
    public class DatosCompartidosAlumno
    {
        public static List<Alumno> Alumnos { get; set; } = new();
        private static int ultimoId = 0;
        public static int ObtenerNuevoId(List<Alumno> Alumnos)
        {
            int maxId = 0;
            foreach (var alumno in Alumnos)
            {
                if (alumno.Id > maxId)
                {
                    maxId = alumno.Id;
                }
            }
            return maxId + 1;
        }
    }
}
