using System;
using System.Windows.Forms;

namespace TorreHanoi
{
    public partial class frm_rules : Form
    {
        /// <summary>
        /// Contructor del formulario
        /// </summary>
        public frm_rules()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
