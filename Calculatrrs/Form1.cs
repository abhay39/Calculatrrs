using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrrs
{
    public partial class Form1 : Form
    {
        Double resultvalue=0;
        String actionperformed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
           textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            actionperformed = button.Text;
            resultvalue = Double.Parse(textBox1.Text);
            vallb.Text = resultvalue + " " + actionperformed;
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text ="0";
            resultvalue = 0;
            vallb.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (actionperformed)
            {
                case "+":
                    vallb.Text = (resultvalue + Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = vallb.Text;
                    break;
                case "-":
                    vallb.Text = (resultvalue - Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = vallb.Text;
                    break;
                case "*":
                    vallb.Text = (resultvalue * Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = vallb.Text;
                    break;
                case "/":
                    vallb.Text = (resultvalue / Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = vallb.Text;
                    break;
                default:
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
