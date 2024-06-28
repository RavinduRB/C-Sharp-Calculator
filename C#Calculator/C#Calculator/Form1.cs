using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int sum = num1 + num2;

            label1.Text = $"{sum}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int abs = num1 - num2;

            label1.Text = $"{abs}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int mul = num1 * num2;

            label1.Text = $"{mul}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            if (num2 != 0)
            {
                int div = num1 / num2;
                label1.Text = $"{div}";
            }
            else
            {
                label1.Text = "E";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
