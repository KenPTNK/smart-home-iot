using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Iot_HMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button_1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_1.Visible = true;
            button2.Visible = true;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            button_1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_1.Visible = true;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double delta, x1, x2;
            float a, b, c;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = float.Parse(textBox3.Text);
            delta = b * b - 4 * a * c;
            if (delta < 0)
                textBox4.Text = "vô nghiệm";
            else if (delta == 0)
            {
                textBox4.Text = "phương trình có nghiệm kép";
                x1 = x2 = -b / (2 * a);
                label3.Text = x1.ToString();
                label4.Text = x2.ToString();
            }
            else
            {
                textBox4.Text = "phương trình có 2 nghiệm";
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                label3.Text = x1.ToString();
                label4.Text = x2.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
