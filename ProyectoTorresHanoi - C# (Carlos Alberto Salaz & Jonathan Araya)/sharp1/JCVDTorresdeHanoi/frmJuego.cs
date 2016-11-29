//uso de las bibliotecas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//biblioteca usada para dibujar los form
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

//Carlos Salas G.
//Jhonatan Araya Valverde

namespace TorresdeHanoi
{
    public partial class torresHanoi : Form
    {
        private bool Jugar = false;// se crea uan variable que se rellena con el valor si se esta jugando
        private int finalA, finalB, finalC; //se declaran las variables que "sellan" la torre
        public int Intentos, NumAnillos, intentosMin; //se crean las variables que cuentan los intentos, los anillos que deben usarse y el numero minimo de intentos que debe realizar
        private int[] TorreA, TorreB, TorreC; // se utilizan vectores para las torres que estas cargan los anillos
        private int AnillosA, AnillosB, AnillosC;//de crean las variables anillos para validar si se cumplen las reglas del juego
        private bool intA, intB, intC;
        private int posx;
        int comp = 0;
        int comp2 = 0;
        public int demo = 0;
        
        Color color;
        Graphics crear;
        Stopwatch cronos = new Stopwatch();

        

        public torresHanoi()
        {
            InitializeComponent();
            crear = juego.CreateGraphics();
            
        }

        //Salir
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        
        //Al presionar click que valide el anillo y el movimiento que se ejecuta
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if ((e.X >= 0 & e.X <= 170) & (finalA != 0)) { intA = true; intB = false; intC = false; }
            if ((e.X > 170 & e.X <= 330) & (finalB != 0)) { intB = true; intA = false; intC = false; }
            if ((e.X > 330 & e.X <= 500) & (finalC != 0)) { intC = true; intA = false; intB = false; }
        }

        //Al mover el mouse hacia las torres, que utilice la funcion del sistema "Refresh" para que dibuje el anillo que se mueve
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (intA|intB|intC){this.Refresh();}

