using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Presentacion.Vista
{
    public interface ILoginView
    {
        string Usuario { get; }
        string Password { get; }

        event EventHandler LoginEvent;

        void MostrarMensaje(string mensaje);

        bool LoginExitoso { get; set; }
    }
}