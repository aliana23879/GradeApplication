using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, d, z, ave, dec;
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox3.Text);
                c = double.Parse(textBox4.Text);
                d = double.Parse(textBox5.Text);
                z = double.Parse(textBox6.Text);

                ave = (a + b + c + d + z) / 5;
                dec = Math.Round(ave, 2);
                // this will convert the average into two decimal places

                if (dec >= 75) // if the average is equal or greater than 75,the student passed.
                {
                    label9.Text = "The student passed.";
                }
                else if (dec < 75) // if the average is lesser than 75, the student failed.
                {
                    label9.Text = "The student failed.";
                }
                label8.Text = "The general average of " + textBox1.Text;
                label10.Text = "        is " + dec + ".";
            }
            catch (FormatException ) { // Format Exception incase the user will input invalid data type
                label9.Text = "Invalid Input!";
                label8.Text = "            There is no general average.";
                label10.Text = "Program Stopped!";
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
