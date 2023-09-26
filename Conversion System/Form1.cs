using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hex_btn_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(txtConverter.Text);
            lblBinary.Text = dec.ToString("x");
        }

        private void dec_btn_Click(object sender, EventArgs e)
        {
            string hex = txtConverter.Text;
            int dec = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            lblBinary.Text = dec.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblBinary.Text = "";
            lblDecimal.Text = "";
            lblHex.Text = "";
            txtConverter.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hex_btn_Click_1(object sender, EventArgs e)
        {
            int numconverter = int.Parse(txtConverter.Text);
            lblBinary.Text = Convert.ToString(numconverter, 2);
            lblDecimal.Text = numconverter.ToString();
            lblHex.Text = Convert.ToString(numconverter, 16);
        }

        private void txtConverter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}