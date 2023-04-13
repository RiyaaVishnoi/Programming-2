using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nclicks = Convert.ToInt16(textBox1.Text);
            nclicks = nclicks + 1;
            //this will show the value of nclick in the textbox as a string 
            textBox1.Text = Convert.ToString(nclicks);
            label1.Text = Convert.ToString(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "my text has changed";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //task 6
        private void button1_Click_1(object sender, EventArgs e)
        {
            //get all the numbers from the textboxes
            int num1 = Convert.ToInt16(textBox3.Text);
            int num2 = Convert.ToInt16(textBox4.Text);
            int num3 = Convert.ToInt16(textBox5.Text);
            int num4 = Convert.ToInt16(textBox6.Text);
            //add them up
            int sum = num1 + num2 + num3 + num4;
            //display them on a textbox
            textBox1.Text = (Convert.ToString(sum));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //get all the numbers from the textboxes
            int num1 = Convert.ToInt16(textBox3.Text);
            int num2 = Convert.ToInt16(textBox4.Text);
            int num3 = Convert.ToInt16(textBox5.Text);
            int num4 = Convert.ToInt16(textBox6.Text);

            // average them up
            int avg = (num1 + num2 + num3 + num4) / 2;
            //display them on a textbox
            textBox2.Text = (Convert.ToString(avg));
        }
    }
}
