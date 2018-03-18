using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinXp
{
    public partial class Form1 : Form
    {
        int x = 0, dx = 2, y = 0, dy = 2;


        public Form1()
        {
            InitializeComponent();
           
            label1.Location = new Point(0, 150);
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(x + label1.Width > Width - 10)
            {
                dx *= -1;
            }
            else if (label1.Location.X + dx < 0)
            {
                dx *= -1;
            }
            x += dx;
            /////
            if (y + label1.Height > Height - 35)
            {
                dy *= -1;
            }
            else if (label1.Location.Y + dy < 0)
            {
                dy *= -1;
            }
            y += dy;

            label1.Location = new Point(x, y);
        }

    }
}
