namespace ProgramowanieWizualneLab2
{
    partial class Komputer
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cena_proc = new System.Windows.Forms.Label();
            this.dysk_wyb = new System.Windows.Forms.Label();
            this.dyska = new System.Windows.Forms.RadioButton();
            this.dyskb = new System.Windows.Forms.RadioButton();
            this.dyskc = new System.Windows.Forms.RadioButton();
            this.dyskcena = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Label();
            this.cena_razem = new System.Windows.Forms.Label();
            this.okej = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cena_proc
            // 
            this.cena_proc.AutoSize = true;
            this.cena_proc.Location = new System.Drawing.Point(243, 48);
            this.cena_proc.Name = "cena_proc";
            this.cena_proc.Size = new System.Drawing.Size(0, 16);
            this.cena_proc.TabIndex = 3;
            // 
            // dysk_wyb
            // 
            this.dysk_wyb.AutoSize = true;
            this.dysk_wyb.Location = new System.Drawing.Point(40, 195);
            this.dysk_wyb.Name = "dysk_wyb";
            this.dysk_wyb.Size = new System.Drawing.Size(41, 16);
            this.dysk_wyb.TabIndex = 4;
            this.dysk_wyb.Text = "Dysk:";
            // 
            // dyska
            // 
            this.dyska.AutoSize = true;
            this.dyska.Location = new System.Drawing.Point(90, 221);
            this.dyska.Name = "dyska";
            this.dyska.Size = new System.Drawing.Size(71, 20);
            this.dyska.TabIndex = 5;
            this.dyska.TabStop = true;
            this.dyska.Text = "Dysk A";
            this.dyska.UseVisualStyleBackColor = true;
            this.dyska.CheckedChanged += new System.EventHandler(this.dyska_CheckedChanged);
            // 
            // dyskb
            // 
            this.dyskb.AutoSize = true;
            this.dyskb.Location = new System.Drawing.Point(90, 247);
            this.dyskb.Name = "dyskb";
            this.dyskb.Size = new System.Drawing.Size(71, 20);
            this.dyskb.TabIndex = 6;
            this.dyskb.TabStop = true;
            this.dyskb.Text = "Dysk B";
            this.dyskb.UseVisualStyleBackColor = true;
            this.dyskb.CheckedChanged += new System.EventHandler(this.dyskb_CheckedChanged);
            // 
            // dyskc
            // 
            this.dyskc.AutoSize = true;
            this.dyskc.Location = new System.Drawing.Point(90, 273);
            this.dyskc.Name = "dyskc";
            this.dyskc.Size = new System.Drawing.Size(71, 20);
            this.dyskc.TabIndex = 7;
            this.dyskc.TabStop = true;
            this.dyskc.Text = "Dysk C";
            this.dyskc.UseVisualStyleBackColor = true;
            this.dyskc.CheckedChanged += new System.EventHandler(this.dyskc_CheckedChanged);
            // 
            // dyskcena
            // 
            this.dyskcena.AutoSize = true;
            this.dyskcena.Location = new System.Drawing.Point(243, 195);
            this.dyskcena.Name = "dyskcena";
            this.dyskcena.Size = new System.Drawing.Size(0, 16);
            this.dyskcena.TabIndex = 8;
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(40, 330);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(52, 16);
            this.suma.TabIndex = 9;
            this.suma.Text = "Reszta:";
            // 
            // cena_razem
            // 
            this.cena_razem.AutoSize = true;
            this.cena_razem.Location = new System.Drawing.Point(199, 330);
            this.cena_razem.Name = "cena_razem";
            this.cena_razem.Size = new System.Drawing.Size(0, 16);
            this.cena_razem.TabIndex = 10;
            // 
            // okej
            // 
            this.okej.Location = new System.Drawing.Point(28, 370);
            this.okej.Name = "okej";
            this.okej.Size = new System.Drawing.Size(133, 68);
            this.okej.TabIndex = 11;
            this.okej.Text = "OK";
            this.okej.UseVisualStyleBackColor = true;
            this.okej.Click += new System.EventHandler(this.okej_Click);
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(228, 370);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(131, 68);
            this.anuluj.TabIndex = 12;
            this.anuluj.Text = "ANULUJ";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // Komputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.okej);
            this.Controls.Add(this.cena_razem);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.dyskcena);
            this.Controls.Add(this.dyskc);
            this.Controls.Add(this.dyskb);
            this.Controls.Add(this.dyska);
            this.Controls.Add(this.dysk_wyb);
            this.Controls.Add(this.cena_proc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Komputer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Komputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cena_proc;
        private System.Windows.Forms.Label dysk_wyb;
        private System.Windows.Forms.RadioButton dyska;
        private System.Windows.Forms.RadioButton dyskb;
        private System.Windows.Forms.RadioButton dyskc;
        private System.Windows.Forms.Label dyskcena;
        private System.Windows.Forms.Label suma;
        private System.Windows.Forms.Label cena_razem;
        private System.Windows.Forms.Button okej;
        private System.Windows.Forms.Button anuluj;
    }
}