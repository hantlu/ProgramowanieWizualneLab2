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
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KomputerPrzycisk_Click(object sender, EventArgs e)
        {
            Komputer komputer = new Komputer();
            komputer.Show();
        }

        private void MonitorKlik_Click(object sender, EventArgs e)
        {

        }
    }
}
