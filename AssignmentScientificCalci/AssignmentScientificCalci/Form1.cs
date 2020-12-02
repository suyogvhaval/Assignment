using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentScientificCalci
{
    public partial class Form1 : Form
    {
        double no1, no2;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToInt32(textBox1.Text);

            switch (op)
            {



                case "+":
                    textBox1.Text = (no1 + no2).ToString();



                    break;

                case "-":
                    textBox1.Text = (no1 - no2).ToString();
                    break;
                case "*":
                    textBox1.Text = (no1 * no2).ToString();
                    break;
                case "/":
                    textBox1.Text = (no1 / no2).ToString();
                    break;



            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text) * (Math.PI / 180)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text) * (Math.PI / 180)).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text) * (Math.PI / 180)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Log10(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text= Math.Exp(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = (sender as Button).Text;
        }
    }
}
