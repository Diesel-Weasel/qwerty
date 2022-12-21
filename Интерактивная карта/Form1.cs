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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }
    }
}
