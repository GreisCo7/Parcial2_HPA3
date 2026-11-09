using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Negocio.Interfaces
{
    // Define el contrato para verificar hashes almacenados
    public interface IVerificarHashService
    {
        bool VerificarHash(string textoPlano, string hashAlmacenado);
    }
}