using SistemaCarreras.Models;
using System.Text.Json;
using System.IO;
using System.ComponentModel;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;


namespace SistemaCarreras.Servicios
{
    public class ServicioAlumno
    {
        private static string ruta = "Data/alumnos.json";

        public static string LeerTextoDelArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }
            return "[]";
        }

        public static List<Alumno> ObtenerAlumnos()
        {
            string json = LeerTextoDelArchivo();
            var lista = JsonSerializer.Deserialize<List<Alumno>>(json);
            return lista ?? new List<Alumno>();
        }

        private static Alumno? BuscarAlumnoPorId(List<Alumno> lista, int id)
        {
            foreach (var alumno in lista)
            {
                if (alumno.Id == id)
                {
                    return alumno;
                }
            }
            return null;

        }

        public static void AgregarAlumno(Alumno nuevoAlumno)
        {
            
            var alumnos = ObtenerAlumnos();
            nuevoAlumno.Id = ObtenerNuevoId(alumnos);
            alumnos.Add(nuevoAlumno);
            GuardarAlumnos(alumnos);
        }

        public static int ObtenerNuevoId(List<Alumno> alumnos)
        {
            int maxId = 0;
            foreach (var alumno in alumnos)
            {
                if (alumno.Id > maxId)
                {
                    maxId = alumno.Id;
                }
            }
            return maxId + 1;
        }

        public static void GuardarAlumnos(List<Alumno> alumnos)
        {
            string textoJson = JsonSerializer.Serialize(alumnos);
            File.WriteAllText(ruta, textoJson);
        }

        public static Alumno? BuscarPorId(int id)
        {
            var lista = ObtenerAlumnos();
            return BuscarAlumnoPorId(lista, id);
        }

        public static void EliminarPorId(int id)
        {
            var lista = ObtenerAlumnos();
            var alumnoAEliminar = BuscarAlumnoPorId(lista, id);

            if (alumnoAEliminar != null)
            {
                lista.Remove(alumnoAEliminar);
                GuardarAlumnos(lista);
            }
        }

        public static void EditarAlumno(Alumno alumnoEditado)
        {
            var lista = ObtenerAlumnos();
            var alumnoExistente = BuscarAlumnoPorId(lista, alumnoEditado.Id);
            if (alumnoExistente != null)
            {
                alumnoExistente.Nombre = alumnoEditado.Nombre;
                alumnoExistente.Apellido = alumnoEditado.Apellido;
                alumnoExistente.Email = alumnoEditado.Email;
                GuardarAlumnos(lista);
            }
        }
        public static bool CDD(int dni)
        {
            return ObtenerAlumnos().Any(alumno => alumno.Dni == dni && alumno.Dni > 0);
        }

    }
}
