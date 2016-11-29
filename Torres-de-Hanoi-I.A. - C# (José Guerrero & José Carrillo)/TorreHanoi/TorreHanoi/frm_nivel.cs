using System;
using System.Windows.Forms;

namespace TorreHanoi
{

    public partial class frm_nivel : Form
    {
        private int n = 3;//Variable de cantidad de discos
        private int clase = 0;//Variable con la clase del juego

        /// <summary>
        /// Contructor del formulario
        /// </summary>
        /// <param name="x"></param> clase del juego
        public frm_nivel(int x)
        {
            InitializeComponent();
            clase = x;
        }

        /// <summary>
        /// Evento para jugar segun el nivel elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            jugar(clase);
        }

        /// <summary>
        /// Metodo de seleccion de juego segun la clase
        /// </summary>
        /// <param name="x"></param>
        private void jugar(int x)
        {
            if (x == 1)// if para las opciones de juego
            {
                frm_play play = new frm_play(n);
                play.Show();
                this.Hide();
            }
            else
            {
                frm_demo demo = new frm_demo(n);
                this.Hide();
                demo.Show();
                demo.doHanoi(n, "A", "C", "B", true);// llamdo al metodo que mueve los discos de la torre
            }
        }

        /// <summary>
        /// Numero de discos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_basic_CheckedChanged(object sender, EventArgs e)
        {
            n = 3;
        }

        /// <summary>
        /// Numero de discos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_medium_CheckedChanged(object sender, EventArgs e)
        {
            n = 6;
        }

        /// <summary>
        /// Numero de discos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_advanced_CheckedChanged(object sender, EventArgs e)
        {
            n = 8;
        }

        /// <summary>
        /// Cierra formulario y muestra formulario del menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            menu.Show();
            this.Close();
        }
    }
}
