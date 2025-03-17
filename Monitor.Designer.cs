namespace ProgramowanieWizualneLab2
{
    partial class Monitor
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
            this.lista_monitor = new System.Windows.Forms.ListView();
            this.cena_etykieta_nie_dotykac = new System.Windows.Forms.Label();
            this.okejka_monitor = new System.Windows.Forms.Button();
            this.anuluj_monitor = new System.Windows.Forms.Button();
            this.cena_monitor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista_monitor
            // 
            this.lista_monitor.HideSelection = false;
            this.lista_monitor.Location = new System.Drawing.Point(12, 24);
            this.lista_monitor.Name = "lista_monitor";
            this.lista_monitor.Size = new System.Drawing.Size(420, 161);
            this.lista_monitor.TabIndex = 0;
            this.lista_monitor.UseCompatibleStateImageBehavior = false;
            this.lista_monitor.SelectedIndexChanged += new System.EventHandler(this.lista_monitor_SelectedIndexChanged);
            // 
            // cena_etykieta_nie_dotykac
            // 
            this.cena_etykieta_nie_dotykac.AutoSize = true;
            this.cena_etykieta_nie_dotykac.Location = new System.Drawing.Point(115, 273);
            this.cena_etykieta_nie_dotykac.Name = "cena_etykieta_nie_dotykac";
            this.cena_etykieta_nie_dotykac.Size = new System.Drawing.Size(39, 16);
            this.cena_etykieta_nie_dotykac.TabIndex = 1;
            this.cena_etykieta_nie_dotykac.Text = "Cena";
            // 
            // okejka_monitor
            // 
            this.okejka_monitor.Location = new System.Drawing.Point(27, 361);
            this.okejka_monitor.Name = "okejka_monitor";
            this.okejka_monitor.Size = new System.Drawing.Size(142, 77);
            this.okejka_monitor.TabIndex = 2;
            this.okejka_monitor.Text = "OK";
            this.okejka_monitor.UseVisualStyleBackColor = true;
            this.okejka_monitor.Click += new System.EventHandler(this.okejka_monitor_Click);
            // 
            // anuluj_monitor
            // 
            this.anuluj_monitor.Location = new System.Drawing.Point(252, 361);
            this.anuluj_monitor.Name = "anuluj_monitor";
            this.anuluj_monitor.Size = new System.Drawing.Size(154, 77);
            this.anuluj_monitor.TabIndex = 3;
            this.anuluj_monitor.Text = "ANULUJ";
            this.anuluj_monitor.UseVisualStyleBackColor = true;
            // 
            // cena_monitor
            // 
            this.cena_monitor.AutoSize = true;
            this.cena_monitor.Location = new System.Drawing.Point(279, 273);
            this.cena_monitor.Name = "cena_monitor";
            this.cena_monitor.Size = new System.Drawing.Size(0, 16);
            this.cena_monitor.TabIndex = 4;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.cena_monitor);
            this.Controls.Add(this.anuluj_monitor);
            this.Controls.Add(this.okejka_monitor);
            this.Controls.Add(this.cena_etykieta_nie_dotykac);
            this.Controls.Add(this.lista_monitor);
            this.Name = "Monitor";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_monitor;
        private System.Windows.Forms.Label cena_etykieta_nie_dotykac;
        private System.Windows.Forms.Button okejka_monitor;
        private System.Windows.Forms.Button anuluj_monitor;
        private System.Windows.Forms.Label cena_monitor;
    }
}