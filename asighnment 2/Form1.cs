using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asighnment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double r1;

            try
            {
                r1 = double.Parse(textbox1.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r1 = 0.0;
                //this will crash if the value is not suitable.
            }
            double r2;

            try
            {
                r2 = double.Parse(textbox2.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r2 = 0.0;
                //this will crash if the value is not suitable.
            }
            double r3;

            try
            {
                r3 = double.Parse(textbox3.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r3 = 0.0;
                //this will crash if the value is not suitable.
            }
            Double tot1 = r1 + r2 + r3;
            label3.Text = "Total Resistance = " + tot1.ToString("N3") + " Ω";
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double r4;

            try
            {
                r4 = double.Parse(textBox4.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r4 = 0.0;
                //this will crash if the value is not suitable.
            }
            double r5;

            try
            {
                r5 = double.Parse(textBox5.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r5 = 0.0;
                //this will crash if the value is not suitable.
            }
            double r6;

            try
            {
                r6 = double.Parse(textBox6.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r6 = 0.0;
                //this will crash if the value is not suitable.
            }
            Double tot2 = (1 / ((1.0 / r4) + ((1.0 / r5) + (1.0 / r6))));
            label4.Text = "Total Resistance = " + tot2.ToString("N3") + " Ω";
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double r7;

            try
            {
                r7 = double.Parse(textBox9.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r7 = 0.0;
                //this will crash if the value is not suitable.
            }
            double r8;

            try
            {
                r8 = double.Parse(textBox10.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r8 = 0.0;
                //this will crash if the value is not suitable.
            }
            Double tot1 = (1 / ((1.0 / r7) + ((1.0 / r8) )));
            label6.Text = "Total Resistance = " + tot1.ToString("N3") + " Ω";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double r9;

            try
            {
                r9 = double.Parse(textBox7.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r9 = 0.0;
                //this will crash if the value is not suitable.
            }
            double r10;

            try
            {
                r10 = double.Parse(textBox8.Text);
                //this wwill convert the numbersin the textbox into a double variable
            }
            catch
            {
                MessageBox.Show("Not a correct value. ");
                r10 = 0.0;
                //this will crash if the value is not suitable.
            }
            Double tot1 = r9 + r10;
            label5.Text = "Total Resistance = " + tot1.ToString("N3") + " Ω";
        }
    }
}
           