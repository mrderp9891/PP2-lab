using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }
        int c = 0;

        private void button2_Click(object sender, EventArgs e)
        {
                
            if(c > 2)
            {
                c = 0;
            }
            if (c == 0)
            {
                button2.BackColor = Color.Red;
            }
            if (c == 1)
            {
                button2.BackColor = Color.Yellow;
            }
            if (c == 2)
            {
                button2.BackColor = Color.Blue;
            }
            c++;
                
                
            
        }
       
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                string s = "";
                label1.Text = s;
                int n = int.Parse(textBox1.Text);
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        s += i + " ";
                    }
                }
                label1.Text = s;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "";
            button4.Text = "==>";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "";
            button5.Text = "<==";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label2.Text = "==>";
        }
      

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "<==";
        }
    }
}
