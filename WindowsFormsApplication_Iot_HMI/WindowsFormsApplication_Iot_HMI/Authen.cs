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
    public partial class Authen : Form
    {
        public Authen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username_input = user_text.Text;
            string pass_input = pass_text.Text;
            if (username_input == "ken" && pass_input == "123")
            {    this.Visible = false;
                Form1 f1 = new Form1();
                f1.Show();
            }
            else{
                MessageBox.Show("Please Try Again");
            }
        }
    }
}
