using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Academia.Domain.Model;

namespace Academia.Data.Repositories
{
    public class AlumnoRepository
    {
        private readonly string _connectionString;

        public AlumnoRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public IEnumerable<Alumno> GetAll()
        {
            var alumnos = new List<Alumno>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Alumno";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alumnos.Add(new Alumno
                        {
                            IdAlumno = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Dni = reader.GetString(3),
                            FechaNacimiento = reader.GetDateTime(4),
                            Legajo = reader.IsDBNull(5) ? null : reader.GetString(5)
                        });
                    }
                }
            }

            return alumnos;
        }

        public void Add(Alumno alumno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Alumno (Nombre, Apellido, Dni, FechaNacimiento)
                 VALUES (@Nombre, @Apellido, @Dni, @FechaNacimiento)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    command.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                    command.Parameters.AddWithValue("@Dni", alumno.Dni);
                    command.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Alumno alumno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Alumno SET Nombre=@Nombre, Apellido=@Apellido, Legajo=@Legajo WHERE IdAlumno=@IdAlumno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAlumno", alumno.IdAlumno);
                    command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    command.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                    command.Parameters.AddWithValue("@Legajo", alumno.Legajo);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Alumno WHERE IdAlumno=@IdAlumno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAlumno", id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

