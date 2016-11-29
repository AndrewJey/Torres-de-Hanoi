namespace TorresdeHanoi
{
    partial class frmDificultad
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.rbtnFacil = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnUltraViolencia = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbDificultad = new System.Windows.Forms.GroupBox();
            this.gbDificultad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 17);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(158, 27);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Nuevo Juego";
            // 
            // rbtnFacil
            // 
            this.rbtnFacil.AutoSize = true;
            this.rbtnFacil.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFacil.Location = new System.Drawing.Point(6, 33);
            this.rbtnFacil.Name = "rbtnFacil";
            this.rbtnFacil.Size = new System.Drawing.Size(88, 34);
            this.rbtnFacil.TabIndex = 1;
            this.rbtnFacil.TabStop = true;
            this.rbtnFacil.Text = "Fácil\r\n(3 Discos)";
            this.rbtnFacil.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNormal.Location = new System.Drawing.Point(98, 33);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(88, 34);
            this.rbtnNormal.TabIndex = 1;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Normal\r\n(6 Discos)";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // rbtnUltraViolencia
            // 
            this.rbtnUltraViolencia.AutoSize = true;
            this.rbtnUltraViolencia.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUltraViolencia.Location = new System.Drawing.Point(195, 33);
            this.rbtnUltraViolencia.Name = "rbtnUltraViolencia";
            this.rbtnUltraViolencia.Size = new System.Drawing.Size(111, 34);
            this.rbtnUltraViolencia.TabIndex = 1;
            this.rbtnUltraViolencia.TabStop = true;
            this.rbtnUltraViolencia.Text = "UltraViolencia\r\n(8 Discos)";
            this.rbtnUltraViolencia.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(107, 186);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 48);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbDificultad
            // 
            this.gbDificultad.Controls.Add(this.rbtnFacil);
            this.gbDificultad.Controls.Add(this.rbtnNormal);
            this.gbDificultad.Controls.Add(this.rbtnUltraViolencia);
            this.gbDificultad.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDificultad.Location = new System.Drawing.Point(12, 73);
            this.gbDificultad.Name = "gbDificultad";
            this.gbDificultad.Size = new System.Drawing.Size(309, 83);
            this.gbDificultad.TabIndex = 3;
            this.gbDificultad.TabStop = false;
            this.gbDificultad.Text = "Seleccione la dificultad";
            // 
            // frmDificultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 268);
            this.Controls.Add(this.gbDificultad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMensaje);
            this.Name = "frmDificultad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dificultad";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gbDificultad.ResumeLayout(false);
            this.gbDificultad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.RadioButton rbtnFacil;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.RadioButton rbtnUltraViolencia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbDificultad;
    }
}