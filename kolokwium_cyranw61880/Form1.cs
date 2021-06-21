using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolokwium_cyranw61880
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
               textBox1.ForeColor = Color.Red;
            }
            if(radioButton2.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if(radioButton3.Checked)
            {
                textBox1.ForeColor = Color.Green;
            }

            if(checkBox2.Checked)
            {
                textBox1.Font = new Font("Arial ", 24);
              
            }

            if(checkBox1.Checked)
            {
                textBox1.Font = new Font("Arial", 10);
            }
            if(checkBox3.Checked)
            {
                textBox1.Font = new Font("Arial", 48);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "";
            }
            if (radioButton2.Checked)
            {
                textBox1.Text = "";
            }
            if (radioButton3.Checked)
            {
                textBox1.Text = "";
            }
            if (checkBox1.Checked)
            {
                textBox1.Text = "";
            }
            if (checkBox2.Checked)
            {
                textBox1.Text = "";
            }
            if (checkBox3.Checked)
            {
                textBox1.Text = "";
            }

        }
    }
}
