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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "Бегун") && (textBox2.Text == "111"))
            {
                Form8 ff8 = new Form8();
                ff8.Show();
                this.Hide();
            }
            else
                if ((comboBox1.Text == "Координатор") && (textBox2.Text == "222"))
            {
                Form11 ff11 = new Form11();
                ff11.Show();
                this.Hide();
            }
            else
                if ((comboBox1.Text == "Администратор") && (textBox2.Text == "333"))
            {
                Form9 ff9 = new Form9();
                ff9.Show();
                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            ff1.Show();
            this.Hide();
        }
    }
}
