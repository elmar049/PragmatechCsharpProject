using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoCallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int left = 30;

            List<string> clickes = new List<string>();
            clickes.Add("Tebiyet");
            clickes.Add("Auto");
            clickes.Add("Human");

            List<string> photos = new List<string>() {

                "demo/02.JPG",
                "demo/1.jpg",
                "demo/03.jpg",

            };
            jj
            foreach (string click in clickes)
            {
                Button label = new Button();
                label.Text = click;
                label.Top = 30;
                label.Left = left;
                left += label.Width;
                this.Controls.Add(label);
            }

            foreach (string photo in photos)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(@"C:\Users\elmar\Desktop\demo\1.jpg");
                pictureBox.Top = 80;
                pictureBox.Height = 300;
                pictureBox.Width = 300;
                pictureBox.Left = left;
                left += 150;
                this.Controls.Add(pictureBox);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //string path = openFileDialog1.FileName;
            //pictureBox1.Image = Image.FromFile(path);  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
