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
    public partial class frmDificultad : Form
    {
        public int demo = 0;
        public frmDificultad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// boton aceptar
        {
            this.Hide();//esconde el formulario
            torresHanoi juego1 = new torresHanoi();//llama al formulario del juego
            
            // condicional para seleccionar la dificultad
            if (rbtnFacil.Checked == true)// si facil esta marcado
            {
                juego1.NumAnillos = 3; //seran 3 discos
            }
            if (rbtnNormal.Checked == true)// si normal esta marcado
            {
                juego1.NumAnillos = 6; //seran 6 discos
            }
            if (rbtnUltraViolencia.Checked == true) //si dificil esta marcado
            {
                juego1.NumAnillos = 8;//seran 8 discos
            }
            juego1.demo = demo;
            juego1.Show(); // muestra el formulario
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            rbtnNormal.Checked = true;// al cargar el formulario marca por defento normal
        }
    }
}
