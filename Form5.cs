using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double resultat;
            double rost;
            double ves;
            double voz;
            double sid, mal, sre, sil, max;


            rost = Convert.ToDouble(textBox1.Text);
            ves = Convert.ToDouble(textBox2.Text);
            voz = Convert.ToDouble(textBox3.Text);

            rost = rost * 6.25;
            ves = ves * 9.99;
            voz = voz * 4.92;
            resultat = ves + rost - voz;

            if (button1.Enabled == true)
            {
                resultat = resultat + 5;
                label23.Text = resultat.ToString("N");

                sid = resultat * 1.2;
                mal = resultat * 1.375;
                sre = resultat * 1.55;
                sil = resultat * 1.725;
                max = resultat * 1.9;

                label18.Text = sid.ToString("N");
                label19.Text = mal.ToString("N");
                label20.Text = sre.ToString("N");
                label21.Text = sil.ToString("N");
                label22.Text = max.ToString("N");
            }
            else if (button2.Enabled == true)
            {
                resultat = resultat - 161;
                label23.Text = resultat.ToString("N");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label23.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
        }

        private void label23_Click(object sender, EventArgs e)
        {
            label23.Text = "";
        }
    }
}
