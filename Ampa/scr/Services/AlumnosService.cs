﻿using System.Collections.Generic;
using System.Linq;
using Ampa.Modelo;
using Dapper;

namespace Ampa.Services
{
    public class AlumnoService : Service
    {
        public static AlumnoService GetInstance()
        {
            return new AlumnoService();
        }
        public AlumnoModel ObtenerAlumnosPorId(int id)
        {
            var query = @"SELECT * FROM Alumnos WHERE Id =" + id;
            return Connection.DbConnection.Query<AlumnoModel>(query).FirstOrDefault();
        }
        public List<AlumnoModel> ObtenerAlumnosPorSocioId(int socioId)
        {
            var query = @"SELECT * FROM Alumnos WHERE SocioId =" + socioId;
            return Connection.DbConnection.Query<AlumnoModel>(query).ToList();
        }

        public bool Update(AlumnoModel alumno)
        {
            var query = string.Format("Update Alumnos Set " +
                                      "Nombre = '{0}'," +
                                      "Apellidos ='{1}'," +
                                      "Curso = '{2}'" +
                                      "WHERE Id = {3}", alumno.Nombre, alumno.Apellidos, alumno.Curso, alumno.Id);
            return Connection.Execute(query) > 0;
        }

        public bool Insert(AlumnoModel alumno)
        {
            var query = string.Format("INSERT INTO Alumnos (Nombre,Apellidos, Curso, SocioId)" +
                                      "VALUES ('{0}','{1}','{2}',{3})", alumno.Nombre, alumno.Apellidos, alumno.Curso,
                alumno.SocioId);
            return Connection.Execute(query) > 0;
        }

        public bool Insert(List<AlumnoModel> alumnos)
        {
            foreach (var alumno in alumnos)
            {
                Insert(alumno);
            }
            return true;
        }       
    }
}