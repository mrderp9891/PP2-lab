using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Final4
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        int x;
        int y;
        int c;
        string[] color = { "Red", "Green", "Blue", "Black", "Yellow", "Pink" };
        Random rnd = new Random();

        List<Label> l = new List<Label>();
        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                l.Add(new Label());
            }

            for (int i = 0; i < l.Count; i++)
            {
                c = rnd.Next(0, color.Length);
                x = rnd.Next(0, Width - 50);
                y = rnd.Next(-1000, -50);
                l[i].Location = new Point(x, y);
                l[i].Width = 40;
                l[i].Height = 40;
                l[i].BackColor = Color.FromName(color[c]);
                l[i].Click += new System.EventHandler(this.label1_Click);
                Controls.Add(l[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = cnt.ToString();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].BackColor == Color.Red && l[i].Visible == true && l[i].Location.Y > 400)
                {
                    timer1.Stop();
                    label3.Visible = true;
                }
                l[i].Location = new Point(l[i].Location.X, l[i].Location.Y + 4);
                if(l[i].Location.Y > Height)
                {
                    
                    c = rnd.Next(0, color.Length);
                    x = rnd.Next(0, Width - 50);
                    y = rnd.Next(-1000, -10);
                    l[i].Location = new Point(x, y);
                    l[i].BackColor = Color.FromName(color[c]);
                   
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lab = sender as Label;
            if (lab.BackColor == Color.Red)
            {
                lab.Visible = false;
                cnt++;
            }
            
        }
    }
}
