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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             Input = double.Parse(textBox1.Text);
            }
            catch
            {
                Input = double.PositiveInfinity
            }
             double Answer = 1.0 / (1.0 / Input + 1.0 / Input2 + 1.0 / Input3);
            label1.Text = Answer.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
