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

    // Formulario encargado de ejecutar la lógica del juego Craps
    public partial class FrmCraps : Form
    {
        public FrmCraps()
        {
            InitializeComponent();
        }

        private void FrmCraps_Load(object sender, EventArgs e)
        {

        }
        // Generador de números aleatorios para los lanzamientos
        private Random numerosAleatorios = new Random();

        // Almacena el punto establecido por el jugador
        private int miPunto = 0;

        // Indica si existe una partida en curso
        private bool juegoEnCurso = false;

        // Valores especiales utilizados en las reglas del juego
        private enum NombresDados
        {
            DOS_UNOS = 2,
            TRES = 3,
            SIETE = 7,
            ONCE = 11,
            DOCE = 12
        }

        // Simula el lanzamiento de dos dados
        private int TirarDados()
        {
            int dado1 = numerosAleatorios.Next(1, 7);
            int dado2 = numerosAleatorios.Next(1, 7);

            int suma = dado1 + dado2;

            lblDado1.Text = "Dado 1: " + dado1;
            lblDado2.Text = "Dado 2: " + dado2;

            return suma;
        }

        // Ejecuta la lógica principal del juego Craps
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int sumaDeDados = TirarDados();

            // Primer lanzamiento

            if (!juegoEnCurso)
            {
                switch ((NombresDados)sumaDeDados)

                {
                    // Victoria inmediata
                    case NombresDados.SIETE:
                    case NombresDados.ONCE:

                        lblResultado.Text = "Resultado: ¡Ganaste!";
                        lblPunto.Text = "Punto: -";
                        break;

                    // Derrota inmediata
                    case NombresDados.DOS_UNOS:
                    case NombresDados.TRES:
                    case NombresDados.DOCE:

                        lblResultado.Text = "Resultado: Perdiste";
                        lblPunto.Text = "Punto: -";
                        break;

                    // Se establece el punto y continúa la partida
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
                // Si vuelve a salir el punto, gana
                if (sumaDeDados == miPunto)
                {
                    lblResultado.Text =
                        "Resultado: ¡Ganaste!";

                    juegoEnCurso = false;

                    lblPunto.Text = "Punto: -";
                }

                // Si sale 7 antes del punto, pierde
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
