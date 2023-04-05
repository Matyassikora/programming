using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorSikora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }



        int num1;
        int num2;
        string znamenko;

        // +
        private void button11_Click(object sender, EventArgs e)
        {            
            num1 = int.Parse(txt.Text);
            txt.Clear();
            znamenko = "1";
        }
        // -
        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt.Text);
            txt.Clear();
            znamenko = "2";
        }
        // *
        private void button13_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt.Text);
            txt.Clear();
            znamenko = "3";
        }
        // /
        private void button14_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt.Text);
            txt.Clear();
            znamenko = "4";
        }          


        // =
        private void button15_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txt.Text);
            int vysledek;
            if (znamenko == "1")
            {
                vysledek = num1 + num2;
                txt.Text = num1 + " + " + num2 + " = " + vysledek;
            }
            if (znamenko == "2")
            {
                vysledek = num1 - num2;
                txt.Text = num1 + " - " + num2 + " = " + vysledek;
            }
            if (znamenko == "3")
            {
                vysledek = num1 * num2;
                txt.Text = num1 + " * " + num2 + " = " + vysledek;
            }
            if (znamenko == "4")
            {
                vysledek = num1 / num2;
                txt.Text = num1 + " / " + num2 + " = " + vysledek;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }
    }
}
