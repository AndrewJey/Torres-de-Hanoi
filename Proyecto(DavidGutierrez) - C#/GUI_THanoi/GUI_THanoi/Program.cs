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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_Principal());
        }
    }
}
