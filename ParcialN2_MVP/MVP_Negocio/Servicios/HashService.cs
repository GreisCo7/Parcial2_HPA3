using MVP_Negocio.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace MVP_Negocio.Servicios
{

    // Implementa la generación y verificación de hashes SHA-256
    public class HashService : IHashService, IVerificarHashService
    {

        // Genera un hash SHA-256 a partir de un texto plano
        public string GenerarHash(string textoPlano)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(
                    Encoding.UTF8.GetBytes(textoPlano));

                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        // Compara el hash generado con el hash almacenado
        public bool VerificarHash(string textoPlano,
                                  string hashAlmacenado)
        {
            string hashNuevo = GenerarHash(textoPlano);

            return hashNuevo == hashAlmacenado;
        }
    }
}