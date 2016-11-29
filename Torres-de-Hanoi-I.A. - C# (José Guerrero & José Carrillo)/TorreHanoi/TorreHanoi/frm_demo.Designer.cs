namespace TorreHanoi
{
    partial class frm_demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_demo));
            this.juego = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_move = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.juego.SuspendLayout();
            this.SuspendLayout();
            // 
            // juego
            // 
            this.juego.BackColor = System.Drawing.Color.Transparent;
            this.juego.Controls.Add(this.label4);
            this.juego.Controls.Add(this.label3);
            this.juego.Controls.Add(this.label2);
            this.juego.Location = new System.Drawing.Point(12, 12);
            this.juego.Name = "juego";
            this.juego.Size = new System.Drawing.Size(500, 250);
            this.juego.TabIndex = 1;
            this.juego.Paint += new System.Windows.Forms.PaintEventHandler(this.juego_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movimientos";
            // 
            // lbl_move
            // 
            this.lbl_move.AutoSize = true;
            this.lbl_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_move.Location = new System.Drawing.Point(115, 284);
            this.lbl_move.Name = "lbl_move";
            this.lbl_move.Size = new System.Drawing.Size(23, 25);
            this.lbl_move.TabIndex = 3;
            this.lbl_move.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Para regresar al menu presione Enter o Esc";
            // 
            // frm_demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_move);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.juego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_demo_KeyPress);
            this.juego.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel juego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_move;
        private System.Windows.Forms.Label label5;
    }
}