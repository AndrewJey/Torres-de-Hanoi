namespace TorresdeHanoi
{
    partial class torresHanoi
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
            this.juego = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJUgar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblIntentos2 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblIntentos3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPausa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstNuevoJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.mstVolverMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mstSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.juego.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // juego
            // 
            this.juego.BackColor = System.Drawing.Color.Transparent;
            this.juego.Controls.Add(this.label4);
            this.juego.Controls.Add(this.label3);
            this.juego.Controls.Add(this.label2);
            this.juego.Location = new System.Drawing.Point(17, 106);
            this.juego.Name = "juego";
            this.juego.Size = new System.Drawing.Size(500, 250);
            this.juego.TabIndex = 0;
            this.juego.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.juego.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.juego.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.juego.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(403, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "C";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(243, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(83, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A";
            this.label2.Visible = false;
            // 
            // btnJUgar
            // 
            this.btnJUgar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnJUgar.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJUgar.Location = new System.Drawing.Point(18, 362);
            this.btnJUgar.Name = "btnJUgar";
            this.btnJUgar.Size = new System.Drawing.Size(162, 45);
            this.btnJUgar.TabIndex = 0;
            this.btnJUgar.Text = "Reiniciar";
            this.btnJUgar.UseVisualStyleBackColor = false;
            this.btnJUgar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(354, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 45);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(13, 37);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(121, 23);
            this.lblIntentos.TabIndex = 10;
            this.lblIntentos.Text = "Movimientos:";
            // 
            // lblIntentos2
            // 
            this.lblIntentos2.AutoSize = true;
            this.lblIntentos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos2.Location = new System.Drawing.Point(134, 35);
            this.lblIntentos2.Name = "lblIntentos2";
            this.lblIntentos2.Size = new System.Drawing.Size(25, 25);
            this.lblIntentos2.TabIndex = 11;
            this.lblIntentos2.Text = "0";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(13, 74);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 23);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // lblIntentos3
            // 
            this.lblIntentos3.AutoSize = true;
            this.lblIntentos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos3.Location = new System.Drawing.Point(93, 74);
            this.lblIntentos3.Name = "lblIntentos3";
            this.lblIntentos3.Size = new System.Drawing.Size(0, 29);
            this.lblIntentos3.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPausa.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausa.Location = new System.Drawing.Point(186, 361);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(162, 45);
            this.btnPausa.TabIndex = 14;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Visible = false;
            this.btnPausa.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstNuevoJuego,
            this.mstVolverMenu,
            this.mstSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mstNuevoJuego
            // 
            this.mstNuevoJuego.Name = "mstNuevoJuego";
            this.mstNuevoJuego.Size = new System.Drawing.Size(153, 22);
            this.mstNuevoJuego.Text = "Nuevo Juego";
            this.mstNuevoJuego.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // mstVolverMenu
            // 
            this.mstVolverMenu.Name = "mstVolverMenu";
            this.mstVolverMenu.Size = new System.Drawing.Size(153, 22);
            this.mstVolverMenu.Text = "Volver al Menu";
            this.mstVolverMenu.Click += new System.EventHandler(this.mstVolverMenu_Click);
            // 
            // mstSalir
            // 
            this.mstSalir.Name = "mstSalir";
            this.mstSalir.Size = new System.Drawing.Size(153, 22);
            this.mstSalir.Text = "Salir";
            this.mstSalir.Click += new System.EventHandler(this.mstSalir_Click);
            // 
            // torresHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 418);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIntentos3);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblIntentos2);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.btnJUgar);
            this.Controls.Add(this.juego);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "torresHanoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanói";
            this.Load += new System.EventHandler(this.torresHanoi_Load);
            this.juego.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel juego;
        private System.Windows.Forms.Button btnJUgar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblIntentos2;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblIntentos3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstNuevoJuego;
        private System.Windows.Forms.ToolStripMenuItem mstVolverMenu;
        private System.Windows.Forms.ToolStripMenuItem mstSalir;
    }
}

