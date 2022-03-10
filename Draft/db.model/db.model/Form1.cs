using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var v = new Form2();
            v.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x=textBox1.Text;
            melumat.XXX = x;
        }
    }
}
