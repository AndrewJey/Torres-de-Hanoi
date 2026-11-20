using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace TorresdeHanoi
{
    public struct HanoiMove
    {
        public int From { get; }
        public int To { get; }

        public HanoiMove(int from, int to)
        {
            From = from;
            To = to;
        }
    }

    public class HanoiEngine
    {
        private readonly Stack<int>[] _pegs = { new Stack<int>(), new Stack<int>(), new Stack<int>() };

        public int DiskCount { get; private set; }
        public int Moves { get; private set; }
        public int MinimumMoves => (1 << DiskCount) - 1;
        public bool IsSolved => _pegs[2].Count == DiskCount && DiskCount > 0;

        public HanoiEngine(int diskCount = 3)
        {
            Reset(diskCount);
        }

        public void Reset(int diskCount)
        {
            if (diskCount < 1 || diskCount > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(diskCount), "El número de discos debe estar entre 1 y 10.");
            }

            DiskCount = diskCount;
            Moves = 0;
            for (int i = 0; i < 3; i++)
            {
                _pegs[i].Clear();
            }

            for (int d = diskCount; d >= 1; d--)
            {
                _pegs[0].Push(d);
            }
        }

        public int[] GetPegDisksBottomToTop(int pegIndex)
        {
            if (pegIndex < 0 || pegIndex > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(pegIndex));
            }

            int[] arr = _pegs[pegIndex].ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public int PeekTop(int pegIndex)
        {
            if (pegIndex < 0 || pegIndex > 2 || _pegs[pegIndex].Count == 0)
            {
                return 0;
            }
            return _pegs[pegIndex].Peek();
        }

        public bool CanMove(int fromPeg, int toPeg)
        {
            if (fromPeg < 0 || fromPeg > 2 || toPeg < 0 || toPeg > 2 || fromPeg == toPeg)
            {
                return false;
            }
            if (_pegs[fromPeg].Count == 0)
            {
                return false;
            }
            if (_pegs[toPeg].Count == 0)
            {
                return true;
            }
            return _pegs[fromPeg].Peek() < _pegs[toPeg].Peek();
        }

        public bool TryMove(int fromPeg, int toPeg)
        {
            if (!CanMove(fromPeg, toPeg))
            {
                return false;
            }

            int disk = _pegs[fromPeg].Pop();
            _pegs[toPeg].Push(disk);
            Moves++;
            return true;
        }

        public static List<HanoiMove> ComputeOptimalMoves(int diskCount, int from = 0, int aux = 1, int to = 2)
        {
            var moves = new List<HanoiMove>();
            BuildMoves(diskCount, from, aux, to, moves);
            return moves;
        }

        private static void BuildMoves(int n, int from, int aux, int to, List<HanoiMove> moves)
        {
            if (n <= 0) return;
            BuildMoves(n - 1, from, to, aux, moves);
            moves.Add(new HanoiMove(from, to));
            BuildMoves(n - 1, aux, from, to, moves);
        }
    }

    public partial class torresHanoi : Form
    {
        private static readonly Color[] DiskPalette =
        {
            Color.Coral,
            Color.SaddleBrown,
            Color.BlueViolet,
            Color.DarkBlue,
            Color.DarkRed,
            Color.Gold,
            Color.WhiteSmoke,
            Color.CadetBlue,
            Color.MediumSeaGreen,
            Color.SlateBlue
        };

        private static readonly int[] PegCentersX = { 90, 250, 410 };

        private readonly HanoiEngine _engine = new HanoiEngine(3);
        private readonly Stopwatch _cronos = new Stopwatch();
        private readonly System.Windows.Forms.Timer _demoTimer = new System.Windows.Forms.Timer();
        private Queue<HanoiMove> _demoQueue = new Queue<HanoiMove>();

        private bool _jugar;
        private bool _pausado;
        private int _draggingPeg = -1;
        private Point _dragPoint;

        public int Intentos => _engine.Moves;
        public int NumAnillos => _engine.DiskCount;
        public int intentosMin => _engine.MinimumMoves;

        public torresHanoi()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            EnableDoubleBuffering(juego);

            _demoTimer.Interval = 320;
            _demoTimer.Tick += DemoTimer_Tick;

            if (cbx_nivel.Items.Count > 0 && cbx_nivel.SelectedIndex < 0)
            {
                cbx_nivel.SelectedIndex = 0;
            }

            panel_menu.Visible = true;
            panel_juego.Visible = false;
        }

        private static void EnableDoubleBuffering(Control control)
        {
            PropertyInfo prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (prop != null)
            {
                prop.SetValue(control, true, null);
            }
        }

        private int ResolveSelectedDisks()
        {
            int parsed;
            if (int.TryParse((cbx_nivel.Text ?? string.Empty).Trim(), out parsed) && parsed >= 3 && parsed <= 8)
            {
                return parsed;
            }

            if (cbx_nivel.SelectedIndex >= 0)
            {
                return Math.Max(3, Math.Min(8, cbx_nivel.SelectedIndex + 3));
            }

            return 3;
        }

        private static int HitTestPeg(int x)
        {
            if (x < 170) return 0;
            if (x < 330) return 1;
            return 2;
        }

        private void StartSession(bool demoMode)
        {
            _demoTimer.Stop();
            _demoQueue.Clear();
            _draggingPeg = -1;
            _pausado = false;
            btnPausa.Text = "Pausa";

            int disks = ResolveSelectedDisks();
            _engine.Reset(disks);
            lb_nivel.Text = disks.ToString();
            lblIntentos2.Text = "0";
            lblIntentos3.Text = "00:00";

            panel_menu.Visible = false;
            panel_juego.Visible = true;

            _cronos.Reset();
            _cronos.Start();
            timer1.Start();

            if (demoMode)
            {
                _jugar = false;
                _demoQueue = new Queue<HanoiMove>(HanoiEngine.ComputeOptimalMoves(disks));
                _demoTimer.Start();
            }
            else
            {
                _jugar = true;
            }

            juego.Invalidate();
        }

        private void DemoTimer_Tick(object sender, EventArgs e)
        {
            if (_demoQueue.Count == 0)
            {
                _demoTimer.Stop();
                timer1.Stop();
                _cronos.Stop();
                juego.Invalidate();
                MessageBox.Show(
                    this,
                    string.Format("Demostración completada en {0} movimientos óptimos.", _engine.Moves),
                    "Torres de Hanoi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            HanoiMove step = _demoQueue.Dequeue();
            _engine.TryMove(step.From, step.To);
            lblIntentos2.Text = _engine.Moves.ToString();
            juego.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_jugar || _pausado)
            {
                return;
            }

            int peg = HitTestPeg(e.X);
            if (_engine.PeekTop(peg) != 0)
            {
                _draggingPeg = peg;
                _dragPoint = e.Location;
                juego.Invalidate();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggingPeg < 0)
            {
                return;
            }

            _dragPoint = e.Location;
            juego.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_draggingPeg < 0)
            {
                return;
            }

            int sourcePeg = _draggingPeg;
            _draggingPeg = -1;

            int targetPeg = HitTestPeg(e.X);
            if (_engine.TryMove(sourcePeg, targetPeg))
            {
                lblIntentos2.Text = _engine.Moves.ToString();
                juego.Invalidate();

                if (_jugar && _engine.IsSolved)
                {
                    _jugar = false;
                    timer1.Stop();
                    _cronos.Stop();

                    string msg = _engine.Moves == _engine.MinimumMoves
                        ? string.Format("¡Perfecto! Lo lograste en {0} con el mínimo de {1} intentos.", lblIntentos3.Text, _engine.Moves)
                        : string.Format("¡Felicidades! Lo lograste en {0} con {1} intentos (mínimo óptimo: {2}).", lblIntentos3.Text, _engine.Moves, _engine.MinimumMoves);
                    MessageBox.Show(this, msg, "¡Ganaste!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                juego.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush baseBrush = new SolidBrush(Color.SaddleBrown))
            using (SolidBrush pegBrush = new SolidBrush(Color.Peru))
            using (Pen borderPen = new Pen(Color.Black, 1.5f))
            {
                // Base
                g.FillRectangle(baseBrush, 10, 230, 480, 12);

                // Three pegs
                for (int p = 0; p < 3; p++)
                {
                    g.FillRectangle(pegBrush, PegCentersX[p] - 5, 50, 10, 180);

                    int[] disks = _engine.GetPegDisksBottomToTop(p);
                    int drawCount = disks.Length;
                    if (_draggingPeg == p && drawCount > 0)
                    {
                        drawCount--;
                    }

                    for (int i = 0; i < drawCount; i++)
                    {
                        int diskSize = disks[i];
                        int width = diskSize * 20;
                        int x = PegCentersX[p] - (width / 2);
                        int y = 210 - (i * 20);
                        DrawDisk(g, borderPen, diskSize, x, y, width, 18);
                    }
                }

                // Dragging disk rendered smoothly on top
                if (_draggingPeg >= 0)
                {
                    int topDisk = _engine.PeekTop(_draggingPeg);
                    if (topDisk > 0)
                    {
                        int width = topDisk * 20;
                        int x = _dragPoint.X - (width / 2);
                        int y = _dragPoint.Y - 9;
                        DrawDisk(g, borderPen, topDisk, x, y, width, 18);
                    }
                }
            }
        }

        private static void DrawDisk(Graphics g, Pen borderPen, int diskSize, int x, int y, int width, int height)
        {
            Color fill = DiskPalette[(diskSize - 1) % DiskPalette.Length];
            using (SolidBrush brush = new SolidBrush(fill))
            {
                g.FillRectangle(brush, x, y, width, height);
                g.DrawRectangle(borderPen, x, y, width, height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = _cronos.Elapsed;
            lblIntentos3.Text = string.Format("{0:00}:{1:00}", (int)elapsed.TotalMinutes, elapsed.Seconds);
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            StartSession(false);
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            StartSession(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _demoTimer.Stop();
            timer1.Stop();
            _cronos.Stop();
            _jugar = false;
            panel_juego.Visible = false;
            panel_menu.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (!_jugar && !_demoTimer.Enabled && !_pausado)
            {
                return;
            }

            _pausado = !_pausado;
            if (_pausado)
            {
                timer1.Stop();
                _cronos.Stop();
                _demoTimer.Stop();
                btnPausa.Text = "Reanudar";
            }
            else
            {
                _cronos.Start();
                timer1.Start();
                if (!_jugar && _demoQueue.Count > 0)
                {
                    _demoTimer.Start();
                }
                btnPausa.Text = "Pausa";
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void torresHanoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape && panel_juego.Visible)
            {
                button1_Click(sender, EventArgs.Empty);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _demoTimer.Stop();
            _demoTimer.Dispose();
            timer1.Stop();
            base.OnFormClosing(e);
        }
    }
}
