using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Datos;
using MVP_Entidades;

namespace MVP_Negocio
{
    public class N_Usuario
    {
        public static E_Usuario Login(
         string usuario,
         string password)
        {
            return D_Usuario.Login(usuario, password);
        }
    }
}

