using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramowanieWizualneLab2
{
    public partial class Monitor : Form
    {

        Monitory m1 = new Monitory("Monitor A", 300.99);
        Monitory m2 = new Monitory("Monitor B", 100.99);
        Monitory m3 = new Monitory("Monitor C", 49.99);

        private Form1 form1;
        public delegate void PrzekazWartoscHandler(double liczba);
        public event PrzekazWartoscHandler PrzekazWartosc;
        public Monitor(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            //lista_monitor.Items.Add(new ListViewItem(m1.Nazwa));
            //lista_monitor.Items.Add(new ListViewItem(m2.Nazwa));
            //lista_monitor.Items.Add(new ListViewItem(m3.Nazwa));

            lista_monitor.View = View.Details;
            lista_monitor.Columns.Add("Nazwa", 150);
            lista_monitor.Columns.Add("Cena", 100);

            // Dodanie elementów z nazwą i ceną
            lista_monitor.Items.Add(new ListViewItem(new string[] { m1.Nazwa, m1.Cena.ToString("F2") + " zł" }));
            lista_monitor.Items.Add(new ListViewItem(new string[] { m2.Nazwa, m2.Cena.ToString("F2") + " zł" }));
            lista_monitor.Items.Add(new ListViewItem(new string[] { m3.Nazwa, m3.Cena.ToString("F2") + " zł" }));

            // Dodanie eventu do obsługi zmiany wyboru
            lista_monitor.SelectedIndexChanged += lista_monitor_SelectedIndexChanged;

        }

        private void okejka_monitor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cena_monitor.Text))
            {
                // Usuwamy "Cena: " i " zł", aby dostać samą liczbę
                string cenaStr = cena_monitor.Text.Replace("Cena: ", "").Replace(" zł", "");

                double cena;
                if (double.TryParse(cenaStr, out cena))
                {
                    PrzekazWartosc?.Invoke(cena);
                }
                else
                {
                    MessageBox.Show("Błąd: Niepoprawna cena!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }


        private void lista_monitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista_monitor.SelectedItems.Count > 0)
            {
                cena_monitor.Text = "Cena: " + lista_monitor.SelectedItems[0].SubItems[1].Text;
                
            }
        }
    }

    public class Monitory
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public Monitory(string nazwa, double cena)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
        }
        public override string ToString()
        {
            return Nazwa;
        }
    }

}