            if (intA)
            {
                crear.FillRectangle(new SolidBrush(Color.LightCoral), 90 - (TorreA[AnillosA -1] * 10), 210 - ((AnillosA - 1) * 20), 20 * TorreA[AnillosA - 1], 20);
                crear.FillRectangle(new SolidBrush(Color.Azure), 85, 210 - ((AnillosA - 1) * 20), 10, 20);// se dibuja el anillo en movimiento y se cambia el color
                int x = e.X - (10 * TorreA[AnillosA-1]);
                int y = e.Y - 10;
                crear.FillRectangle(new SolidBrush(Color.Black), x, y, 20 * TorreA[AnillosA - 1], 20);

                if (TorreA[AnillosA - 1] == 1) { color = Color.Black; }
                if (TorreA[AnillosA - 1] == 2) { color = Color.Brown; }
                if (TorreA[AnillosA - 1] == 3) { color = Color.BlueViolet; }
                if (TorreA[AnillosA - 1] == 4) { color = Color.DarkBlue; }
                if (TorreA[AnillosA - 1] == 5) { color = Color.DarkRed; }
                if (TorreA[AnillosA - 1] == 6) { color = Color.Yellow; }
                if (TorreA[AnillosA - 1] == 7) { color = Color.White; }
                crear.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * TorreA[AnillosA - 1]) - 4, 16);
            }
            if (intB)
            {
                crear.FillRectangle(new SolidBrush(Color.LightCoral), 250 - (TorreB[AnillosB - 1] * 10), 210 - ((AnillosB - 1) * 20), 20 * TorreB[AnillosB - 1], 20);
                crear.FillRectangle(new SolidBrush(Color.Brown), 245, 210 - ((AnillosB - 1) * 20), 10, 20);
                int x = e.X - (10 * TorreB[AnillosB - 1]);
                int y = e.Y - 10;
                crear.FillRectangle(new SolidBrush(Color.Black), x, y, 20 * TorreB[AnillosB - 1], 20);

                if (TorreB[AnillosB - 1] == 1) { color = Color.Black; }
                if (TorreB[AnillosB - 1] == 2) { color = Color.Brown; }
                if (TorreB[AnillosB - 1] == 3) { color = Color.BlueViolet; }
                if (TorreB[AnillosB - 1] == 4) { color = Color.DarkBlue; }
                if (TorreB[AnillosB - 1] == 5) { color = Color.DarkRed; }
                if (TorreB[AnillosB - 1] == 6) { color = Color.Yellow; }
                if (TorreB[AnillosB - 1] == 7) { color = Color.White; }
                crear.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * TorreB[AnillosB - 1]) - 4, 16);
            }
            if (intC)
            {
                crear.FillRectangle(new SolidBrush(Color.LightCoral), 410 - (TorreC[AnillosC - 1] * 10), 210 - ((AnillosC - 1) * 20), 20 * TorreC[AnillosC - 1], 20);
                crear.FillRectangle(new SolidBrush(Color.Brown), 405, 210 - ((AnillosC - 1) * 20), 10, 20);
                int x = e.X - (10 * TorreC[AnillosC - 1]);
                int y = e.Y - 10;
                crear.FillRectangle(new SolidBrush(Color.Black), x, y, 20 * TorreC[AnillosC - 1], 20);

                if (TorreC[AnillosC - 1] == 1) { color = Color.Black; }
                if (TorreC[AnillosC - 1] == 2) { color = Color.Brown; }
                if (TorreC[AnillosC - 1] == 3) { color = Color.BlueViolet; }
                if (TorreC[AnillosC - 1] == 4) { color = Color.DarkBlue; }
                if (TorreC[AnillosC - 1] == 5) { color = Color.DarkRed; }
                if (TorreC[AnillosC - 1] == 6) { color = Color.Yellow; }
                if (TorreC[AnillosC - 1] == 7) { color = Color.White; }
                crear.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * TorreC[AnillosC - 1]) - 4, 16);
            }
            
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDificultad dificultad = new frmDificultad();
            dificultad.Show();
        }

        private void mstVolverMenu_Click(object sender, EventArgs e)
        {
            VolverMenu();
        }

        public void VolverMenu()
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void mstSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void torresHanoi_Load(object sender, EventArgs e)
        {
            Play();

            
        }

        //Al soltar click que valide si el anillo se coloca donde corresponde
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.X >= 0 & e.X <= 170) & intB & ((finalB < finalA) | finalA == 0))
            {
                finalA = finalB;
                TorreA[AnillosA] = finalB;
                if (AnillosB > 1)
                { finalB = TorreB[AnillosB - 2]; }
                else
                { finalB = TorreB[AnillosB]; }
                TorreB[AnillosB - 1] = 0;
                AnillosA++;
                AnillosB--;
                Intentos++;
            }
            if ((e.X >= 0 & e.X <= 170) & intC & ((finalC < finalA) | finalA == 0))
            {
                finalA = finalC;
                TorreA[AnillosA] = finalC;
                if (AnillosC > 1)
                { finalC = TorreC[AnillosC - 2]; }
                else
                { finalC = TorreC[AnillosC]; }
                TorreC[AnillosC - 1] = 0;
                AnillosA++;
                AnillosC--;
                Intentos++;
            }
            if ((e.X > 170 & e.X <= 330) & intA & ((finalA < finalB) | finalB == 0))
            {
                finalB = finalA;
                TorreB[AnillosB] = finalA;
                if (AnillosA > 1)
                { finalA = TorreA[AnillosA - 2]; }
                else
                { finalA = TorreA[AnillosA]; }
                TorreA[AnillosA - 1] = 0;
                AnillosB++;
                AnillosA--;
                Intentos++;
            }
            if ((e.X > 170 & e.X <= 330) & intC & ((finalC < finalB) | finalB == 0))
            {
                finalB = finalC;
                TorreB[AnillosB] = finalC;
                if (AnillosC > 1)
                { finalC = TorreC[AnillosC - 2]; }
                else
                { finalC = TorreC[AnillosC]; }
                TorreC[AnillosC - 1] = 0;
                AnillosB++;
                AnillosC--;
                Intentos++;
            }
            if ((e.X > 330 & e.X <= 500) & intA & ((finalA < finalC) | finalC == 0))
            {
                finalC = finalA;
                TorreC[AnillosC] = finalA;
                if (AnillosA > 1)
                { finalA = TorreA[AnillosA - 2]; }
                else
                { finalA = TorreA[AnillosA]; }
                TorreA[AnillosA - 1] = 0;
                AnillosC++;
                AnillosA--;
                Intentos++;
            }
            if ((e.X > 330 & e.X <= 5000) & intB & ((finalB < finalC) | finalC == 0))
            {
                finalC = finalB;
                TorreC[AnillosC] = finalB;
                if (AnillosB > 1)
                { finalB = TorreB[AnillosB - 2]; }
                else
                { finalB = TorreB[AnillosB]; }
                TorreB[AnillosB - 1] = 0;
                AnillosC++;
                AnillosB--;
                Intentos++;
            }
            intA = false; intB = false; intC = false;
            this.Refresh();
            lblIntentos2.Text = Intentos.ToString();
            if ((TorreC[NumAnillos - 1] == 1) & Jugar)
            {
                timer1.Stop();
                intentosMin = 0;
                for (int n = 1; n <= NumAnillos; n++)
                { intentosMin = (intentosMin*2) + 1; }
                if (Intentos > intentosMin)
                {//muestra un mensaje diciendo que ha ganado
                    
                    this.Hide();
                    frmMsg box = new frmMsg();
                    box.Msg = "Ganaste" + "\n" + "Movimientos Minimos: " + intentosMin + "\n" + "Su tiempo: " + this.lblIntentos3.Text + "\n" + "Sus Movimientos: " + this.lblIntentos2.Text;
                    
                    box.Show();
                }
                else
                {
                    this.Hide();
                    frmMsg box = new frmMsg();
                    box.Msg = "Ganaste con la cantidad minima de movimientos: " + this.lblIntentos2.Text + "\n" + "Su Tiempo: " + this.lblIntentos3.Text + "\n" + "Sus Movimientos: " + this.lblIntentos2.Text;

                    box.Show();
                    
                }
                this.Refresh();
                Jugar = false;
            }
        }
        public void dibuja(){ //se encarga de dibujar las torres y los anillos
            crear.FillRectangle(new SolidBrush(Color.LightGray), 0, 0, 500, 250);
            //Torre A
            crear.FillRectangle(new SolidBrush(Color.Brown), 20, 230, 140, 20);
            crear.FillRectangle(new SolidBrush(Color.DarkGray), 85, 30, 10, 210);
            //Torre B
            crear.FillRectangle(new SolidBrush(Color.Brown), 180, 230, 140, 20);
            crear.FillRectangle(new SolidBrush(Color.Gray), 245, 30, 10, 210);
            //TorreC
            crear.FillRectangle(new SolidBrush(Color.Brown), 340, 230, 140, 20);
            crear.FillRectangle(new SolidBrush(Color.DimGray), 405, 30, 10, 210);
            

            for (int a = 0; a < NumAnillos; a++)
            {
                crear.FillRectangle(new SolidBrush(Color.Black), 90 - (TorreA[a] * 10), 210 - (a * 20), 20 * TorreA[a], 20);
                crear.FillRectangle(new SolidBrush(Color.Black), 250 - (TorreB[a] * 10), 210 - (a * 20), 20 * TorreB[a], 20);
                crear.FillRectangle(new SolidBrush(Color.Black), 410 - (TorreC[a] * 10), 210 - (a * 20), 20 * TorreC[a], 20);

                if (TorreA[a] == 1 | TorreB[a] == 1 | TorreC[a] == 1)
                {
                    if (TorreA[a] == 1) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 1) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 1) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.Fuchsia), posx, 212 - (a * 20), 16, 16);
                }
                if (TorreA[a] == 2 | TorreB[a] == 2 | TorreC[a] == 2)
                {
                    if (TorreA[a] == 2) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 2) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 2) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.ForestGreen), posx, 212 - (a * 20), 36, 16);
                }
                if (TorreA[a] == 3 | TorreB[a] == 3 | TorreC[a] == 3)
                {
                    if (TorreA[a] == 3) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 3) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 3) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.White), posx, 212 - (a * 20), 56, 16);
                }
                if (TorreA[a] == 4 | TorreB[a] == 4 | TorreC[a] == 4)
                {
                    if (TorreA[a] == 4) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 4) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 4) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.Yellow), posx, 212 - (a * 20), 76, 16);
                }
                if (TorreA[a] == 5 | TorreB[a] == 5 | TorreC[a] == 5)
                {
                    if (TorreA[a] == 5) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 5) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 5) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.Aquamarine), posx, 212 - (a * 20), 96, 16);
                }
                if (TorreA[a] == 6 | TorreB[a] == 6 | TorreC[a] == 6)
                {
                    if (TorreA[a] == 6) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 6) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 6) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.RoyalBlue), posx, 212 - (a * 20), 116, 16);
                }
                if (TorreA[a] == 7 | TorreB[a] == 7 | TorreC[a] == 7)
                {
                    if (TorreA[a] == 7) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 7) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 7) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.Black), posx, 212 - (a * 20), 136, 16);
                }
                if (TorreA[a] == 8 | TorreB[a] == 8 | TorreC[a] == 8)
                {
                    if (TorreA[a] == 8) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 8) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 8) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.Red), posx, 212 - (a * 20), 156, 16);
                }
                
            }
            

        }
        //Dibuja juego
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Jugar)
                dibuja();
            
        }

        //Jugar, se validan las reglas para obtener el ganador del juego
        private void button1_Click(object sender, EventArgs e)
        {
            Play();
        }

        public void Play()
        {
            
                this.btnPausa.Text = "Pausa";
                label2.Visible = (true);
                label3.Visible = (true);
                label4.Visible = (true);
                juego.Enabled = (true);
                btnPausa.Visible = (true);
                comp++;
                this.lblIntentos3.Text = "0";
                timer1.Start();
            
                TorreA = new int[NumAnillos];
                TorreB = new int[NumAnillos];
                TorreC = new int[NumAnillos];
                AnillosA = NumAnillos;
                AnillosB = 0;
                AnillosC = 0;
                finalA = 1;
                finalB = 0;
                finalC = 0;
                for (int a = NumAnillos, b = 0; a > 0; a--, b++)
                { TorreA[b] = a; }
                Intentos = 0;
                
                if (comp != 0)
                {
                    cronos.Reset();
                }
                lblIntentos2.Text = Intentos.ToString();
                Jugar = true;
                this.Refresh();
            
        }

        public void Empdemo()
        {
            
            btnPausa.Visible = (false);
            this.lblIntentos3.Text = "0";
            Jugar = true;
            NumAnillos = 3;
            TorreA = new int[3];
            TorreB = new int[3];
            TorreC = new int[3];
            for (int a = NumAnillos, b = 0; a > 0; a--, b++)
            { TorreA[b] = a; }
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 2; TorreB[1] = 0; TorreC[1] = 0;
            TorreA[0] = 3; TorreB[0] = 0; TorreC[0] = 1;
            lblIntentos2.Text = "1";
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 0;
            TorreA[0] = 3; TorreB[0] = 2; TorreC[0] = 1;
            lblIntentos2.Text = "2";
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 1; TorreC[1] = 0;
            TorreA[0] = 3; TorreB[0] = 2; TorreC[0] = 0;
            lblIntentos2.Text = "3";
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 1; TorreC[1] = 0;
            TorreA[0] = 0; TorreB[0] = 2; TorreC[0] = 3;
            lblIntentos2.Text = "4";
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 0;
            TorreA[0] = 1; TorreB[0] = 2; TorreC[0] = 3;
            lblIntentos2.Text = "5";
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 2;
            TorreA[0] = 1; TorreB[0] = 0; TorreC[0] = 3;
            lblIntentos2.Text = "6";
            this.Refresh();
            Thread.Sleep(1000);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 1;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 2;
            TorreA[0] = 0; TorreB[0] = 0; TorreC[0] = 3;
            lblIntentos2.Text = "7";
            this.Refresh();

            cronos.Stop();
            timer1.Stop();
            juego.Enabled = (false);
            cronos.Stop();
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)//declara el contador que lleva la cuenta del tiempo
        {
            cronos.Start();//inicia el contador

            if (cronos.IsRunning)
            {
                TimeSpan ts = cronos.Elapsed;
                this.lblIntentos3.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            }

            if (demo == 1)
            {
                Empdemo();
            }
        }
        
        private void button5_Click_1(object sender, EventArgs e)
        {
            // se utiliza este boton para pausar el juego, pausando el tiempo y bloqueando los controles
            //bonton para pausar el juego bloquea el tiempo y los controles
            if (comp2 == 0)
            {
                cronos.Stop();
                timer1.Stop();
                juego.Enabled = (false);
                cronos.Stop();
                timer1.Stop();
               this.btnPausa.Text = "Continuar";//cambia el texto del boton
               comp2++;

            }
            else if (comp2 ==1)
            {
                juego.Enabled = (true);
                cronos.Start();
                timer1.Start();
                this.btnPausa.Text = "Pausa";//cambia el texto del boton
                comp2--;
            }
        }
    }

}