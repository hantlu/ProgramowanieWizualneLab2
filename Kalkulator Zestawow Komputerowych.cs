using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramowanieWizualneLab2
{
    public partial class Form1 : Form
    {

        private double sumaCen = 0;
        private double cenaMonitora = 0;
        private double cenaKomputera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void KomputerPrzycisk_Click(object sender, EventArgs e)
        {
            Komputer komputer = new Komputer(this);
            //komputer.PrzekazWartosc -= Komponent_PrzekazWartosc;
            komputer.PrzekazWartosc += Komputer_PrzekazWartosc;
            komputer.Show();

        }

        private void Monitor_PrzekazWartosc(double liczba)
        {
            cenaMonitora = liczba; 
            AktualizujSume();
        }

        private void Komputer_PrzekazWartosc(double liczba)
        {
            cenaKomputera = liczba; 
            AktualizujSume();
        }

        private void AktualizujSume()
        {
            double suma = cenaMonitora + cenaKomputera;
            cenasuma.Text = suma.ToString("F2") + " zł"; 
        }




        private void MonitorKlik_Click(object sender, EventArgs e)
        {
            Monitor monitor = new Monitor(this);
            //monitor.PrzekazWartosc -= Komponent_PrzekazWartosc;
            monitor.PrzekazWartosc += Monitor_PrzekazWartosc;
            monitor.Show();
        }
    }
}
