using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Entidades
{
    // Representa la información de un usuario del sistema
    public class E_Usuario
    {
        // Identificador único del usuario
        public int Id { get; set; }

        // Nombre de usuario utilizado para iniciar sesión
        public string Usuario { get; set; }


        // Hash SHA-256 almacenado en la base de datos
        public string PasswordHash { get; set; }
    }
}
