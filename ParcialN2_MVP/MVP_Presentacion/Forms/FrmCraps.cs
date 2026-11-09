using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Presentacion.Forms
{
    public partial class FrmCraps : Form
    {
        public FrmCraps()
        {
            InitializeComponent();
        }

        private void FrmCraps_Load(object sender, EventArgs e)
        {

        }

        private Random numerosAleatorios = new Random();

        private int miPunto = 0;

        private bool juegoEnCurso = false;

        private enum NombresDados
        {
            DOS_UNOS = 2,
            TRES = 3,
            SIETE = 7,
            ONCE = 11,
            DOCE = 12
        }

        private int TirarDados()
        {
            int dado1 = numerosAleatorios.Next(1, 7);
            int dado2 = numerosAleatorios.Next(1, 7);

            int suma = dado1 + dado2;

            lblDado1.Text = "Dado 1: " + dado1;
            lblDado2.Text = "Dado 2: " + dado2;

            return suma;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int sumaDeDados = TirarDados();

            if (!juegoEnCurso)
            {
                switch ((NombresDados)sumaDeDados)
                {
                    case NombresDados.SIETE:
                    case NombresDados.ONCE:

                        lblResultado.Text = "Resultado: ¡Ganaste!";
                        lblPunto.Text = "Punto: -";
                        break;

                    case NombresDados.DOS_UNOS:
                    case NombresDados.TRES:
                    case NombresDados.DOCE:

                        lblResultado.Text = "Resultado: Perdiste";
                        lblPunto.Text = "Punto: -";
                        break;

                    default:

                        miPunto = sumaDeDados;

                        lblPunto.Text = "Punto: " + miPunto;

                        lblResultado.Text =
                            "Resultado: Sigue lanzando";

                        juegoEnCurso = true;

                        break;
                }
            }
            else
            {
                if (sumaDeDados == miPunto)
                {
                    lblResultado.Text =
                        "Resultado: ¡Ganaste!";

                    juegoEnCurso = false;

                    lblPunto.Text = "Punto: -";
                }
                else if (sumaDeDados == 7)
                {
                    lblResultado.Text =
                        "Resultado: Perdiste";

                    juegoEnCurso = false;

                    lblPunto.Text = "Punto: -";
                }
            }
        }
    }
}
