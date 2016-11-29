namespace TorreHanoi
{
    partial class frm_play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_play));
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_rules = new System.Windows.Forms.Button();
            this.lblIntentos3 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblIntentos2 = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.juego = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.juego.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pause.Enabled = false;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_pause.Image")));
            this.btn_pause.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_pause.Location = new System.Drawing.Point(10, 67);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(162, 45);
            this.btn_pause.TabIndex = 26;
            this.btn_pause.Text = "&Pausa";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.Image")));
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_return.Location = new System.Drawing.Point(10, 169);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(162, 45);
            this.btn_return.TabIndex = 21;
            this.btn_return.Text = "&Atras";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_rules
            // 
            this.btn_rules.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rules.Image = ((System.Drawing.Image)(resources.GetObject("btn_rules.Image")));
            this.btn_rules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rules.Location = new System.Drawing.Point(10, 118);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(162, 45);
            this.btn_rules.TabIndex = 20;
            this.btn_rules.Text = "&Reglas";
            this.btn_rules.UseVisualStyleBackColor = false;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // lblIntentos3
            // 
            this.lblIntentos3.AutoSize = true;
            this.lblIntentos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos3.Location = new System.Drawing.Point(173, 45);
            this.lblIntentos3.Name = "lblIntentos3";
            this.lblIntentos3.Size = new System.Drawing.Size(116, 36);
            this.lblIntentos3.TabIndex = 25;
            this.lblIntentos3.Text = "0:00:00";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(55, 45);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(103, 29);
            this.lblTiempo.TabIndex = 24;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // lblIntentos2
            // 
            this.lblIntentos2.AutoSize = true;
            this.lblIntentos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos2.Location = new System.Drawing.Point(173, 14);
            this.lblIntentos2.Name = "lblIntentos2";
            this.lblIntentos2.Size = new System.Drawing.Size(29, 31);
            this.lblIntentos2.TabIndex = 23;
            this.lblIntentos2.Text = "0";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(12, 14);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(155, 29);
            this.lblIntentos.TabIndex = 22;
            this.lblIntentos.Text = "Movimientos:";
            // 
            // juego
            // 
            this.juego.BackColor = System.Drawing.Color.Transparent;
            this.juego.Controls.Add(this.label4);
            this.juego.Controls.Add(this.label3);
            this.juego.Controls.Add(this.label2);
            this.juego.Location = new System.Drawing.Point(198, 22);
            this.juego.Name = "juego";
            this.juego.Size = new System.Drawing.Size(500, 250);
            this.juego.TabIndex = 16;
            this.juego.Paint += new System.Windows.Forms.PaintEventHandler(this.juego_Paint);
            this.juego.MouseDown += new System.Windows.Forms.MouseEventHandler(this.juego_MouseDown);
            this.juego.MouseMove += new System.Windows.Forms.MouseEventHandler(this.juego_MouseMove);
            this.juego.MouseUp += new System.Windows.Forms.MouseEventHandler(this.juego_MouseUp);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_rules);
            this.panel1.Controls.Add(this.btn_return);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 224);
            this.panel1.TabIndex = 27;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reset.Enabled = false;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_reset.Location = new System.Drawing.Point(10, 16);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(162, 45);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "&Reiniciar";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblIntentos);
            this.panel2.Controls.Add(this.lblIntentos2);
            this.panel2.Controls.Add(this.lblIntentos3);
            this.panel2.Controls.Add(this.lblTiempo);
            this.panel2.Location = new System.Drawing.Point(198, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 94);
            this.panel2.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.juego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.juego.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_rules;
        private System.Windows.Forms.Label lblIntentos3;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblIntentos2;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Panel juego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_reset;
    }
}