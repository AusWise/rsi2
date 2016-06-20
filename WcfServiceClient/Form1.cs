using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfServiceClient
{
    public partial class Form1 : Form
    {

        ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
        ServiceReference2.Service2Client service2 = new ServiceReference2.Service2Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            double x = Double.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);

            try
            {
                double power = service1.Power(x, n);

                textBox1.AppendText("Power(" + x + ", " + n + ") = " + power);
                textBox1.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox1.AppendText(ex.Message);
                textBox1.AppendText("\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox4.Text);
            try
            {
            int fibonacci = service1.Fibonacci(n);

            textBox1.AppendText("Fibonacci(" + n + ") = " + fibonacci);
            textBox1.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox1.AppendText(ex.Message);
                textBox1.AppendText("\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox5.Text);
try{
            int factorial = service1.Factorial(n);

            textBox1.AppendText("Factorial(" + n + ") = " + factorial);
            textBox1.AppendText("\n");
}
            catch (Exception ex)
            {
                textBox1.AppendText(ex.Message);
                textBox1.AppendText("\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            string target = textBox7.Text;
            int fromIndex = int.Parse(textBox8.Text);
try{
            int indexOf = service2.IndexOf(text, target, fromIndex);

            textBox1.AppendText("IndexOf(" + text +  ", " + target + ", " + fromIndex + ") = " + indexOf);
            textBox1.AppendText("\n");
}
            catch (Exception ex)
            {
                textBox1.AppendText(ex.Message);
                textBox1.AppendText("\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = textBox9.Text;
            string target = textBox10.Text;
            string replacement = textBox11.Text;
try{
            string replace = service2.Replace(text, target, replacement);

            textBox1.AppendText("Replace(" + text + ", " + target + ", " + replacement + ") = " + replace);
            textBox1.AppendText("\n");
}
            catch (Exception ex)
            {
                textBox1.AppendText(ex.Message);
                textBox1.AppendText("\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
