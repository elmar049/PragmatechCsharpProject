using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhotoCallery
{
    public partial class Form1 : Form
    {
        string RootPathFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();

        public Form1()
        {
            InitializeComponent();

            int left = 30;
           

            List<string> clickes = new List<string>();
            clickes.Add("Tebiyet");
            clickes.Add("Auto");
            clickes.Add("Human");

            List<string> photos = new List<string>() {

                "/demo/02.JPG",
                "/demo/1.jpg",
                "/demo/03.jpg",

            };
            
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
                pictureBox.Image = Image.FromFile($"{ RootPathFolder}{photo}");
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
            
            var OFD = new OpenFileDialog();
            OFD.ShowDialog();

            var RootPath = OFD.FileName;
            var DestinationPath = $"{RootPathFolder}/demo/";
            var NewNamw = new Random().Next(0, 1000);
            var GetExt=Path.GetExtension(RootPath);
            File.Copy(RootPath, $"{DestinationPath}{NewNamw}{GetExt}");


            pictureBox.Image = Image.FromFile($"{DestinationPath}{NewNamw}.{GetExt}");


            MessageBox.Show(OFD.FileName.ToString());


        }

       
    }
}
