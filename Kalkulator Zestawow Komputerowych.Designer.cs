namespace ProgramowanieWizualneLab2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.KomputerPrzycisk = new System.Windows.Forms.Button();
            this.MonitorKlik = new System.Windows.Forms.Button();
            this.cenasuma = new System.Windows.Forms.Label();
            this.tekst_nieuzytkowy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KomputerPrzycisk
            // 
            this.KomputerPrzycisk.Location = new System.Drawing.Point(46, 114);
            this.KomputerPrzycisk.Name = "KomputerPrzycisk";
            this.KomputerPrzycisk.Size = new System.Drawing.Size(156, 74);
            this.KomputerPrzycisk.TabIndex = 0;
            this.KomputerPrzycisk.Text = "Komputer";
            this.KomputerPrzycisk.UseVisualStyleBackColor = true;
            this.KomputerPrzycisk.Click += new System.EventHandler(this.KomputerPrzycisk_Click);
            // 
            // MonitorKlik
            // 
            this.MonitorKlik.Location = new System.Drawing.Point(243, 114);
            this.MonitorKlik.Name = "MonitorKlik";
            this.MonitorKlik.Size = new System.Drawing.Size(155, 74);
            this.MonitorKlik.TabIndex = 1;
            this.MonitorKlik.Text = "Monitor";
            this.MonitorKlik.UseVisualStyleBackColor = true;
            this.MonitorKlik.Click += new System.EventHandler(this.MonitorKlik_Click);
            // 
            // cenasuma
            // 
            this.cenasuma.AutoSize = true;
            this.cenasuma.Location = new System.Drawing.Point(502, 143);
            this.cenasuma.Name = "cenasuma";
            this.cenasuma.Size = new System.Drawing.Size(0, 16);
            this.cenasuma.TabIndex = 2;
            // 
            // tekst_nieuzytkowy
            // 
            this.tekst_nieuzytkowy.AutoSize = true;
            this.tekst_nieuzytkowy.Location = new System.Drawing.Point(502, 78);
            this.tekst_nieuzytkowy.Name = "tekst_nieuzytkowy";
            this.tekst_nieuzytkowy.Size = new System.Drawing.Size(57, 16);
            this.tekst_nieuzytkowy.TabIndex = 3;
            this.tekst_nieuzytkowy.Text = "Cena zł:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 308);
            this.Controls.Add(this.tekst_nieuzytkowy);
            this.Controls.Add(this.cenasuma);
            this.Controls.Add(this.MonitorKlik);
            this.Controls.Add(this.KomputerPrzycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KomputerPrzycisk;
        private System.Windows.Forms.Button MonitorKlik;
        private System.Windows.Forms.Label cenasuma;
        private System.Windows.Forms.Label tekst_nieuzytkowy;
    }
}

