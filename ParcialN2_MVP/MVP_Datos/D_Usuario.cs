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
        public static E_Usuario Login(string usuario, string password)
        {
            try
            {
                using (MySqlConnection conexion =
                    new MySqlConnection(D_Conexion.cadenaConexion))
                {
                    conexion.Open();

                    string consulta =
                        "SELECT * FROM usuarios " +
                        "WHERE usuario = @usuario";

                    using (MySqlCommand cmd =
                        new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (MySqlDataReader reader =
                            cmd.ExecuteReader())
                        {
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
