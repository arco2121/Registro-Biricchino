using System.Drawing;

namespace RegistroBiricchino
{
    partial class Login
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Carica = new System.Windows.Forms.Button();
            this.Crea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Carica
            // 
            this.Carica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.Carica.Location = new System.Drawing.Point(179, 135);
            this.Carica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Carica.Name = "Carica";
            this.Carica.Size = new System.Drawing.Size(178, 165);
            this.Carica.TabIndex = 0;
            this.Carica.Text = "Cairca";
            this.Carica.UseVisualStyleBackColor = false;
            this.Carica.Click += new System.EventHandler(this.Carica_Click);
            // 
            // Crea
            // 
            this.Crea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.Crea.Location = new System.Drawing.Point(431, 135);
            this.Crea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Crea.Name = "Crea";
            this.Crea.Size = new System.Drawing.Size(178, 165);
            this.Crea.TabIndex = 1;
            this.Crea.Text = "Crea";
            this.Crea.UseVisualStyleBackColor = false;
            this.Crea.Click += new System.EventHandler(this.Crea_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.Crea);
            this.Controls.Add(this.Carica);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Registro Biricchino : Crea o Carica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Carica;
        private System.Windows.Forms.Button Crea;
    }
}

