using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using CLINICAUH.Models;

namespace CLINICAUH.Data
{
    public class PacientesDAO
    {
        public static List<Paciente> ObtenerPacientes()
        {
            List<Paciente> lista = new List<Paciente>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM Pacientes";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Paciente
                    {
                        IdPaciente = reader.GetInt32(0),
                        Cedula = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        PrimerApellido = reader.GetString(3),
                        FechaNacimiento = reader.GetDateTime(4),
                        Edad = reader.GetInt32(5),
                        Telefono = reader.GetString(6)
                    });
                }
            }
            return lista;
        }

        public static void AgregarPaciente(Paciente p)
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
            {
                conexion.Open();
                string query = "INSERT INTO Pacientes (Cedula, Nombre, PrimerApellido, FechaNacimiento, Edad, Telefono) VALUES (@Cedula, @Nombre, @Apellido, @Fecha, @Edad, @Telefono)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Cedula", p.Cedula);
                comando.Parameters.AddWithValue("@Nombre", p.Nombre);
                comando.Parameters.AddWithValue("@Apellido", p.PrimerApellido);
                comando.Parameters.AddWithValue("@Fecha", p.FechaNacimiento);
                comando.Parameters.AddWithValue("@Edad", p.Edad);
                comando.Parameters.AddWithValue("@Telefono", p.Telefono);
                comando.ExecuteNonQuery();
            }
        }
    }
}