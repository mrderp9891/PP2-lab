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
    public partial class FormM : Form
    {
        public FormM()
        {
            InitializeComponent();
        }

        private void FormM_Load(object sender, EventArgs e)
        {
          
            label1.Text = File.ReadAllText(@"D:\text\Meme.txt");
            label2.Text = File.ReadAllText(@"D:\text\Meme2.txt");

        }
    }
}
