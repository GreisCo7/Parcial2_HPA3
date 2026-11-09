using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Negocio.Interfaces
{
    // Define el contrato para la generación de hashes
    public interface IHashService
    {
        string GenerarHash(string textoPlano);
    }
}