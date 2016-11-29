using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Carlos Salas G.
//Jhonatan Araya Valverde

namespace TorresdeHanoi
{
    public partial class frmMenuPrincipal : Form
    {

        int demo = 0;

    
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//boton para salir de la aplicación
        {
            Application.Exit();//comando para cerrar la aplicación
        }

        private void button1_Click(object sender, EventArgs e)// se llama al formulario que selecciona la dificultad
        {
            this.Hide();//esconder formulario
            frmDificultad dificultad = new frmDificultad();// instancia
            dificultad.demo = 0;
            dificultad.Show();//mostrar formulario instanciado
        }

        private void button2_Click(object sender, EventArgs e)//demo
        {
            this.Hide();
            demo = 1;
            frmDificultad dificultad = new frmDificultad();// instancia
            dificultad.demo = 1;
            dificultad.Show();//mostrar formulario instanciado
        }
    }
}
