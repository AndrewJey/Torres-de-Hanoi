/*
Sistema de juego desarrollado con fines didacticos y educativos
de libre uso y mejora para cualquiera que desee utilizarlo
con fines no lucrativos.

by wsullivan 2016.
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Data;

namespace GUI_THanoi
{
    public partial class GUI_Principal : Form
    {
        /// <summary>
        /// Objetos primitivos de referencias a los colores y graficos
        /// </summary>
        Color tipoDeColor;
        Graphics creacionDeGraficos;
        /// <summary>
        /// Objeto primitivo de referencia al tiempo
        /// </summary>
        Stopwatch tiempoPartida = new Stopwatch();
        /// <summary>
        /// Atributos principal para la implementacion, validaciones y restructuracion de las formas graficas,
        /// en los proceos de seleccion y confirmacion de los indices, ubucacion de graficos.
        /// </summary>
        private int serieA; //variable que valida la torre 1
        private int serieB; //variable que valida la torre 2
        private int serieC; //variable que valida la torre 3
        private int posicionamientoGrafico; //variable para posicionar los graficos en el panel
        private int cantidadDeDiscos; //Variable para registrar los discos a utilizar en la partida
        private int movimientos; //variable para registrar los moviemientos de la partida
        private int movimientosSolucion; //se crean las variables que cuentan los intentos, los anillos que deben usarse y el numero minimo de intentos que debe realizar
        private int[] torreI; //arreglo para los campos de la torre 1
        private int[] torreII; //arreglo para los campos de la torre 2
        private int[] torreIII; //arreglo para los campos de la torre 3
        private int discosA; //numero de discos en el momento de la torre 1
        private int discosB; //numero de discos en el momento de la torre 2
        private int discosC; //numero de discos en el momento de la torre 3
        private bool onSerieA; //variable booleana para saber en cual torre se esta colocando los discos
        private bool onSerieB; //variable booleana para saber en cual torre se esta colocando los discos
        private bool onSerieC; //variable booleana para saber en cual torre se esta colocando los discos
        private string listaSolucion; //variable para guardar la lista de soluciones al problema
        private int count; //variable contador para la solucion recursiva del problema
        /// <summary>
        /// Metodo constructor principal GUI_Hanoi
        /// Inicializacion de procesos
        /// </summary>
        public GUI_Principal()
        {
            InitializeComponent();
            creacionDeGraficos = panel_Torres.CreateGraphics();
        }
        /// <summary>
        /// Metodo vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void torresHanoi_Load(object sender, EventArgs e)
        {
            //Vacio
        }
        /// <summary>
        /// Metodo itenButton para salir del juego mediante una consulta al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string respuesta = Convert.ToString(MessageBox.Show("¿Desea salir del juego?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (respuesta.Equals("Yes"))
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ha cancelado el cierre", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Metodo menuItem para el nivel facil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Torres.Enabled = true;
            count = 0;
            dataGridView_Solucion.DataSource = null;
            dataGridView_Solucion.Rows.Clear();
            dataGridView_Solucion.Refresh();
            int facil = 3;
            int minimo = 7;
            validaciones(facil,minimo);
            solucionViaRecurrencia(facil,"1","2","3");
        }
        /// <summary>
        /// Metodo menuIten para el nivel medio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Torres.Enabled = true;
            count = 0;
            dataGridView_Solucion.DataSource = null;
            dataGridView_Solucion.Rows.Clear();
            dataGridView_Solucion.Refresh();
            int medio = 6;
            int minimo = 63;
            validaciones(medio,minimo);
            solucionViaRecurrencia(medio, "1", "2", "3");
        }
        /// <summary>
        /// Metodo menuIten para el nivel dificil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dificlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Torres.Enabled = true;
            count = 0;
            dataGridView_Solucion.DataSource = null;
            dataGridView_Solucion.Rows.Clear();
            dataGridView_Solucion.Refresh();
            int dificil = 8;
            int minimo = 255;
            validaciones(dificil,minimo);
            solucionViaRecurrencia(dificil, "1", "2", "3");
        }
        /// <summary>
        /// Metodo menuIten acerca del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acercaDelJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_AcercaDelJuego soporte = new GUI_AcercaDelJuego();
            soporte.Show();
        }
        /// <summary>
        /// Metodo menuIten para las normas del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normasDelJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Normas normas = new GUI_Normas();
            normas.Show();
        }
        /// <summary>
        /// Metodo interactivo de posicionamiento de las formas graficas respecto al evento Mouse_Move
        /// donde busca las posiciones X Y para validar colores
        /// </summary>
        public void dibujarDiscosEnTorres(){
            for (int a = 0; a < cantidadDeDiscos; a++)
            {
                creacionDeGraficos.FillRectangle(new SolidBrush(Color.Green), 130 - (torreI[a] * 10), 320 - (a * 20), 20 * torreI[a], 20);
                creacionDeGraficos.FillRectangle(new SolidBrush(Color.Green), 290 - (torreII[a] * 10), 320 - (a * 20), 20 * torreII[a], 20);
                creacionDeGraficos.FillRectangle(new SolidBrush(Color.Green), 450 - (torreIII[a] * 10), 320 - (a * 20), 20 * torreIII[a], 20);

                if (torreI[a] == 1 | torreII[a] == 1 | torreIII[a] == 1)
                {
                    if (torreI[a] == 1) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 1) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 1) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 2 | torreII[a] == 2 | torreIII[a] == 2)
                {
                    if (torreI[a] == 2) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 2) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 2) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 3 | torreII[a] == 3 | torreIII[a] == 3)
                {
                    if (torreI[a] == 3) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 3) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 3) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 4 | torreII[a] == 4 | torreIII[a] == 4)
                {
                    if (torreI[a] == 4) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 4) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 4) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 5 | torreII[a] == 5 | torreIII[a] == 5)
                {
                    if (torreI[a] == 5) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 5) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 5) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 6 | torreII[a] == 6 | torreIII[a] == 6)
                {
                    if (torreI[a] == 6) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 6) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 6) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 7 | torreII[a] == 7 | torreIII[a] == 7)
                {
                    if (torreI[a] == 7) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 7) {
                        posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 7) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
                if (torreI[a] == 8 | torreII[a] == 8 | torreIII[a] == 8)
                {
                    if (torreI[a] == 8) {
                        posicionamientoGrafico = 132 - (torreI[a] * 10);
                    }
                    if (torreII[a] == 8)
                    { posicionamientoGrafico = 292 - (torreII[a] * 10);
                    }
                    if (torreIII[a] == 8) {
                        posicionamientoGrafico = 452 - (torreIII[a] * 10);
                    }
                }
            }
    }
        /// <summary>
        /// Metodo que levanta las formas graficas en el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Torres_Paint(object sender, PaintEventArgs e)
        {
            crearTorres();
            dibujarDiscosEnTorres();
        }
        /// <summary>
        /// Metodo calculador del tiempo de la partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Partida_Tick(object sender, EventArgs e)
        {
            tiempoPartida.Start();
            if (tiempoPartida.IsRunning)
            {
                TimeSpan ts = tiempoPartida.Elapsed;
                this.lbl_Cronometro.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }
        /// <summary>
        /// Metodo donde se crea en entorno grafico de las torres mediante objetos Grafics
        /// </summary>
        public void crearTorres() {
            //Dibuja el entorno grafico de la Torre I
            creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 60, 340, 140, 10); //Entorno horizontal
            creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 125, 100, 10, 250);//Entonrno vertical
            //Dibuja el entorno grafico de la Torre II
            creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 220, 340, 140, 10);//Entorno horizontal
            creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 285, 100, 10, 250);//Entorno vertical
            //Dibuja el entorno grafico de la Torre III
            creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 380, 340, 140, 10);//Entorno horizontal
            creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 445, 100, 10, 250);//Entorno vertical
        }
        /// <summary>
        /// Metodo que recibe la cantidad de discos y movimientos minimos para realizar las validaciones de los movimientos en las torres
        /// </summary>
        /// <param name="auxiliar"></param>
        /// <param name="auxiliar2"></param>
        public void validaciones(int auxiliar, int auxiliar2) {
            lbl_NumeroMovimientos.Text = "0";
            lbl_ResultadoFinal.Text = "0";
            movimientosSolucion = auxiliar2;
            cantidadDeDiscos = auxiliar;
            timer_Partida.Stop();
            tiempoPartida.Reset();
            timer_Partida.Start();
            torreI = new int[cantidadDeDiscos];
            torreII = new int[cantidadDeDiscos];
            torreIII = new int[cantidadDeDiscos];
            discosA = cantidadDeDiscos;
            discosB = 0;
            discosC = 0;
            serieA = 1;
            serieB = 0;
            serieC = 0;
            for (int a = cantidadDeDiscos, b = 0; a > 0; a--, b++)
            {
                torreI[b] = a;
            }
            movimientos = 0;
            lbl_NumeroMovimientos.Text = Convert.ToString(movimientos);
            lbl_ResultadoFinal.Text = Convert.ToString(movimientosSolucion);            
            this.Refresh();
        }
        /// <summary>
        /// Metoto que realiza la practica de validacion del movimiento del disco seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Torres_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X >= 0 & e.X <= 170) & (serieA != 0))
            {
                onSerieA = true;
                onSerieB = false;
                onSerieC = false;
            }
            if ((e.X > 170 & e.X <= 330) & (serieB != 0))
            {
                onSerieB = true;
                onSerieA = false;
                onSerieC = false;
            }
            if ((e.X > 330 & e.X <= 500) & (serieC != 0))
            {
                onSerieC = true;
                onSerieA = false;
                onSerieB = false;
            }
        }
        /// <summary>
        /// Metodo que dibuja los anillos en movimiento simpre validando su uso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Torres_MouseMove(object sender, MouseEventArgs e)
        {
            if (onSerieA | onSerieB | onSerieC) {
                this.Refresh();
            }
            if (onSerieA)
            {
                int x = e.X - (10 * torreI[discosA - 1]);
                int y = e.Y - 10;
                creacionDeGraficos.FillRectangle(new SolidBrush(Color.Green), x, y, 20 * torreI[discosA - 1], 20);
                if (torreI[discosA - 1] == 1) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 2) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 3) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 4) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 5) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 6) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 7) { tipoDeColor = Color.Green; }
                if (torreI[discosA - 1] == 8) { tipoDeColor = Color.Green; }
            }
            if (onSerieB)
            {
                int x = e.X - (10 * torreII[discosB - 1]);
                int y = e.Y - 10;
                creacionDeGraficos.FillRectangle(new SolidBrush(Color.Green), x, y, 20 * torreII[discosB - 1], 20);
                if (torreII[discosB - 1] == 1) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 2) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 3) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 4) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 5) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 6) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 7) { tipoDeColor = Color.Green; }
                if (torreII[discosB - 1] == 8) { tipoDeColor = Color.Green; }
            }
            if (onSerieC)
            {
                int x = e.X - (10 * torreIII[discosC - 1]);
                int y = e.Y - 10;
                creacionDeGraficos.FillRectangle(new SolidBrush(Color.Green), x, y, 20 * torreIII[discosC - 1], 20);
                if (torreIII[discosC - 1] == 1) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 2) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 3) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 4) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 5) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 6) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 7) { tipoDeColor = Color.Green; }
                if (torreIII[discosC - 1] == 8) { tipoDeColor = Color.Green; }
            }
        }
        /// <summary>
        /// Metodo que realiza la validacion sobre las reglas de los discos y sus manipulaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Torres_MouseUp(object sender, MouseEventArgs e)
        {
            int auxiliar = cantidadDeDiscos;
            int auxiliar2 = movimientosSolucion;
            if ((e.X >= 0 & e.X <= 170) & onSerieB & ((serieB < serieA) | serieA == 0))
            {
                serieA = serieB;
                torreI[discosA] = serieB;
                if (discosB > 1)
                {
                    serieB = torreII[discosB - 2];
                }
                else
                {
                    serieB = torreII[discosB];
                }
                torreII[discosB - 1] = 0;
                discosA++;
                discosB--;
                movimientos++;
            }
            if ((e.X >= 0 & e.X <= 170) & onSerieC & ((serieC < serieA) | serieA == 0))
            {
                serieA = serieC;
                torreI[discosA] = serieC;
                if (discosC > 1)
                {
                    serieC = torreIII[discosC - 2];
                }
                else
                {
                    serieC = torreIII[discosC];
                }
                torreIII[discosC - 1] = 0;
                discosA++;
                discosC--;
                movimientos++;
            }
            if ((e.X > 170 & e.X <= 330) & onSerieA & ((serieA < serieB) | serieB == 0))
            {
                serieB = serieA;
                torreII[discosB] = serieA;
                if (discosA > 1)
                {
                    serieA = torreI[discosA - 2];
                }
                else
                {
                    serieA = torreI[discosA];
                }
                torreI[discosA - 1] = 0;
                discosB++;
                discosA--;
                movimientos++;
            }
            if ((e.X > 170 & e.X <= 330) & onSerieC & ((serieC < serieB) | serieB == 0))
            {
                serieB = serieC;
                torreII[discosB] = serieC;
                if (discosC > 1)
                {
                    serieC = torreIII[discosC - 2];
                }
                else
                {
                    serieC = torreIII[discosC];
                }
                torreIII[discosC - 1] = 0;
                discosB++;
                discosC--;
                movimientos++;
            }
            if ((e.X > 330 & e.X <= 500) & onSerieA & ((serieA < serieC) | serieC == 0))
            {
                serieC = serieA;
                torreIII[discosC] = serieA;
                if (discosA > 1)
                {
                    serieA = torreI[discosA - 2];
                }
                else
                {
                    serieA = torreI[discosA];
                }
                torreI[discosA - 1] = 0;
                discosC++;
                discosA--;
                movimientos++;
            }
            if ((e.X > 330 & e.X <= 5000) & onSerieB & ((serieB < serieC) | serieC == 0))
            {
                serieC = serieB;
                torreIII[discosC] = serieB;
                if (discosB > 1)
                {
                    serieB = torreII[discosB - 2];
                }
                else
                {
                    serieB = torreII[discosB];
                }
                torreII[discosB - 1] = 0;
                discosC++;
                discosB--;
                movimientos++;
            }
            onSerieA = false;
            onSerieB = false;
            onSerieC = false;
            this.Refresh();
            lbl_NumeroMovimientos.Text = Convert.ToString(movimientos);
            if ((torreIII[cantidadDeDiscos - 1] == 1 ))
            {                
                movimientosSolucion = 0;

                for (int i = 1; i <= movimientosSolucion; i++)
                {
                    movimientosSolucion = (movimientosSolucion * 2) + 1;
                }
                if (movimientos > movimientosSolucion || movimientos.Equals(movimientosSolucion))
                {
                    timer_Partida.Stop();
                    string mensaje = Convert.ToString(MessageBox.Show("Juego terminado satisfactoriamente\n\n" + "Total " + movimientos + " movimientos  de " + movimientosSolucion + "\n\n¿Voler a Jugar?\n", "Mensaje del Sistema", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question));
                    if (mensaje.Equals("Retry"))
                    {
                        switch (auxiliar) {
                            case 3:
                                validaciones(auxiliar,auxiliar2);
                                break;
                            case 5:
                                validaciones(auxiliar, auxiliar2);
                                break;
                            case 8:
                                validaciones(auxiliar, auxiliar2);
                                break;
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                this.Refresh();
            }
        }
        /// <summary>
        /// Metodo demostraciones del juego
        /// </summary>
        /// <param name="discosAuxiliar"></param>
        public void demostraciones(int discosAuxiliar) {
            int auxiliar = discosAuxiliar;
            switch (auxiliar)
            {
                case 3:
                    lbl_ResultadoFinal.Text = Convert.ToString(7);
                    lbl_NumeroMovimientos.Text = "0";
                    cantidadDeDiscos = discosAuxiliar;
                    torreI = new int[cantidadDeDiscos];
                    torreII = new int[cantidadDeDiscos];
                    torreIII = new int[cantidadDeDiscos];
                    for (int a = cantidadDeDiscos, b = 0; a > 0; a--, b++)
                    {
                        torreI[b] = a;
                    }
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 2; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 3; torreII[0] = 0; torreIII[0] = 1;
                    lbl_NumeroMovimientos.Text = "1";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 3; torreII[0] = 2; torreIII[0] = 1;
                    lbl_NumeroMovimientos.Text = "2";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 1; torreIII[1] = 0;
                    torreI[0] = 3; torreII[0] = 2; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "3";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 1; torreIII[1] = 0;
                    torreI[0] = 0; torreII[0] = 2; torreIII[0] = 3;
                    lbl_NumeroMovimientos.Text = "4";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 1; torreII[0] = 2; torreIII[0] = 3;
                    lbl_NumeroMovimientos.Text = "5";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 2;
                    torreI[0] = 1; torreII[0] = 0; torreIII[0] = 3;
                    lbl_NumeroMovimientos.Text = "6";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 1;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 2;
                    torreI[0] = 0; torreII[0] = 0; torreIII[0] = 3;
                    lbl_NumeroMovimientos.Text = "7";
                    this.Refresh();
                    break;
                case 6:
                    lbl_ResultadoFinal.Text = Convert.ToString(63);
                    lbl_NumeroMovimientos.Text = "0";
                    cantidadDeDiscos = discosAuxiliar;
                    torreI = new int[cantidadDeDiscos];
                    torreII = new int[cantidadDeDiscos];
                    torreIII = new int[cantidadDeDiscos];
                    for (int a = cantidadDeDiscos, b = 0; a > 0; a--, b++)
                    {
                        torreI[b] = a;
                    }
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 2; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 3; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 1; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "1";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 3; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 1; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "2";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 3; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 0; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "3";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "4";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "5";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 2; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "6";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 4; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 2; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "7";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 2; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "8";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 2; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "9";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "10";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 3; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "11";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 0; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "12";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 1; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "13";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 1; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "14";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 5; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 0; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "15";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "16";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 1; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "17";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 2; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "18";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 2; torreIII[1] = 3;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "19";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 2; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "20";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 2; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "21";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "22";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 4;
                    lbl_NumeroMovimientos.Text = "23";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "24";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "25";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "26";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 4; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "27";
                    this.Refresh();
                    Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 1;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "28";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 2;
                    lbl_NumeroMovimientos.Text = "29";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 2; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "30";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 1; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 2; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 6; torreII[0] = 5; torreIII[0] = 0;
                    lbl_NumeroMovimientos.Text = "31";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 1; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 2; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 0; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "32";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 2; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 1;
                    torreI[0] = 0; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "33";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 1;
                    torreI[0] = 2; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "34";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 3; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 4; torreIII[1] = 0;
                    torreI[0] = 2; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "35";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 4; torreIII[1] = 3;
                    torreI[0] = 2; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "36";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 3;
                    torreI[0] = 2; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "37";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 2;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 3;
                    torreI[0] = 0; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "38";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 0; torreII[1] = 4; torreIII[1] = 3;
                    torreI[0] = 0; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "39";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "40";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 1; torreII[1] = 0; torreIII[1] = 3;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "41";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 2; torreIII[1] = 3;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "42";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 2; torreIII[1] = 3;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "43";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 2; torreIII[1] = 0;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "44";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 2; torreIII[1] = 1;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "45";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 1;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "46";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 0;
                    torreI[0] = 4; torreII[0] = 5; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "47";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 1; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 0; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "48";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 2; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 1; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "49";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 1; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "50";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 3; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 0; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "51";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "52";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 2;
                    torreI[1] = 1; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "53";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 0;
                    torreI[1] = 1; torreII[1] = 2; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "54";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 0;
                    torreI[1] = 0; torreII[1] = 2; torreIII[1] = 5;
                    torreI[0] = 4; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "55";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 1; torreIII[2] = 4;
                    torreI[1] = 0; torreII[1] = 2; torreIII[1] = 5;
                    torreI[0] = 0; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "56";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 0; torreII[1] = 2; torreIII[1] = 5;
                    torreI[0] = 0; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "57";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 1;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 2; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "58";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 0;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 1; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 2; torreII[0] = 3; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "59";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 3;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 1; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 2; torreII[0] = 0; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "60";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 0;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 3;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 2; torreII[0] = 1; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "61";
                    this.Refresh(); Thread.Sleep(500);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 0;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 2;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 3;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 0; torreII[0] = 1; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "62";
                    this.Refresh(); Thread.Sleep(250);
                    torreI[5] = 0; torreII[5] = 0; torreIII[5] = 1;
                    torreI[4] = 0; torreII[4] = 0; torreIII[4] = 2;
                    torreI[3] = 0; torreII[3] = 0; torreIII[3] = 3;
                    torreI[2] = 0; torreII[2] = 0; torreIII[2] = 4;
                    torreI[1] = 0; torreII[1] = 0; torreIII[1] = 5;
                    torreI[0] = 0; torreII[0] = 0; torreIII[0] = 6;
                    lbl_NumeroMovimientos.Text = "63";
                    this.Refresh();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Metodo demo nivel facil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int auxiliar = 3;         
            timer_Partida.Stop();
            tiempoPartida.Reset();
            lbl_Cronometro.Text = "00:00:00:00";
            demostraciones(auxiliar);
            panel_Torres.Enabled = false;
        }
        /// <summary>
        /// Metodod demo nivel medio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int auxiliar = 6;
            timer_Partida.Stop();
            tiempoPartida.Reset();
            lbl_Cronometro.Text = "00:00:00:00";
            demostraciones(auxiliar);
            panel_Torres.Enabled = false;
        }
        /// <summary>
        /// Metodo demo nivel dificil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nivelDificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int auxiliar = 8;
            timer_Partida.Stop();
            tiempoPartida.Reset();
            lbl_Cronometro.Text = "00:00:00:00";
            demostraciones(auxiliar);
            panel_Torres.Enabled = false;
        }
        /// <summary>
        /// Metodo recursivo que nos muestra las soluciones del juego dependiendo el nivel a escoger
        /// </summary>
        /// <param name="numeroDiscos"></param>
        /// <param name="origen"></param>
        /// <param name="auxiliar"></param>
        /// <param name="destino"></param>
        public void solucionViaRecurrencia(int numeroDiscos, string origen, string auxiliar, string destino)
        {
            if (numeroDiscos == 1)
            {
                count++;
                listaSolucion = Convert.ToString(count + ". De Torre " + origen + " a " + destino + "\n");
                dataGridView_Solucion.Rows.Add(listaSolucion);
            }
            else
            {
                solucionViaRecurrencia(numeroDiscos - 1, origen, destino, auxiliar);
                count++;
                listaSolucion = Convert.ToString(count + ". De Torre " + origen + " a " + destino + "\n");
                dataGridView_Solucion.Rows.Add(listaSolucion);
                solucionViaRecurrencia(numeroDiscos - 1, auxiliar, origen, destino);
            }
        }
        /// <summary>
        /// Metodo boton de limpiar celdas en dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void limpiarCeldas_Click(object sender, EventArgs e) {
            dataGridView_Solucion.DataSource = null;
            dataGridView_Solucion.Rows.Clear();
            dataGridView_Solucion.ClearSelection();
        }
        /// <summary>
        /// Metodo que detinee la partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string respuesta = Convert.ToString(MessageBox.Show("¿Desea cancelar la partida?","Mensaje del Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if (respuesta.Equals("Yes"))
            {                
                tiempoPartida.Stop();
                timer_Partida.Stop();
                lbl_Cronometro.Text = "00:00:00:00";
                lbl_NumeroMovimientos.Text = "0";
                lbl_ResultadoFinal.Text = "0";
                panel_Torres.Enabled = false;
            }
        }
    }
}