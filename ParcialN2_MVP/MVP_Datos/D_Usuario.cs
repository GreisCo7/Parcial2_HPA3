using MVP_Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Datos
{
    public class D_Usuario
    {
        // Valida las credenciales del usuario contra la base de datos
        public static E_Usuario Login(string usuario, string password)
        {
            try
            {
                // Crea la conexión utilizando la cadena definida en D_Conexion
                using (MySqlConnection conexion =
                    new MySqlConnection(D_Conexion.cadenaConexion))
                {
                    conexion.Open();

                    // Consulta para obtener la información del usuario
                    string consulta =
                        "SELECT * FROM usuarios " +
                        "WHERE usuario = @usuario";

                    using (MySqlCommand cmd =
                        new MySqlCommand(consulta, conexion))
                    {
                        // Envía el usuario como parámetro para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (MySqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            // Si existe el usuario, se crea y retorna la entidad
                            if (reader.Read())
                            {
                                return new E_Usuario
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Usuario = reader["usuario"].ToString(),
                                    PasswordHash = reader["passwordHash"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch
            {
            }

            return null;
        }
    }
}
