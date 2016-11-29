using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresdeHanoi
{
    public partial class frmMsg : Form
    {
        

        public string Msg;

        public frmMsg()
        {
            InitializeComponent();
            

        }

        private void frmMsg_Load(object sender, EventArgs e)
        {
            lblMsg.Text = Msg;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            frmMenuPrincipal menu = new frmMenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();//esconder formulario
            frmDificultad dificultad = new frmDificultad();// instancia
            dificultad.Show();//mostrar formulario instanciado

        }
    }
}
