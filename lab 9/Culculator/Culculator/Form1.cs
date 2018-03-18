using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Culculator
{
    public partial class Form1 : Form
    {
        double fn = 0;
        double sn = 0;
        double res = 0;
        string operation = "";
        bool opclicked = false;
        bool snbool = false;
        double meme = 0;
        int cnt = 1;
        

        public Form1()
        {
            InitializeComponent();

        }
        //numbers
        private void numbers_click(object sender, EventArgs e)
        {
            if(opclicked == true)
            {
                display.Text = "";
                opclicked = false;
            }
            if(display.Text == "0")
            {
                display.Text = "";
            }
            Button btn = sender as Button;
            display.Text += btn.Text; 
        }
        //+-*/
        private void operations_Click(object sender, EventArgs e)
        {
            opclicked = true;
            Button btn = sender as Button;
            if(display.Text != "")
            {
                fn = double.Parse(display.Text);
                operation = btn.Text.ToString();
            }
            else
            {

            }
        }
        //=
        private void button4_Click(object sender, EventArgs e)
        {
            
            sn = double.Parse(display.Text);
           
            switch (operation)
            {
                case "+":
                    res = fn + sn;
                    display.Text = res.ToString();
                    break;
                case "-":
                    res = fn - sn;
                    display.Text = res.ToString();
                    break;
                case "x":
                    res = fn * sn;
                    display.Text = res.ToString();
                    break;
                case "/":
                    if(sn == 0)
                    {
                        display.Text = "Error";
                        break;
                    }
                    res = fn / sn ;
                    display.Text = res.ToString();
                    break;
                case "Mod":
                    res = fn % sn;
                    display.Text = res.ToString();
                    break;
                case "xY":
                    res = Math.Pow(fn, sn);
                    display.Text = res.ToString();
                    break;
                case "x*1/y":
                    res = fn * (1 / sn);
                    display.Text = res.ToString();
                    break;
                /*case "log":
                    res = fn * (Math.Log(sn));
                    display.Text = res.ToString();
                    break;*/
            }

            if (!snbool)
            {
                fn = sn;
            }
            snbool = true;
        }
        //+-
        private void button1_Click(object sender, EventArgs e)
        {
            if(display.Text != "")
            {
                if(double.Parse(display.Text) > 0)
                {
                    display.Text = "-" + display.Text;
                }
                else if (double.Parse(display.Text) < 0)
                {
                    display.Text = (Math.Sqrt(Math.Pow(double.Parse(display.Text), 2))).ToString();
                }
                    
            }
        }
        //,
        private void button3_Click(object sender, EventArgs e)
        {
            string s = display.Text;
            bool b = false;
            for(int i = 0; i < s.Length; i++)
            {
                if (!s.Contains(","))
                {
                    b = true;
                    break;
                }
            }
            if(b == true)
            {
                display.Text = display.Text + ",";
            }
        }
        //backspace
        private void button18_Click(object sender, EventArgs e)
        {
            if(display.Text.Length == 2 && double.Parse(display.Text) <= 0)
            {
                display.Text = "0";
            }
            else if (display.Text.Length == 1 || display.Text == "-0,")
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
        }

        //C
        private void button19_Click(object sender, EventArgs e)
        {
            fn = 0;
            sn = 0;
            res = 0;
            display.Text = "0";
        }
        //CE
        private void button20_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            
        }
        //√  x2  1/x
        public void sqrt_pow2_1devx(object sender, EventArgs e)
        {
            Button btn = sender as Button; switch (btn.Text)
            {
                case "√":
                    display.Text = (Math.Sqrt(double.Parse(display.Text))).ToString();
                    break;
                case "x2":
                    display.Text = (Math.Pow(double.Parse(display.Text), 2)).ToString();
                    break;
                case "1/x":
                    display.Text = (1 / (double.Parse(display.Text))).ToString();
                    break;
                case "SCIENTIFIC":
                    Width = 590;
                    display.Width = 555;
                    btn.Text = "STANDART";
                    break;
                case "STANDART":
                    Width = 400;
                    display.Width = 368;
                    btn.Text = "SCIENTIFIC";
                    break;
                case "eX":
                    display.Text = (Math.Exp(double.Parse(display.Text))).ToString();
                    break;
                case "log":
                    display.Text = (Math.Log10(double.Parse(display.Text))).ToString();
                    break;
                case "sin":
                    display.Text = (Math.Sin(double.Parse(display.Text))).ToString();
                    break;
                case "cos":
                    display.Text = (Math.Cos(double.Parse(display.Text))).ToString();
                    break;
                case "tan":
                    display.Text = (Math.Tan(double.Parse(display.Text))).ToString();
                    break;
                case "10x":
                    if(double.Parse(display.Text) > 0)
                    {
                        string ten = "1";
                        for (int i = 0; i < int.Parse(display.Text); i++)
                        {
                            ten = ten + "0";
                        }
                        display.Text = ten;
                        break;
                    }
                    else if (double.Parse(display.Text) < 0)
                    {
                        string mten = "0,";
                        for(int i = 0; i < int.Parse(display.Text)*-1 - 1; i++)
                        {
                            mten += "0";
                        }
                        mten += "1";
                        display.Text = mten;
                        break;
                    }
                    else
                    {
                        display.Text = "1";
                        break;
                    }
                    
            }


        }
        //%
        private void button24_Click(object sender, EventArgs e)
        {
            sn = double.Parse(display.Text);
            if(sn == 0)
            {
                display.Text = "0";
            }
            sn = double.Parse(display.Text);
            switch (operation)
            {
                case "+":
                    res = (sn / 100) * fn;
                    display.Text = res.ToString();
                    break;
                case "-":
                    res = (sn / 100) * fn;
                    display.Text = res.ToString();
                    break;
                case "x":
                    res = (sn/100)*fn;
                    display.Text = res.ToString();
                    break;
                case "/":
                    if (sn == 0)
                    {
                        display.Text = "Error";
                        break;
                    }
                    res = (sn/100)*fn;
                    display.Text = res.ToString();
                    break;
            }
        }
        //Mem
        public void Mem(object sender, EventArgs e)
        {
            //Label lab = new Label(); 
            
            Button btn = sender as Button;
            if(btn.Text == "MC")
            {
                meme = 0;
                File.WriteAllText(@"D:\text\Meme.txt", "0");
            }
            if(btn.Text == "MR")
            {
                display.Text = meme.ToString();
            }
            if (btn.Text == "M+")
            {
                meme += double.Parse(display.Text);
                File.WriteAllText(@"D:\text\Meme.txt", meme.ToString());
                button28.Enabled = true;
                button25.Enabled = true;
                button27.Enabled = true;
            }
            if (btn.Text == "M-")
            {
                meme -= double.Parse(display.Text);
                File.WriteAllText(@"D:\text\Meme.txt", meme.ToString());
                button28.Enabled = true;
                button25.Enabled = true;
                button27.Enabled = true;
            }
            if (btn.Text == "MS")
            {
                File.WriteAllText(@"D:\text\Meme2.txt", display.Text);
                button28.Enabled = true;
                button25.Enabled = true;
                button27.Enabled = true;
            }
        }
        //mem^
        private void button27_Click(object sender, EventArgs e)
        {
            FormM fm = new FormM();
            fm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\text\Meme.txt", "0");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            display.Text = Math.PI.ToString();
        }
        //backcolor
        private void button36_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                BackColor = Color.LightSteelBlue;
                cnt++;
            }
            else if (cnt == 2)
            {
                BackColor = Color.MistyRose;
                cnt++;
            }
            else if (cnt == 3)
            {
                BackColor = Color.PaleTurquoise;
                cnt++;
            }
            else if (cnt == 4)
            {
                BackColor = Color.White;
                cnt = 1;
            }
        }
    }
}
