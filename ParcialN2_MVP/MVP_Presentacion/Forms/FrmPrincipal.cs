using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Presentacion.Forms;

namespace MVP_Presentacion.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public string UsuarioLogueado
        {
            get
            {
                return lblUsuario.Text;
            }
            set
            {
                lblUsuario.Text = "Usuario: " + value;
            }
        }

        public FrmPrincipal(string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario: " + usuario;
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Abre formularios dentro del panel contenedor principal

        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;

            formulario.Show();
        }

        private void btnCraps_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCraps());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            Label lbl = new Label();

            lbl.Text = "Bienvenido al Sistema";
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 18);

            panelContenedor.Controls.Add(lbl);

            lbl.Left = (panelContenedor.Width - lbl.Width) / 2;
            lbl.Top = (panelContenedor.Height - lbl.Height) / 2;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
