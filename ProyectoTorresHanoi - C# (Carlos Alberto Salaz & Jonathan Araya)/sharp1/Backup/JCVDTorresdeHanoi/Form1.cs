using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace JCVDTorresdeHanoi
{
    public partial class Form1 : Form
    {
        private bool Jugar = false;
        private int CimaA, CimaB, CimaC;
        private int Movimientos, NumAnillos, MinMovimientos;
        private int[] TorreA, TorreB, TorreC;
        private int AnillosA, AnillosB, AnillosC;
        private bool MovA, MovB, MovC;
        private int posx;
        Color color;
        Graphics dibujar;

        public Form1()
        {
            InitializeComponent();
            dibujar = panel1.CreateGraphics();
        }

        //Salir
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Reglas
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 JCVD = new Form2();
            JCVD.Show();
        }

        //Al presionar click
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X >= 0 & e.X <= 170) & (CimaA != 0)) { MovA = true; MovB = false; MovC = false; }
            if ((e.X > 170 & e.X <= 330) & (CimaB != 0)) { MovB = true; MovA = false; MovC = false; }
            if ((e.X > 330 & e.X <= 500) & (CimaC != 0)) { MovC = true; MovA = false; MovB = false; }
        }

        //Al mover el mouse
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(MovA|MovB|MovC){this.Refresh();}

            if (MovA)
            {
                dibujar.FillRectangle(new SolidBrush(Color.LimeGreen), 90 - (TorreA[AnillosA -1] * 10), 210 - ((AnillosA - 1) * 20), 20 * TorreA[AnillosA - 1], 20);
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 85, 210 - ((AnillosA - 1) * 20), 10, 20);
                int x = e.X - (10 * TorreA[AnillosA-1]);
                int y = e.Y - 10;
                dibujar.FillRectangle(new SolidBrush(Color.Black), x, y, 20 * TorreA[AnillosA - 1], 20);

                if (TorreA[AnillosA - 1] == 1) { color = Color.Red; }
                if (TorreA[AnillosA - 1] == 2) { color = Color.Pink; }
                if (TorreA[AnillosA - 1] == 3) { color = Color.Purple; }
                if (TorreA[AnillosA - 1] == 4) { color = Color.Crimson; }
                if (TorreA[AnillosA - 1] == 5) { color = Color.Aquamarine; }
                if (TorreA[AnillosA - 1] == 6) { color = Color.Yellow; }
                if (TorreA[AnillosA - 1] == 7) { color = Color.White; }
                dibujar.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * TorreA[AnillosA - 1]) - 4, 16);
            }
            if (MovB)
            {
                dibujar.FillRectangle(new SolidBrush(Color.LimeGreen), 250 - (TorreB[AnillosB - 1] * 10), 210 - ((AnillosB - 1) * 20), 20 * TorreB[AnillosB - 1], 20);
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 245, 210 - ((AnillosB - 1) * 20), 10, 20);
                int x = e.X - (10 * TorreB[AnillosB - 1]);
                int y = e.Y - 10;
                dibujar.FillRectangle(new SolidBrush(Color.Black), x, y, 20 * TorreB[AnillosB - 1], 20);

                if (TorreB[AnillosB - 1] == 1) { color = Color.Red; }
                if (TorreB[AnillosB - 1] == 2) { color = Color.Pink; }
                if (TorreB[AnillosB - 1] == 3) { color = Color.Purple; }
                if (TorreB[AnillosB - 1] == 4) { color = Color.Crimson; }
                if (TorreB[AnillosB - 1] == 5) { color = Color.Aquamarine; }
                if (TorreB[AnillosB - 1] == 6) { color = Color.Yellow; }
                if (TorreB[AnillosB - 1] == 7) { color = Color.White; }
                dibujar.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * TorreB[AnillosB - 1]) - 4, 16);
            }
            if (MovC)
            {
                dibujar.FillRectangle(new SolidBrush(Color.LimeGreen), 410 - (TorreC[AnillosC - 1] * 10), 210 - ((AnillosC - 1) * 20), 20 * TorreC[AnillosC - 1], 20);
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 405, 210 - ((AnillosC - 1) * 20), 10, 20);
                int x = e.X - (10 * TorreC[AnillosC - 1]);
                int y = e.Y - 10;
                dibujar.FillRectangle(new SolidBrush(Color.Black), x, y, 20 * TorreC[AnillosC - 1], 20);

                if (TorreC[AnillosC - 1] == 1) { color = Color.Red; }
                if (TorreC[AnillosC - 1] == 2) { color = Color.Pink; }
                if (TorreC[AnillosC - 1] == 3) { color = Color.Purple; }
                if (TorreC[AnillosC - 1] == 4) { color = Color.Crimson; }
                if (TorreC[AnillosC - 1] == 5) { color = Color.Aquamarine; }
                if (TorreC[AnillosC - 1] == 6) { color = Color.Yellow; }
                if (TorreC[AnillosC - 1] == 7) { color = Color.White; }
                dibujar.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * TorreC[AnillosC - 1]) - 4, 16);
            }
        }

        //Al soltar click
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.X >= 0 & e.X <= 170) & MovB & ((CimaB < CimaA) | CimaA == 0))
            {
                CimaA = CimaB;
                TorreA[AnillosA] = CimaB;
                if (AnillosB > 1)
                { CimaB = TorreB[AnillosB - 2]; }
                else
                { CimaB = TorreB[AnillosB]; }
                TorreB[AnillosB - 1] = 0;
                AnillosA++;
                AnillosB--;
                Movimientos++;
            }
            if ((e.X >= 0 & e.X <= 170) & MovC & ((CimaC < CimaA) | CimaA == 0))
            {
                CimaA = CimaC;
                TorreA[AnillosA] = CimaC;
                if (AnillosC > 1)
                { CimaC = TorreC[AnillosC - 2]; }
                else
                { CimaC = TorreC[AnillosC]; }
                TorreC[AnillosC - 1] = 0;
                AnillosA++;
                AnillosC--;
                Movimientos++;
            }
            if ((e.X > 170 & e.X <= 330) & MovA & ((CimaA < CimaB) | CimaB == 0))
            {
                CimaB = CimaA;
                TorreB[AnillosB] = CimaA;
                if (AnillosA > 1)
                { CimaA = TorreA[AnillosA - 2]; }
                else
                { CimaA = TorreA[AnillosA]; }
                TorreA[AnillosA - 1] = 0;
                AnillosB++;
                AnillosA--;
                Movimientos++;
            }
            if ((e.X > 170 & e.X <= 330) & MovC & ((CimaC < CimaB) | CimaB == 0))
            {
                CimaB = CimaC;
                TorreB[AnillosB] = CimaC;
                if (AnillosC > 1)
                { CimaC = TorreC[AnillosC - 2]; }
                else
                { CimaC = TorreC[AnillosC]; }
                TorreC[AnillosC - 1] = 0;
                AnillosB++;
                AnillosC--;
                Movimientos++;
            }
            if ((e.X > 330 & e.X <= 500) & MovA & ((CimaA < CimaC) | CimaC == 0))
            {
                CimaC = CimaA;
                TorreC[AnillosC] = CimaA;
                if (AnillosA > 1)
                { CimaA = TorreA[AnillosA - 2]; }
                else
                { CimaA = TorreA[AnillosA]; }
                TorreA[AnillosA - 1] = 0;
                AnillosC++;
                AnillosA--;
                Movimientos++;
            }
            if ((e.X > 330 & e.X <= 5000) & MovB & ((CimaB < CimaC) | CimaC == 0))
            {
                CimaC = CimaB;
                TorreC[AnillosC] = CimaB;
                if (AnillosB > 1)
                { CimaB = TorreB[AnillosB - 2]; }
                else
                { CimaB = TorreB[AnillosB]; }
                TorreB[AnillosB - 1] = 0;
                AnillosC++;
                AnillosB--;
                Movimientos++;
            }
            MovA = false; MovB = false; MovC = false;
            this.Refresh();
            label7.Text = Movimientos.ToString();
            if ((TorreC[NumAnillos - 1] == 1) & Jugar)
            {
                MinMovimientos = 0;
                for (int n = 1; n <= NumAnillos; n++)
                { MinMovimientos = (MinMovimientos*2) + 1; }
                if (Movimientos > MinMovimientos)
                { MessageBox.Show("¡¡¡FELICIDADES LO HAZ LO GRADO!!!, PERO INTENTA HACERLO CON MENOS MOVIMIENTOS."); }
                else
                { MessageBox.Show("¡¡¡FELICIDADES LO HAZ LO GRADO!!!"); }
                this.Refresh();
                Jugar = false;
            }
        }

        //Dibuja juego
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Jugar)
            {
                dibujar.FillRectangle(new SolidBrush(Color.LimeGreen), 0, 0, 500,250);
                //Torre A
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 20, 230, 140, 20);
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 85, 30, 10, 210);
                //Torre B
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 180, 230, 140, 20);
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 245, 30, 10, 210);
                //TorreC
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 340, 230, 140, 20);
                dibujar.FillRectangle(new SolidBrush(Color.Brown), 405, 30, 10, 210);

                for (int a = 0; a < NumAnillos; a++)
                {
                    dibujar.FillRectangle(new SolidBrush(Color.Black), 90 - (TorreA[a] * 10), 210 - (a * 20), 20 * TorreA[a], 20);
                    dibujar.FillRectangle(new SolidBrush(Color.Black), 250 - (TorreB[a] * 10), 210 - (a * 20), 20 * TorreB[a], 20);
                    dibujar.FillRectangle(new SolidBrush(Color.Black), 410 - (TorreC[a] * 10), 210 - (a * 20), 20 * TorreC[a], 20);
                    
                    if (TorreA[a] == 1 | TorreB[a] == 1 | TorreC[a] == 1)
                    {
                        if (TorreA[a] == 1) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 1) { posx = 252 - (TorreB[a] * 10); } 
                        if (TorreC[a] == 1) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.Red), posx, 212 - (a * 20), 16, 16); 
                    }
                    if (TorreA[a] == 2 | TorreB[a] == 2 | TorreC[a] == 2)
                    {
                        if (TorreA[a] == 2) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 2) { posx = 252 - (TorreB[a] * 10); }
                        if (TorreC[a] == 2) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.Pink), posx, 212 - (a * 20), 36, 16);
                    }
                    if (TorreA[a] == 3 | TorreB[a] == 3 | TorreC[a] == 3)
                    {
                        if (TorreA[a] == 3) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 3) { posx = 252 - (TorreB[a] * 10); }
                        if (TorreC[a] == 3) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.Purple), posx, 212 - (a * 20), 56, 16);
                    }
                    if (TorreA[a] == 4 | TorreB[a] == 4 | TorreC[a] == 4)
                    {
                        if (TorreA[a] == 4) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 4) { posx = 252 - (TorreB[a] * 10); }
                        if (TorreC[a] == 4) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.Crimson), posx, 212 - (a * 20), 76, 16);
                    }
                    if (TorreA[a] == 5 | TorreB[a] == 5 | TorreC[a] == 5)
                    {
                        if (TorreA[a] == 5) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 5) { posx = 252 - (TorreB[a] * 10); }
                        if (TorreC[a] == 5) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.Aquamarine), posx, 212 - (a * 20), 96, 16);
                    }
                    if (TorreA[a] == 6 | TorreB[a] == 6 | TorreC[a] == 6)
                    {
                        if (TorreA[a] == 6) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 6) { posx = 252 - (TorreB[a] * 10); }
                        if (TorreC[a] == 6) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.Yellow), posx, 212 - (a * 20), 116, 16);
                    }
                    if (TorreA[a] == 7 | TorreB[a] == 7 | TorreC[a] == 7)
                    {
                        if (TorreA[a] == 7) { posx = 92 - (TorreA[a] * 10); }
                        if (TorreB[a] == 7) { posx = 252 - (TorreB[a] * 10); }
                        if (TorreC[a] == 7) { posx = 412 - (TorreC[a] * 10); }
                        dibujar.FillRectangle(new SolidBrush(Color.White), posx, 212 - (a * 20), 136, 16);
                    }
                }
            }
        }

        //Jugar
        private void button1_Click(object sender, EventArgs e)
        {
            NumAnillos = System.Convert.ToInt32(numericUpDown1.Value);
            TorreA = new int[NumAnillos];
            TorreB = new int[NumAnillos];
            TorreC = new int[NumAnillos];
            AnillosA = NumAnillos;
            AnillosB = 0;
            AnillosC = 0;
            CimaA = 1;
            CimaB = 0;
            CimaC = 0;
            for (int a = NumAnillos, b = 0; a >0; a--, b++)
            { TorreA[b] = a; }
            Movimientos = 0;
            label7.Text = Movimientos.ToString();
            Jugar = true;
            this.Refresh();
        }

        //Ejemplo
        private void button2_Click(object sender, EventArgs e)
        {
            Jugar = true;
            NumAnillos = 3;
            TorreA = new int[3];
            TorreB = new int[3];
            TorreC = new int[3];
            for (int a = NumAnillos, b = 0; a > 0; a--, b++)
            { TorreA[b] = a; }
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 2; TorreB[1] = 0; TorreC[1] = 0;
            TorreA[0] = 3; TorreB[0] = 0; TorreC[0] = 1;
            label7.Text = "1";
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 0;
            TorreA[0] = 3; TorreB[0] = 2; TorreC[0] = 1;
            label7.Text = "2";
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 1; TorreC[1] = 0;
            TorreA[0] = 3; TorreB[0] = 2; TorreC[0] = 0;
            label7.Text = "3";
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 1; TorreC[1] = 0;
            TorreA[0] = 0; TorreB[0] = 2; TorreC[0] = 3;
            label7.Text = "4";
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 0;
            TorreA[0] = 1; TorreB[0] = 2; TorreC[0] = 3;
            label7.Text = "5";
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 0;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 2;
            TorreA[0] = 1; TorreB[0] = 0; TorreC[0] = 3;
            label7.Text = "6";
            this.Refresh();
            Thread.Sleep(1500);
            TorreA[2] = 0; TorreB[2] = 0; TorreC[2] = 1;
            TorreA[1] = 0; TorreB[1] = 0; TorreC[1] = 2;
            TorreA[0] = 0; TorreB[0] = 0; TorreC[0] = 3;
            label7.Text = "7";
            this.Refresh();
            Jugar = false;
        }
    }
}