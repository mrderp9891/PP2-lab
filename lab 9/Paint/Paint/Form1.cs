using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point StartPoint = new Point(0, 0);
        Point ep = new Point(0, 0);
        bool k = false;
        bool kuk = true;
        bool bub = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
            k = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            k = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (k)
            {
                ep = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(p, StartPoint, ep);
            }
            if(kuk)
            StartPoint = ep;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Panel pan = sender as Panel;

            Def1.BackColor = pan.BackColor;
            p.Color = Def1.BackColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value / 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;

            this.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnt++;
            if(cnt % 2 != 0)
            {
                kuk = false;
                label1.Visible = true;
            }
            else
            {
                kuk = true;
                label1.Visible = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bub)
            {
                if (q.Location.X < 50)
                {
                    q.Visible = false;
                }
                if (q.Location.X < ep.X && q.Location.Y > ep.Y)
                {
                    q.Location = new Point(q.Location.X - 2, q.Location.Y + 2);
                }
                else if (q.Location.X > ep.X && q.Location.Y < ep.Y)
                {
                    q.Location = new Point(q.Location.X + 2, q.Location.Y - 2);
                }
                else if (q.Location.X > ep.X && q.Location.Y > ep.Y)
                {
                    q.Location = new Point(q.Location.X + 2, q.Location.Y + 2);
                }
                else if (q.Location.X < ep.X && q.Location.Y < ep.Y)
                {
                    q.Location = new Point(q.Location.X - 2, q.Location.Y - 2);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            q.Visible = true;
            bub = true;
            label2.Visible = true;
            label2.Text = "X\nX\nX\nX\nX\nX\nX\nX\nX\nX";
        }

        
    }
}
