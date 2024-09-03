using System.Drawing;

namespace RegistroBiricchino
{
    partial class Visu
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
            this.Studente = new System.Windows.Forms.Button();
            this.Prof = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Studente
            // 
            this.Studente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.Studente.Location = new System.Drawing.Point(437, 130);
            this.Studente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Studente.Name = "Studente";
            this.Studente.Size = new System.Drawing.Size(178, 165);
            this.Studente.TabIndex = 3;
            this.Studente.Text = "Studente";
            this.Studente.UseVisualStyleBackColor = false;
            this.Studente.Click += new System.EventHandler(this.Studente_Click);
            // 
            // Prof
            // 
            this.Prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.Prof.Location = new System.Drawing.Point(185, 130);
            this.Prof.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(178, 165);
            this.Prof.TabIndex = 2;
            this.Prof.Text = "Professore";
            this.Prof.UseVisualStyleBackColor = false;
            this.Prof.Click += new System.EventHandler(this.Prof_Click);
            // 
            // Visu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.Studente);
            this.Controls.Add(this.Prof);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Visu";
            this.Text = "Registro Biricchino : Visualizza come: ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Visu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Studente;
        private System.Windows.Forms.Button Prof;
    }
}