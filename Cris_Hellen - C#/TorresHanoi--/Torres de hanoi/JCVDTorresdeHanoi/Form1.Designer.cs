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
            this.lblAnillos = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblIntentos2 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblIntentos3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPausa = new System.Windows.Forms.Button();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.panel_juego = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbx_nivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_demo = new System.Windows.Forms.Button();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.juego.SuspendLayout();
            this.panel_juego.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // juego
            // 
            this.juego.BackColor = System.Drawing.Color.Transparent;
            this.juego.Controls.Add(this.label4);
            this.juego.Controls.Add(this.label3);
            this.juego.Controls.Add(this.label2);
            this.juego.Location = new System.Drawing.Point(19, 67);
            this.juego.Name = "juego";
            this.juego.Size = new System.Drawing.Size(500, 246);
            this.juego.TabIndex = 0;
            this.juego.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.juego.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.juego.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.juego.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(403, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "C";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(243, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(83, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A";
            this.label2.Visible = false;
            // 
            // lblAnillos
            // 
            this.lblAnillos.AutoSize = true;
            this.lblAnillos.BackColor = System.Drawing.Color.Transparent;
            this.lblAnillos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnillos.ForeColor = System.Drawing.Color.Navy;
            this.lblAnillos.Location = new System.Drawing.Point(201, 6);
            this.lblAnillos.Name = "lblAnillos";
            this.lblAnillos.Size = new System.Drawing.Size(57, 27);
            this.lblAnillos.TabIndex = 6;
            this.lblAnillos.Text = "Nivel";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.BackColor = System.Drawing.Color.Transparent;
            this.lblIntentos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.ForeColor = System.Drawing.Color.Navy;
            this.lblIntentos.Location = new System.Drawing.Point(313, 39);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(82, 23);
            this.lblIntentos.TabIndex = 10;
            this.lblIntentos.Text = "Intentos:";
            this.lblIntentos.Visible = false;
            // 
            // lblIntentos2
            // 
            this.lblIntentos2.AutoSize = true;
            this.lblIntentos2.BackColor = System.Drawing.Color.Transparent;
            this.lblIntentos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos2.ForeColor = System.Drawing.Color.Navy;
            this.lblIntentos2.Location = new System.Drawing.Point(389, 39);
            this.lblIntentos2.Name = "lblIntentos2";
            this.lblIntentos2.Size = new System.Drawing.Size(25, 25);
            this.lblIntentos2.TabIndex = 11;
            this.lblIntentos2.Text = "0";
            this.lblIntentos2.Visible = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Navy;
            this.lblTiempo.Location = new System.Drawing.Point(309, 10);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 23);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "Tiempo:";
            this.lblTiempo.Visible = false;
            // 
            // lblIntentos3
            // 
            this.lblIntentos3.AutoSize = true;
            this.lblIntentos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos3.ForeColor = System.Drawing.Color.Navy;
            this.lblIntentos3.Location = new System.Drawing.Point(383, 10);
            this.lblIntentos3.Name = "lblIntentos3";
            this.lblIntentos3.Size = new System.Drawing.Size(0, 29);
            this.lblIntentos3.TabIndex = 13;
            this.lblIntentos3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPausa.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPausa.Location = new System.Drawing.Point(19, 12);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(94, 38);
            this.btnPausa.TabIndex = 14;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Visible = false;
            this.btnPausa.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nivel.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_nivel.Location = new System.Drawing.Point(201, 33);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(20, 27);
            this.lb_nivel.TabIndex = 15;
            this.lb_nivel.Text = ".";
            // 
            // panel_juego
            // 
            this.panel_juego.Controls.Add(this.btn_salir);
            this.panel_juego.Controls.Add(this.btn_menu);
            this.panel_juego.Controls.Add(this.juego);
            this.panel_juego.Controls.Add(this.btnPausa);
            this.panel_juego.Controls.Add(this.lb_nivel);
            this.panel_juego.Controls.Add(this.lblAnillos);
            this.panel_juego.Controls.Add(this.lblIntentos);
            this.panel_juego.Controls.Add(this.lblIntentos3);
            this.panel_juego.Controls.Add(this.lblIntentos2);
            this.panel_juego.Controls.Add(this.lblTiempo);
            this.panel_juego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_juego.Location = new System.Drawing.Point(0, 0);
            this.panel_juego.Name = "panel_juego";
            this.panel_juego.Size = new System.Drawing.Size(545, 356);
            this.panel_juego.TabIndex = 17;
            this.panel_juego.Visible = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_menu.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu.Location = new System.Drawing.Point(12, 318);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(94, 35);
            this.btn_menu.TabIndex = 16;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Visible = false;
            this.btn_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Controls.Add(this.cbx_nivel);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.btn_demo);
            this.panel_menu.Controls.Add(this.btn_jugar);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(545, 356);
            this.panel_menu.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(119, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cbx_nivel
            // 
            this.cbx_nivel.BackColor = System.Drawing.Color.LightGray;
            this.cbx_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nivel.FormattingEnabled = true;
            this.cbx_nivel.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.cbx_nivel.Location = new System.Drawing.Point(190, 205);
            this.cbx_nivel.Name = "cbx_nivel";
            this.cbx_nivel.Size = new System.Drawing.Size(143, 32);
            this.cbx_nivel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nivel";
            // 
            // btn_demo
            // 
            this.btn_demo.Location = new System.Drawing.Point(302, 264);
            this.btn_demo.Name = "btn_demo";
            this.btn_demo.Size = new System.Drawing.Size(188, 55);
            this.btn_demo.TabIndex = 6;
            this.btn_demo.UseVisualStyleBackColor = true;
            this.btn_demo.Click += new System.EventHandler(this.btn_demo_Click);
            // 
            // btn_jugar
            // 
            this.btn_jugar.Location = new System.Drawing.Point(33, 260);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(188, 58);
            this.btn_jugar.TabIndex = 5;
            this.btn_jugar.UseVisualStyleBackColor = true;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_salir.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(12, 318);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 35);
            this.btn_salir.TabIndex = 17;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Visible = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // torresHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(545, 356);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_juego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "torresHanoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanoi";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.torresHanoi_KeyPress);
            this.juego.ResumeLayout(false);
            this.panel_juego.ResumeLayout(false);
            this.panel_juego.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel juego;
        private System.Windows.Forms.Label lblAnillos;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblIntentos2;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblIntentos3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.Panel panel_juego;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbx_nivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_demo;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_salir;
    }
}

