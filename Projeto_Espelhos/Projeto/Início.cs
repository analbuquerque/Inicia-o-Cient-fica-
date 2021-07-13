using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramaPrincipal entrada = new ProgramaPrincipal();
            entrada.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLentes entrada2 = new FormLentes();
            entrada2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string credito="";
            credito="Feitos por Ana Beatriz Alburquerque & Bianca Santana";
            MessageBox.Show(credito);
        }
    }
}
