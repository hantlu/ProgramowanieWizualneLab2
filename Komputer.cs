using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramowanieWizualneLab2
{   public partial class Komputer : Form
    {
        Procesor p1 = new Procesor("Procseor A", 299.99);
        Procesor p2 = new Procesor("Procesor B", 99.99);
        Procesor p3 = new Procesor("Procesor C", 9.99);

        double cena_proc_suma = 0;
        double cena_dysk_suma = 0;
        double razem;
        //double cena_RAZEM = 0;
        public Komputer()
        {
            InitializeComponent();
            comboBox1.Items.Add(p1);
            comboBox1.Items.Add(p2);
            comboBox1.Items.Add(p3);
        }

        public void Sumowanie(double procesor, double dysk)
        {
            razem = procesor + dysk;
            cena_razem.Text = $"Cena: {razem:C}";
            //return razem;
        }

       
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;

            if(comboBox1.SelectedItem != null)
            {
                Procesor wybranyProcesor = (Procesor)comboBox1.SelectedItem;
                cena_proc.Text = $"Cena: {wybranyProcesor.Cena:C}";
                cena_proc_suma = wybranyProcesor.Cena;
                Sumowanie(cena_proc_suma, cena_dysk_suma);
            }
            
        }

        private void Komputer_Load(object sender, EventArgs e)
        {

        }

        private void dyska_CheckedChanged(object sender, EventArgs e)
        {
            // Dysk A cena 50.99
            double cena_a = 50.99;
            dyskcena.Text = $"Cena: 50.99";
            cena_dysk_suma = cena_a;
            Sumowanie(cena_proc_suma, cena_dysk_suma);
        }

        private void dyskb_CheckedChanged(object sender, EventArgs e)
        {
            double cena_b = 199.99;
            dyskcena.Text = $"Cena: 199.99";
            cena_dysk_suma = cena_b;
            Sumowanie(cena_proc_suma, cena_dysk_suma);
        }

        private void dyskc_CheckedChanged(object sender, EventArgs e)
        {
            double cena_c = 10.99;
            dyskcena.Text = $"Cena: 10.99";
            cena_dysk_suma = cena_c;
            Sumowanie(cena_proc_suma, cena_dysk_suma);

        }

        private void okej_Click(object sender, EventArgs e)
        {

        }
    }



    public class Procesor
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Procesor(string nazwa, double cena)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
        }

        public override string ToString()
        {
            return $"{Nazwa}";
        }
    }
}
