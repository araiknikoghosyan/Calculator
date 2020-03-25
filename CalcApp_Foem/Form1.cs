using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp_Foem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Sub(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        private void Divade_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Divade_(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        static double Divade_(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("На ноль делить нелзья");
            }
            return a / b;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            if (label1.Text != null && textBox1.Text != null && textBox2 != null)
            {
                label1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void Fact_button_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Fact(Convert.ToDouble(textBox1.Text)));
        }
        static double Fact(double d)
        {
            return d == 0 ? 1 : d * Fact(d - 1);
        }

        private void Fibo_button_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Fibo(Convert.ToDouble(textBox1.Text)));
        }
        static double Fibo(double d)
        {
            return d <= 2 ? 1 : Fibo(d - 1) + Fibo(d - 2);
        }

        private void Pow_button_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

        private void Sqrt_Button_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        static double Sqrt(double d)
        {
            return Math.Sqrt(d);
        }
    }
}
