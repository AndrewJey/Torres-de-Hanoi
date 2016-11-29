using System;
using System.Windows.Forms;

namespace TorreHanoi
{
    public partial class frm_Menu : Form
    {
        /// <summary>
        /// Contructor del formulario
        /// </summary>
        public frm_Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para mortrar el formulario de niveles
        /// </summary>
        /// <param name="clase"></param> envia la clase del juego
        private void claseJuego(int clase)
        {
            frm_nivel play = new frm_nivel(clase);
            play.Show();
        }

        /// <summary>
        /// Evento para selecionar el nivel de juego y esconde el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_play_Click(object sender, EventArgs e)
        {
            claseJuego(1);
            this.Hide();
        }

        /// <summary>
        /// Evento para selecionar el nivel del demo y esconde el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_demo_Click(object sender, EventArgs e)
        {
            claseJuego(2);
            this.Hide();
        }

        /// <summary>
        /// Evento que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
