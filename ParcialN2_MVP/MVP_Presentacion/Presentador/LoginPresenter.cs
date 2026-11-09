using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Negocio;
using MVP_Entidades;
using MVP_Presentacion.Vista;
using MVP_Negocio.Servicios;


namespace MVP_Presentacion.Presentador
{
    public class LoginPresenter
    {
        private readonly ILoginView vista;

        public LoginPresenter(ILoginView vista)
        {
            this.vista = vista;

            this.vista.LoginEvent += OnLogin;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(vista.Usuario) ||
                string.IsNullOrWhiteSpace(vista.Password))
            {
                vista.MostrarMensaje("Complete todos los campos.");
                return;
            }

            E_Usuario usuario =
                N_Usuario.Login(
                    vista.Usuario,
                    vista.Password);

            if (usuario != null)
            {
                HashService hashService = new HashService();

                bool passwordCorrecta =
                    hashService.VerificarHash(
                        vista.Password,
                        usuario.PasswordHash);

                if (passwordCorrecta)
                {
                    vista.LoginExitoso = true;

                }
                else
                {
                    vista.LoginExitoso = false;

                    vista.MostrarMensaje(
                        "Contraseña incorrecta.");
                }
            }

            else
            {
                vista.LoginExitoso = false;

                vista.MostrarMensaje(
                    "Usuario no encontrado.");
            }

        }
    }
}



