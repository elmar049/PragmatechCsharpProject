﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFlat
{
    public partial class Form1 : Form
    {
        private Button currentbutton;
        private Random random;
        private int tempindex;
        public Form1()
        {
            InitializeComponent();
        }
        
        private Color selectthemcolor()
        {
            int index=random.Next(ColorChanger.ColorChangerColors.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
