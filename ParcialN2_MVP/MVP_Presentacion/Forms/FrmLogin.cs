using MVP_Presentacion.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Presentacion.Presentador;
using MVP_Presentacion.Forms;


namespace MVP_Presentacion
{
    public partial class FrmLogin : Form, ILoginView
    {
        public FrmLogin()
        {
            InitializeComponent();

            presenter = new LoginPresenter(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        public string Usuario => txtUsuario.Text;

        public string Password => txtContraseña.Text;

        public bool LoginExitoso { get; set; }
        public event EventHandler LoginEvent;

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);

            if (LoginExitoso)
            {
                FrmPrincipal principal =
                    new FrmPrincipal();

                principal.UsuarioLogueado = Usuario;

                principal.Show();

                this.Hide();
            }
        }

        private LoginPresenter presenter;
    }
}
