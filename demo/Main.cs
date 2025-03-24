using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        public int resul1;
        public int resul2; 
        public int op;
        public int resulTotal;

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                resul1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                op = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                resul1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                op = 2;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                resul1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                op = 3;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                resul1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                op = 4;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resul2 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";

            switch (op)
            {
                case 1:
                    resulTotal = resul1 + resul2;
                    break;
                case 2:
                    resulTotal = resul1 - resul2;
                    break;
                case 3:
                    resulTotal = resul1 * resul2;
                    break;
                case 4:
                    resulTotal = resul1 / resul2;
                    break;
            }
            textBox1.Text = resulTotal.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resulTotal = 0;
            resul1 = 0;
            resul2 = 0;
            textBox1.Text = "";
        }
    }
}
