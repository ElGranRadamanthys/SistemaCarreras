using SistemaCarreras.Models;
using System.Text.Json;
using System.IO;
using System.ComponentModel;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;


namespace SistemaCarreras.Servicios
{
    public class ServicioAlumno
    {
        private readonly RepositorioCrudJson<Alumno> crud;
        public ServicioAlumno()
        {
            crud = new RepositorioCrudJson<Alumno>("alumnos");
        }

        public List<Alumno> ObtenerTodos()
        {
            return crud.ObtenerTodos();
        }

        public void Agregar(Alumno alumno)
        {
            crud.Agregar(alumno);
        }

        public Alumno? BuscarPorId(int id)
        {
            return crud.BuscarPorId(id);
        }

        public void Editar(Alumno alumno)
        {
            crud.Editar(alumno);
        }

        public void EliminarPorId(int id)
        {
            crud.EliminarPorId(id);
        }
    }
}
