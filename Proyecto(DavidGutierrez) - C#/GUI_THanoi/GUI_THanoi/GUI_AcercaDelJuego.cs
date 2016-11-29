/*
Sistema de juego desarrollado con fines didacticos y educativos
de libre uso y mejora para cualquiera que desee utilizarlo
con fines no lucrativos.

by wsullivan 2016.
*/

using System;
using System.Windows.Forms;

namespace GUI_THanoi
{
    public partial class GUI_AcercaDelJuego : Form
    {
        /// <summary>
        /// Metodo constructor de la clase
        /// </summary>
        public GUI_AcercaDelJuego()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo que devuelve al usuario al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VolverMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
