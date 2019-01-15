using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Input, Input2, Input3, Input4, Input5;
            try
            {
                Input = double.Parse(textBox1.Text);
            }
            catch
            {
                Input = 0;
            }
            try
            {
                Input2 = double.Parse(textBox2.Text);
            }
            catch
            {
                Input2 = 0;
            }
            try
            {
                Input3 = double.Parse(textBox3.Text);
            }
            catch
            {
                Input3 = 0;
            }
            try
            {
                Input4 = double.Parse(textBox4.Text);
            }
            catch
            {
                Input4 = 0;
            }
            try
            {
                Input5 = double.Parse(textBox5.Text);
            }
            catch
            {
                Input5 = 0;
            }
            double Answer = Input + Input2 + Input3 + Input4 + Input5

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Input, Input2, Input3, Input4, Input5;
            try
            {
                Input = double.Parse(textBox1.Text);
            }
            catch
            {
                Input = double.PositiveInfinity;
            }
            try
            {
                Input2 = double.Parse(textBox2.Text);
            }
            catch
            {
                Input2 = double.PositiveInfinity;
            }
            try
            {
                Input3 = double.Parse(textBox3.Text);
            }
            catch
            {
                Input3 = double.PositiveInfinity;
            }
            try
            {
                Input4 = double.Parse(textBox4.Text);
            }
            catch
            {
                Input4 = double.PositiveInfinity;
            }
            try
            {
                Input5 = double.Parse(textBox5.Text);
            }
            catch
            {
                Input5 = double.PositiveInfinity;
            }
            double Answer = 1.0 / (1.0 / Input + 1.0 / Input2 + 1.0 / Input3 + 1.0 / Input4 + 1.0 / Input5 + 1.0 /);
            label1.Text = Answer.ToString();
        }
    }
}
