using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace TorreHanoi
{
    public partial class frm_play : Form
    {
        private bool jugar = false;// se crea uan variable que se rellena con el valor si se esta jugando
        private int finalA, finalB, finalC; //se declaran las variables que "sellan" la torre
        private int intentos, numAnillos, intentosMin; //se crean las variables que cuentan los intentos, los anillos que deben usarse y el numero minimo de intentos que debe realizar
        private int[] torreA, torreB, torreC; // se utilizan vectores para las torres que estas cargan los anillos
        private int anillosA, anillosB, anillosC;//de crean las variables anillos para validar si se cumplen las reglas del juego
        private bool intA, intB, intC; // boleanos para las columnas
        private int numeroDiscos;//Numero de discos
        private int posx; // posicion del eje X
        private int comp = 0;//variable para control del tiempo
        private int comp2 = 0;//Variable para la pausa
        private Color color;//para colores del dibujo
        private Graphics crear;//crear el dibujo
        private Stopwatch cronos = new Stopwatch(); //stopwatch para la pausa

        /// <summary>
        /// Contructor del formulario
        /// </summary>
        /// <param name="n"></param>
        public frm_play(int numeroDiscos)
        {
            InitializeComponent();
            //crea el grafico del juego
            crear = juego.CreateGraphics();
            this.numeroDiscos = numeroDiscos;
            // inicializar
            Comenzar(numeroDiscos);
        }

        /// <summary>
        /// inicializa todos los componentes
        /// </summary>
        /// <param name="n"></param> los discos elegidos
        private void Comenzar(int n) {
            juego.Enabled = (true);
            btn_pause.Enabled = (true);
            btn_reset.Enabled = (true);
            this.btn_pause.Text = "Pausa";
            comp2 = 0;
            comp++;
            this.lblIntentos3.Text = "0";
            timer1.Start();

            numAnillos = System.Convert.ToInt32(n);
            torreA = new int[numAnillos];
            torreB = new int[numAnillos];
            torreC = new int[numAnillos];
            anillosA = numAnillos;
            anillosB = 0;
            anillosC = 0;
            finalA = 1;
            finalB = 0;
            finalC = 0;
            for (int a = numAnillos, b = 0; a > 0; a--, b++)
            { torreA[b] = a; }
            intentos = 0;
            this.btn_return.Enabled = true;
            if (comp != 0)
            {
                cronos.Reset();
            }
            lblIntentos2.Text = intentos.ToString();
            jugar = true;
            this.Refresh();
        }

        /// <summary>
        /// Timer para el tomar el tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            cronos.Start();//inicia el contador
            if (cronos.IsRunning)
            {
                TimeSpan ts = cronos.Elapsed;
                this.lblIntentos3.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }

        /// <summary>
        /// Evento para resetear el juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            // inicializar
            Comenzar(numeroDiscos);
        }

        /// <summary>
        /// Evento de movimiento de los discos de una torre a otra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void juego_MouseMove(object sender, MouseEventArgs e)
        {
            if (intA | intB | intC) { this.Refresh(); }
            //Torre A --> B  C
            if (intA)
            {
                crear.FillRectangle(new SolidBrush(Color.IndianRed), 90 - (torreA[anillosA - 1] * 10), 210 - ((anillosA - 1) * 20), 20 * torreA[anillosA - 1], 20);
                int x = e.X - (10 * torreA[anillosA - 1]);
                int y = e.Y - 10;
                crear.FillRectangle(new SolidBrush(Color.DarkRed), x, y, 20 * torreA[anillosA - 1], 20);
                crear.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * torreA[anillosA - 1]) - 4, 16);
            }
            //Torre B --> A  C
            if (intB)
            {
                crear.FillRectangle(new SolidBrush(Color.IndianRed), 250 - (torreB[anillosB - 1] * 10), 210 - ((anillosB - 1) * 20), 20 * torreB[anillosB - 1], 20);
                int x = e.X - (10 * torreB[anillosB - 1]);
                int y = e.Y - 10;
                crear.FillRectangle(new SolidBrush(Color.DarkRed), x, y, 20 * torreB[anillosB - 1], 20);
                crear.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * torreB[anillosB - 1]) - 4, 16);
            }
            //Torre C --> A  B
            if (intC)
            {
                crear.FillRectangle(new SolidBrush(Color.IndianRed), 410 - (torreC[anillosC - 1] * 10), 210 - ((anillosC - 1) * 20), 20 * torreC[anillosC - 1], 20);
                int x = e.X - (10 * torreC[anillosC - 1]);
                int y = e.Y - 10;
                crear.FillRectangle(new SolidBrush(Color.DarkRed), x, y, 20 * torreC[anillosC - 1], 20);
                crear.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * torreC[anillosC - 1]) - 4, 16);
            }
        }

        /// <summary>
        /// Evento validacion de disco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void juego_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X >= 0 & e.X <= 170) & (finalA != 0)) { intA = true; intB = false; intC = false; }
            if ((e.X > 170 & e.X <= 330) & (finalB != 0)) { intB = true; intA = false; intC = false; }
            if ((e.X > 330 & e.X <= 500) & (finalC != 0)) { intC = true; intA = false; intB = false; }
        }

        /// <summary>
        /// evento cuando suelta el anillo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void juego_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.X >= 0 & e.X <= 170) & intB & ((finalB < finalA) | finalA == 0))
            {
                finalA = finalB;
                torreA[anillosA] = finalB;
                if (anillosB > 1)
                { finalB = torreB[anillosB - 2]; }
                else
                { finalB = torreB[anillosB]; }
                torreB[anillosB - 1] = 0;
                anillosA++;
                anillosB--;
                intentos++;
            }
            if ((e.X >= 0 & e.X <= 170) & intC & ((finalC < finalA) | finalA == 0))
            {
                finalA = finalC;
                torreA[anillosA] = finalC;
                if (anillosC > 1)
                { finalC = torreC[anillosC - 2]; }
                else
                { finalC = torreC[anillosC]; }
                torreC[anillosC - 1] = 0;
                anillosA++;
                anillosC--;
                intentos++;
            }
            if ((e.X > 170 & e.X <= 330) & intA & ((finalA < finalB) | finalB == 0))
            {
                finalB = finalA;
                torreB[anillosB] = finalA;
                if (anillosA > 1)
                { finalA = torreA[anillosA - 2]; }
                else
                { finalA = torreA[anillosA]; }
                torreA[anillosA - 1] = 0;
                anillosB++;
                anillosA--;
                intentos++;
            }
            if ((e.X > 170 & e.X <= 330) & intC & ((finalC < finalB) | finalB == 0))
            {
                finalB = finalC;
                torreB[anillosB] = finalC;
                if (anillosC > 1)
                { finalC = torreC[anillosC - 2]; }
                else
                { finalC = torreC[anillosC]; }
                torreC[anillosC - 1] = 0;
                anillosB++;
                anillosC--;
                intentos++;
            }
            if ((e.X > 330 & e.X <= 500) & intA & ((finalA < finalC) | finalC == 0))
            {
                finalC = finalA;
                torreC[anillosC] = finalA;
                if (anillosA > 1)
                { finalA = torreA[anillosA - 2]; }
                else
                { finalA = torreA[anillosA]; }
                torreA[anillosA - 1] = 0;
                anillosC++;
                anillosA--;
                intentos++;
            }
            if ((e.X > 330 & e.X <= 5000) & intB & ((finalB < finalC) | finalC == 0))
            {
                finalC = finalB;
                torreC[anillosC] = finalB;
                if (anillosB > 1)
                { finalB = torreB[anillosB - 2]; }
                else
                { finalB = torreB[anillosB]; }
                torreB[anillosB - 1] = 0;
                anillosC++;
                anillosB--;
                intentos++;
            }
            intA = false; intB = false; intC = false;
            this.Refresh();
            lblIntentos2.Text = intentos.ToString();
            if ((torreC[numAnillos - 1] == 1) & jugar)
            {
                timer1.Stop();
                intentosMin = 0;
                for (int n = 1; n <= numAnillos; n++)
                { intentosMin = (intentosMin * 2) + 1; }
                if (intentos > intentosMin)
                {//muestra un mensaje diciendo que ha ganado pero en un numero mayor de intentos a lo esperado
                    string mejor = "Felicidades Ganador";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    string mensaje = "Lo finalizaste, pero haslo en " + intentosMin + " movimientos! Su tiempo " + this.lblIntentos3.Text + ", movimientos " + this.lblIntentos2.Text;
                    // Muestra el mensaje de ganador

                    result = MessageBox.Show(mensaje, mejor, buttons);


                }
                else
                {
                    MessageBox.Show("Lo finalizaste en la cantidad minima de movimientos posibles: " + this.lblIntentos2.Text, "Felicidades Ganador",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.Refresh();
                jugar = false;
            }
        }

        /// <summary>
        /// Si el juego es true dibuja el hanoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void juego_Paint(object sender, PaintEventArgs e)
        {
            if (jugar)// if para dibujar la torre
                dibuja();
        }

        /// <summary>
        /// Evento cierra el formulario y muestra el formulario de niveles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
            frm_nivel nivel = new frm_nivel(1);
            nivel.Show();
        }

        /// <summary>
        /// Evento muestra las reglas del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rules_Click(object sender, EventArgs e)
        {
            frm_rules rules = new frm_rules();
            rules.Show();
        }

        /// <summary>
        /// Metodo dibuja el hanoi
        /// </summary>
        public void dibuja()
        { //se encarga de dibujar las torres y los anillos
            crear.FillRectangle(new SolidBrush(Color.White), 0, 0, 500, 250);
            //Piso
            crear.FillRectangle(new SolidBrush(Color.Gray), 20, 230, 460, 20);
            //Torre A
            crear.FillRectangle(new SolidBrush(Color.SaddleBrown), 85, 20, 10, 210);
            //Torre B
            crear.FillRectangle(new SolidBrush(Color.SaddleBrown), 245, 20, 10, 210);
            //TorreC
            crear.FillRectangle(new SolidBrush(Color.SaddleBrown), 405, 20, 10, 210);
            //Anillos
            for (int a = 0; a < numAnillos; a++)
            {//borde
                crear.FillRectangle(new SolidBrush(Color.Black), 90 - (torreA[a] * 10), 210 - (a * 20), 20 * torreA[a], 20);
                crear.FillRectangle(new SolidBrush(Color.Black), 250 - (torreB[a] * 10), 210 - (a * 20), 20 * torreB[a], 20);
                crear.FillRectangle(new SolidBrush(Color.Black), 410 - (torreC[a] * 10), 210 - (a * 20), 20 * torreC[a], 20);
                //Anillo 1
                if (torreA[a] == 1 | torreB[a] == 1 | torreC[a] == 1)
                {
                    if (torreA[a] == 1) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 1) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 1) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 16, 16);
                }
                //Anillo 2
                if (torreA[a] == 2 | torreB[a] == 2 | torreC[a] == 2)
                {
                    if (torreA[a] == 2) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 2) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 2) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 36, 16);
                }
                //Anillo 3
                if (torreA[a] == 3 | torreB[a] == 3 | torreC[a] == 3)
                {
                    if (torreA[a] == 3) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 3) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 3) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 56, 16);
                }
                //Anillo 4
                if (torreA[a] == 4 | torreB[a] == 4 | torreC[a] == 4)
                {
                    if (torreA[a] == 4) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 4) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 4) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 76, 16);
                }
                //Anillo 5
                if (torreA[a] == 5 | torreB[a] == 5 | torreC[a] == 5)
                {
                    if (torreA[a] == 5) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 5) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 5) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 96, 16);
                }
                //Anillo 6
                if (torreA[a] == 6 | torreB[a] == 6 | torreC[a] == 6)
                {
                    if (torreA[a] == 6) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 6) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 6) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 116, 16);
                }
                //Anillo 7
                if (torreA[a] == 7 | torreB[a] == 7 | torreC[a] == 7)
                {
                    if (torreA[a] == 7) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 7) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 7) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 136, 16);
                }
                //Anillo 8
                if (torreA[a] == 8 | torreB[a] == 8 | torreC[a] == 8)
                {
                    if (torreA[a] == 8) { posx = 92 - (torreA[a] * 10); }
                    if (torreB[a] == 8) { posx = 252 - (torreB[a] * 10); }
                    if (torreC[a] == 8) { posx = 412 - (torreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 156, 16);
                }
            }
        }

        /// <summary>
        /// Evento de pausar el juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (comp2 == 0)//Si comp2 es 0 pausa
            {
                //detiene el tiempo
                cronos.Stop();
                timer1.Stop();
                juego.Enabled = (false);//no puede mover los discos
                this.btn_pause.Text = "Continuar";//cambia el texto del boton
                comp2++;
            }
            else if (comp2 == 1)//si camp2 es un 1 quita pausa
            {
                juego.Enabled = (true);//puede mover los discos
                //continua el tiempo
                cronos.Start();
                timer1.Start();
                this.btn_pause.Text = "Pausa";//cambia el texto del boton
                comp2--;
            }
        }
    }
}
