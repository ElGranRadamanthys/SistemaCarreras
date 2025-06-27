using SistemaCarreras.Models;
using System.Text.Json;

namespace SistemaCarreras.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
        
        private static int ultimoId = 0;
        public static int ObtenerNuevoId(List<Carrera> Carreras)
        {
            int maxId = 0;
            foreach (var carrera in Carreras)
            {
                if (carrera.Id > maxId)
                {
                    maxId = carrera.Id;
                }
            }
            return maxId + 1;
        }

    }
}
