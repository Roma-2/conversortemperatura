using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversortemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float C = float.Parse(textBox2.Text);
            float F = (C * 9f / 5f) + 32;
            textBox2.Text = F.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float f = float.Parse(textBox1.Text);
            float c = (f - 32) * 5.0F / 9.0F;

            textBox2.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.0";
            textBox2.Text = "0.0";
        }
    }
}
