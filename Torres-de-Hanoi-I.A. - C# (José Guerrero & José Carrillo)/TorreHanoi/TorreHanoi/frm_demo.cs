using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace TorreHanoi
{
    public partial class frm_demo : Form
    {
        //Variables
        private int NumAnillos; 
        private int[] TorreA, TorreB, TorreC; 
        int temp; 
        int move;
        Boolean num;
        private int posx;
        Graphics crear;
        Stopwatch cronos = new Stopwatch();
        int n;

        /// <summary>
        /// Contructor del formulario
        /// </summary>
        /// <param name="n"></param>
        public frm_demo(int n)
        {
            InitializeComponent();
            crear = juego.CreateGraphics();
            this.n = n;
        }

        /// <summary>
        /// Metodo que dibuja la torre de hanoi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void juego_Paint(object sender, PaintEventArgs e)
        {
            dibuja();
        }

        /// <summary>
        /// Metodo para dibujar el hanoi
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
            for (int a = 0; a < NumAnillos; a++)
            {//borde
                crear.FillRectangle(new SolidBrush(Color.Black), 90 - (TorreA[a] * 10), 210 - (a * 20), 20 * TorreA[a], 20);
                crear.FillRectangle(new SolidBrush(Color.Black), 250 - (TorreB[a] * 10), 210 - (a * 20), 20 * TorreB[a], 20);
                crear.FillRectangle(new SolidBrush(Color.Black), 410 - (TorreC[a] * 10), 210 - (a * 20), 20 * TorreC[a], 20);
                //Anillo 1
                if (TorreA[a] == 1 | TorreB[a] == 1 | TorreC[a] == 1)
                {
                    if (TorreA[a] == 1) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 1) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 1) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 16, 16);
                }
                //Anillo 2
                if (TorreA[a] == 2 | TorreB[a] == 2 | TorreC[a] == 2)
                {
                    if (TorreA[a] == 2) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 2) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 2) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 36, 16);
                }
                //Anillo 3
                if (TorreA[a] == 3 | TorreB[a] == 3 | TorreC[a] == 3)
                {
                    if (TorreA[a] == 3) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 3) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 3) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 56, 16);
                }
                //Anillo 4
                if (TorreA[a] == 4 | TorreB[a] == 4 | TorreC[a] == 4)
                {
                    if (TorreA[a] == 4) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 4) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 4) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 76, 16);
                }
                //Anillo 5
                if (TorreA[a] == 5 | TorreB[a] == 5 | TorreC[a] == 5)
                {
                    if (TorreA[a] == 5) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 5) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 5) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 96, 16);
                }
                //Anillo 6
                if (TorreA[a] == 6 | TorreB[a] == 6 | TorreC[a] == 6)
                {
                    if (TorreA[a] == 6) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 6) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 6) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 116, 16);
                }
                //Anillo 7
                if (TorreA[a] == 7 | TorreB[a] == 7 | TorreC[a] == 7)
                {
                    if (TorreA[a] == 7) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 7) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 7) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 136, 16);
                }
                //Anillo 8
                if (TorreA[a] == 8 | TorreB[a] == 8 | TorreC[a] == 8)
                {
                    if (TorreA[a] == 8) { posx = 92 - (TorreA[a] * 10); }
                    if (TorreB[a] == 8) { posx = 252 - (TorreB[a] * 10); }
                    if (TorreC[a] == 8) { posx = 412 - (TorreC[a] * 10); }
                    crear.FillRectangle(new SolidBrush(Color.DarkRed), posx, 212 - (a * 20), 156, 16);
                }
            }
        }

        /// <summary>
        /// Metodo recurcivo para los movimientos de la torre de hanoi
        /// </summary>
        /// <param name="n"></param>
        /// <param name="A"></param>
        /// <param name="C"></param>
        /// <param name="B"></param>
        /// <param name="active"></param>
        public void doHanoi(int n, string A, string C, string B, Boolean active)
        {
            if (active == true)// if para la impresion de los anillos de la torre
            {
                NumAnillos = n;
                TorreA = new int[n];
                TorreB = new int[n];
                TorreC = new int[n];
                for (int a = NumAnillos, b = 0; a > 0; a--, b++)
                { TorreA[b] = a; }
                this.Refresh();
                Thread.Sleep(1000);
                active = false;
            }
            /** incio de recurcividad **/
            if (n <= 1)// if para hacer el primer movimiento de los anillos
            {
                num = false;
                move = move + 1;
                lbl_move.Text = Convert.ToString(move);
                // if que toma el anillo que va a mover
                if (A.Equals("A"))
                {
                    for (int x = TorreA.Length - 1; x >= 0; x--)
                    {
                        if (num == false & TorreA[x] > 0)
                        {
                            temp = TorreA[x];
                            TorreA[x] = 0;
                            num = true;
                        }
                    }
                }
                else if (A.Equals("B"))
                {
                    for (int x = TorreB.Length - 1; x >= 0; x--)
                    {
                        if (num == false & TorreB[x] > 0)
                        {
                            temp = TorreB[x];
                            TorreB[x] = 0;
                            num = true;
                        }
                    }
                }
                else if (A.Equals("C"))
                {
                    for (int x = TorreC.Length - 1; x >= 0; x--)
                    {
                        if (num == false & TorreC[x] > 0)
                        {
                            temp = TorreC[x];
                            TorreC[x] = 0;
                            num = true;
                        }
                    }
                }
                // if para insertar el anillo en la columna siguiente
                num = false;
                if (C.Equals("A"))
                {
                    for (int y = 0; y < TorreA.Length; y++)
                    {
                        if (num == false & TorreA[y] == 0)
                        {
                            TorreA[y] = temp;
                            num = true;
                        }
                    }
                }
                else if (C.Equals("B"))
                {
                    for (int y = 0; y < TorreB.Length; y++)
                    {
                        if (num == false & TorreB[y] == 0)
                        {
                            TorreB[y] = temp;
                            num = true;
                        }
                    }
                }
                else if (C.Equals("C"))
                {
                    for (int y = 0; y < TorreC.Length; y++)
                    {
                        if (num == false & TorreC[y] == 0)
                        {
                            TorreC[y] = temp;
                            num = true;
                        }
                    }
                }
                this.Refresh();
                Thread.Sleep(1000);
            }
            // else si no es el primer movimiento
            else
            {
                // llama de recurcividad
                doHanoi(n - 1, A, B, C, false);
                num = false;
                move = move + 1;
                lbl_move.Text = Convert.ToString(move);
                // if que toma el anillo que va a mover
                if (A.Equals("A"))
                {
                    for (int x = TorreA.Length - 1; x >= 0; x--)
                    {
                        if (num == false & TorreA[x] > 0)
                        {
                            temp = TorreA[x];
                            TorreA[x] = 0;
                            num = true;
                        }
                    }
                }
                else if (A.Equals("B"))
                {
                    for (int x = TorreB.Length - 1; x >= 0; x--)
                    {
                        if (num == false & TorreB[x] > 0)
                        {
                            temp = TorreB[x];
                            TorreB[x] = 0;
                            num = true;
                        }
                    }
                }
                else if (A.Equals("C"))
                {
                    for (int x = TorreC.Length - 1; x >= 0; x--)
                    {
                        if (num == false & TorreC[x] > 0)
                        {
                            temp = TorreC[x];
                            TorreC[x] = 0;
                            num = true;
                        }
                    }
                }
                // if para insertar el anillo en la columna siguiente
                num = false;
                if (C.Equals("A"))
                {
                    for (int y = 0; y < TorreA.Length; y++)
                    {
                        if (num == false & TorreA[y] == 0)
                        {
                            TorreA[y] = temp;
                            num = true;
                        }
                    }
                }
                else if (C.Equals("B"))
                {
                    for (int y = 0; y < TorreB.Length; y++)
                    {
                        if (num == false & TorreB[y] == 0)
                        {
                            TorreB[y] = temp;
                            num = true;
                        }
                    }
                }
                else if (C.Equals("C"))
                {
                    for (int y = 0; y < TorreC.Length; y++)
                    {
                        if (num == false & TorreC[y] == 0)
                        {
                            TorreC[y] = temp;
                            num = true;
                        }
                    }
                }
                this.Refresh();
                Thread.Sleep(1000);
                // llama de recurcividad
                doHanoi(n - 1, B, C, A, false);
            }
        }

        /// <summary>
        /// Evento para detener el demo con enter o esc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_demo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Escape) || (e.KeyChar != (char)Keys.Enter))
            {
                frm_Menu menu = new frm_Menu();
                menu.Show();
                this.Close();
            }
        }
    }
}
