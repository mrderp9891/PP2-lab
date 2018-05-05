using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final3
{
    public partial class Form1 : Form
    {
        int cnt = 1;
        List<Button> b = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 9; i++)
            {
                b.Add(new Button());
            }
            for(int i = 0; i < b.Count; i++)
            {
                b[i].Name = "b" + i;
                b[i].Font = new Font("OCRA", 40);
                b[i].Width = 100;
                b[i].Height = 100;
                b[i].Click += new System.EventHandler(button1_Click);
                Controls.Add(b[i]);
                
                
            }
            b[0].Location = new Point(0, 0);
            b[1].Location = new Point(100, 0);
            b[2].Location = new Point(200, 0);
            b[3].Location = new Point(0, 100);
            b[4].Location = new Point(100, 100);
            b[5].Location = new Point(200, 100);
            b[6].Location = new Point(0, 200);
            b[7].Location = new Point(100, 200);
            b[8].Location = new Point(200, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(cnt % 2 == 0)
            {
                btn.Text = "O";
                cnt++;
            }
            else
            {
                btn.Text = "X";
                cnt++;
            }
            btn.Enabled = false;
            //xX
            if (b[0].Text == "X" && b[1].Text == "X" && b[2].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            if (b[3].Text == "X" && b[4].Text == "X" && b[5].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            if (b[6].Text == "X" && b[7].Text == "X" && b[8].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            //yX
            if (b[0].Text == "X" && b[3].Text == "X" && b[6].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            if (b[1].Text == "X" && b[4].Text == "X" && b[7].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            if (b[2].Text == "X" && b[5].Text == "X" && b[8].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            /////X////

            if (b[0].Text == "X" && b[4].Text == "X" && b[8].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            if (b[2].Text == "X" && b[4].Text == "X" && b[6].Text == "X")
            {
                MessageBox.Show("Game Over");
            }
            //xO
            if (b[0].Text == "O" && b[1].Text == "O" && b[2].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            if (b[3].Text == "O" && b[4].Text == "O" && b[5].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            if (b[6].Text == "O" && b[7].Text == "O" && b[8].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            //yO
            if (b[0].Text == "O" && b[3].Text == "O" && b[6].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            if (b[1].Text == "O" && b[4].Text == "O" && b[7].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            if (b[2].Text == "O" && b[5].Text == "O" && b[8].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            /////O////

            if (b[0].Text == "O" && b[4].Text == "O" && b[8].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
            if (b[2].Text == "O" && b[4].Text == "O" && b[6].Text == "O")
            {
                MessageBox.Show("Game Over");
            }
        }

        
    }
}
