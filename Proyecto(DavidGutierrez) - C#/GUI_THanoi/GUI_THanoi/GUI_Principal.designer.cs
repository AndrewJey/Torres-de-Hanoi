namespace GUI_THanoi
{
    partial class GUI_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Principal));
            this.lbl_Cronometro = new System.Windows.Forms.Label();
            this.timer_Partida = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_BarraTitulo = new System.Windows.Forms.MenuStrip();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelDificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelesDeJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dificlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normasDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Botones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_M = new System.Windows.Forms.Label();
            this.lbl_NumeroMovimientos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_R = new System.Windows.Forms.Label();
            this.lbl_ResultadoFinal = new System.Windows.Forms.Label();
            this.panel_Movimientos = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Torres = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Solucion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_LipiarCeldas = new System.Windows.Forms.Button();
            this.menuStrip_BarraTitulo.SuspendLayout();
            this.panel_Botones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Movimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Solucion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cronometro
            // 
            this.lbl_Cronometro.AutoSize = true;
            this.lbl_Cronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cronometro.Location = new System.Drawing.Point(17, 61);
            this.lbl_Cronometro.Name = "lbl_Cronometro";
            this.lbl_Cronometro.Size = new System.Drawing.Size(84, 16);
            this.lbl_Cronometro.TabIndex = 13;
            this.lbl_Cronometro.Text = "00:00:00:00";
            // 
            // timer_Partida
            // 
            this.timer_Partida.Tick += new System.EventHandler(this.timer_Partida_Tick);
            // 
            // menuStrip_BarraTitulo
            // 
            this.menuStrip_BarraTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip_BarraTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demoToolStripMenuItem,
            this.nivelesDeJuegoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_BarraTitulo.Name = "menuStrip_BarraTitulo";
            this.menuStrip_BarraTitulo.Size = new System.Drawing.Size(954, 24);
            this.menuStrip_BarraTitulo.TabIndex = 15;
            this.menuStrip_BarraTitulo.Text = "menuStrip1";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.nivelDificilToolStripMenuItem});
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.demoToolStripMenuItem.Text = "Demo";
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facilToolStripMenuItem.Image")));
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facilToolStripMenuItem.Text = "Nivel Facil";
            this.facilToolStripMenuItem.Click += new System.EventHandler(this.facilToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("medioToolStripMenuItem.Image")));
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.medioToolStripMenuItem.Text = "Nivel Medio";
            this.medioToolStripMenuItem.Click += new System.EventHandler(this.medioToolStripMenuItem_Click);
            // 
            // nivelDificilToolStripMenuItem
            // 
            this.nivelDificilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nivelDificilToolStripMenuItem.Image")));
            this.nivelDificilToolStripMenuItem.Name = "nivelDificilToolStripMenuItem";
            this.nivelDificilToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nivelDificilToolStripMenuItem.Text = "Nivel Dificil";
            this.nivelDificilToolStripMenuItem.Click += new System.EventHandler(this.nivelDificilToolStripMenuItem_Click);
            // 
            // nivelesDeJuegoToolStripMenuItem
            // 
            this.nivelesDeJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem1,
            this.medioToolStripMenuItem1,
            this.dificlToolStripMenuItem});
            this.nivelesDeJuegoToolStripMenuItem.Name = "nivelesDeJuegoToolStripMenuItem";
            this.nivelesDeJuegoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.nivelesDeJuegoToolStripMenuItem.Text = "Niveles de Juego";
            // 
            // facilToolStripMenuItem1
            // 
            this.facilToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("facilToolStripMenuItem1.Image")));
            this.facilToolStripMenuItem1.Name = "facilToolStripMenuItem1";
            this.facilToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.facilToolStripMenuItem1.Text = "Facil";
            this.facilToolStripMenuItem1.Click += new System.EventHandler(this.facilToolStripMenuItem1_Click);
            // 
            // medioToolStripMenuItem1
            // 
            this.medioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("medioToolStripMenuItem1.Image")));
            this.medioToolStripMenuItem1.Name = "medioToolStripMenuItem1";
            this.medioToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.medioToolStripMenuItem1.Text = "Medio";
            this.medioToolStripMenuItem1.Click += new System.EventHandler(this.medioToolStripMenuItem1_Click);
            // 
            // dificlToolStripMenuItem
            // 
            this.dificlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dificlToolStripMenuItem.Image")));
            this.dificlToolStripMenuItem.Name = "dificlToolStripMenuItem";
            this.dificlToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.dificlToolStripMenuItem.Text = "Dificl";
            this.dificlToolStripMenuItem.Click += new System.EventHandler(this.dificlToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelJuegoToolStripMenuItem,
            this.normasDelJuegoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDelJuegoToolStripMenuItem
            // 
            this.acercaDelJuegoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDelJuegoToolStripMenuItem.Image")));
            this.acercaDelJuegoToolStripMenuItem.Name = "acercaDelJuegoToolStripMenuItem";
            this.acercaDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.acercaDelJuegoToolStripMenuItem.Text = "Acerca del Juego";
            this.acercaDelJuegoToolStripMenuItem.Click += new System.EventHandler(this.acercaDelJuegoToolStripMenuItem_Click);
            // 
            // normasDelJuegoToolStripMenuItem
            // 
            this.normasDelJuegoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("normasDelJuegoToolStripMenuItem.Image")));
            this.normasDelJuegoToolStripMenuItem.Name = "normasDelJuegoToolStripMenuItem";
            this.normasDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.normasDelJuegoToolStripMenuItem.Text = "Normas del Juego";
            this.normasDelJuegoToolStripMenuItem.Click += new System.EventHandler(this.normasDelJuegoToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel_Botones
            // 
            this.panel_Botones.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_Botones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Botones.Controls.Add(this.panel1);
            this.panel_Botones.Controls.Add(this.panel2);
            this.panel_Botones.Controls.Add(this.panel_Movimientos);
            this.panel_Botones.Location = new System.Drawing.Point(810, 32);
            this.panel_Botones.Name = "panel_Botones";
            this.panel_Botones.Size = new System.Drawing.Size(132, 414);
            this.panel_Botones.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_M);
            this.panel1.Controls.Add(this.lbl_NumeroMovimientos);
            this.panel1.Location = new System.Drawing.Point(3, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 103);
            this.panel1.TabIndex = 19;
            // 
            // lbl_M
            // 
            this.lbl_M.AutoSize = true;
            this.lbl_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_M.Location = new System.Drawing.Point(19, 24);
            this.lbl_M.Name = "lbl_M";
            this.lbl_M.Size = new System.Drawing.Size(77, 13);
            this.lbl_M.TabIndex = 2;
            this.lbl_M.Text = "Movimientos";
            // 
            // lbl_NumeroMovimientos
            // 
            this.lbl_NumeroMovimientos.AutoSize = true;
            this.lbl_NumeroMovimientos.Location = new System.Drawing.Point(50, 57);
            this.lbl_NumeroMovimientos.Name = "lbl_NumeroMovimientos";
            this.lbl_NumeroMovimientos.Size = new System.Drawing.Size(16, 13);
            this.lbl_NumeroMovimientos.TabIndex = 3;
            this.lbl_NumeroMovimientos.Text = "...";
            this.lbl_NumeroMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_R);
            this.panel2.Controls.Add(this.lbl_ResultadoFinal);
            this.panel2.Location = new System.Drawing.Point(3, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 103);
            this.panel2.TabIndex = 20;
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_R.Location = new System.Drawing.Point(29, 22);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(64, 13);
            this.lbl_R.TabIndex = 1;
            this.lbl_R.Text = "Resultado";
            // 
            // lbl_ResultadoFinal
            // 
            this.lbl_ResultadoFinal.AutoSize = true;
            this.lbl_ResultadoFinal.Location = new System.Drawing.Point(50, 54);
            this.lbl_ResultadoFinal.Name = "lbl_ResultadoFinal";
            this.lbl_ResultadoFinal.Size = new System.Drawing.Size(16, 13);
            this.lbl_ResultadoFinal.TabIndex = 4;
            this.lbl_ResultadoFinal.Text = "...";
            this.lbl_ResultadoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_Movimientos
            // 
            this.panel_Movimientos.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_Movimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Movimientos.Controls.Add(this.label7);
            this.panel_Movimientos.Controls.Add(this.lbl_Cronometro);
            this.panel_Movimientos.Location = new System.Drawing.Point(3, 232);
            this.panel_Movimientos.Name = "panel_Movimientos";
            this.panel_Movimientos.Size = new System.Drawing.Size(122, 126);
            this.panel_Movimientos.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cronometro";
            // 
            // panel_Torres
            // 
            this.panel_Torres.BackColor = System.Drawing.Color.LightGray;
            this.panel_Torres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Torres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Torres.Enabled = false;
            this.panel_Torres.Location = new System.Drawing.Point(203, 32);
            this.panel_Torres.Name = "panel_Torres";
            this.panel_Torres.Size = new System.Drawing.Size(601, 362);
            this.panel_Torres.TabIndex = 0;
            this.panel_Torres.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Torres_Paint);
            this.panel_Torres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Torres_MouseDown);
            this.panel_Torres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Torres_MouseMove);
            this.panel_Torres.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Torres_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(203, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 46);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "TORRE I";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(443, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "TORRE II";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(604, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "TORRE III";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "by wsullivan";
            // 
            // dataGridView_Solucion
            // 
            this.dataGridView_Solucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Solucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_Solucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Solucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_Solucion.Location = new System.Drawing.Point(12, 32);
            this.dataGridView_Solucion.Name = "dataGridView_Solucion";
            this.dataGridView_Solucion.ReadOnly = true;
            this.dataGridView_Solucion.Size = new System.Drawing.Size(185, 362);
            this.dataGridView_Solucion.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Solucion al Juego";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btn_LipiarCeldas
            // 
            this.btn_LipiarCeldas.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_LipiarCeldas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LipiarCeldas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LipiarCeldas.Image = ((System.Drawing.Image)(resources.GetObject("btn_LipiarCeldas.Image")));
            this.btn_LipiarCeldas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LipiarCeldas.Location = new System.Drawing.Point(12, 400);
            this.btn_LipiarCeldas.Name = "btn_LipiarCeldas";
            this.btn_LipiarCeldas.Size = new System.Drawing.Size(185, 27);
            this.btn_LipiarCeldas.TabIndex = 26;
            this.btn_LipiarCeldas.Text = "Limpiar Celdas";
            this.btn_LipiarCeldas.UseVisualStyleBackColor = false;
            this.btn_LipiarCeldas.Click += new System.EventHandler(this.limpiarCeldas_Click);
            // 
            // GUI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(954, 451);
            this.Controls.Add(this.btn_LipiarCeldas);
            this.Controls.Add(this.dataGridView_Solucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Botones);
            this.Controls.Add(this.panel_Torres);
            this.Controls.Add(this.menuStrip_BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip_BarraTitulo;
            this.Name = "GUI_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanoi";
            this.Load += new System.EventHandler(this.torresHanoi_Load);
            this.menuStrip_BarraTitulo.ResumeLayout(false);
            this.menuStrip_BarraTitulo.PerformLayout();
            this.panel_Botones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Movimientos.ResumeLayout(false);
            this.panel_Movimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Solucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Cronometro;
        private System.Windows.Forms.Timer timer_Partida;
        private System.Windows.Forms.MenuStrip menuStrip_BarraTitulo;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelDificilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelesDeJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dificlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normasDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Botones;
        private System.Windows.Forms.Panel panel_Movimientos;
        private System.Windows.Forms.Label lbl_NumeroMovimientos;
        private System.Windows.Forms.Label lbl_M;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.Label lbl_ResultadoFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Solucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_LipiarCeldas;
        private System.Windows.Forms.Panel panel_Torres;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
    }
}

