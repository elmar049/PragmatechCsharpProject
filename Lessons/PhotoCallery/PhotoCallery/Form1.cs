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
using PhotoCallery;



namespace PhotoCallery
{
    public partial class Form1 : Form
    {
        int left = 30;
        int top = 5;
        string RootPathFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
        PhotoCalleryEntities db = new PhotoCalleryEntities();
        int FindRightIndex;
        int FindRightIndex2;
        int selectedtodelete;


        public void ComboList()
        {

            var comboboxlist = new List<string>();
            foreach (var category in db.Categories.ToList())
            {
                comboboxlist.Add(category.CategoryName);

            }

            comboBox.DataSource = comboboxlist;
            ComboxobTodeleteCategory.DataSource = comboboxlist;

        }
        public void InsertingPhotoToPanel(string fullyname, string pcbName)
        {
            var pcb = new PictureBox();
            pcb.Image = Image.FromFile(fullyname);
            pcb.Top = top;
            pcb.Width = Image.FromFile(fullyname).Width / 10;
            pcb.Height = Image.FromFile(fullyname).Height / 10;
            pcb.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb.Left = left;
            left += pcb.Width + 20;
            panel1.Controls.Add(pcb);
            pcb.Name = pcbName;
            pcb.Click += ClickinOnPhoto;




            //for (int y = 0; y < panel1.Controls.Count; y++)
            //{
            //    if (panel1.Controls.Count % 4 == 0)
            //    {

            //        left = 0;
            //        top += 170;

            //    }

            //}


        }

        private void ClickinOnPhoto(object sender, EventArgs e)
        {
            PictureBox px = sender as PictureBox;
            Button btn = new Button();

            foreach (var x in db.Photos.ToList())
            {
                if (px.Name == x.fileNamee)
                {
                    selectedtodelete = x.id;
                }

            }

            btn.Text = "X";
            btn.Width = 20;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
            btn.Click += deletionPhotoo;
            btn.Click += Clickoncategory;
            px.Controls.Add(btn);

            //MessageBox.Show("If You want to delete a photo Click twice red Cross");

        }

        private void deletionPhotoo(object sender, EventArgs e)
        {
            var btn = sender as Button;

            foreach (var x in db.Photos.ToList())
            {
                var a = $"{RootPathFolder}/{x.fileLocation}";
                if (x.id == selectedtodelete)
                {
                    db.Photos.Remove(x);
                    //File.Delete(a);
                    db.SaveChanges();
                }

            }
            btn.Click += Clickoncategory;



        }

        public object AddingPhoto(DateTime daatetime, long FileSize, string FileLocation, string GetExt, int NewNamw)
        {
            var PhotoFileExample = new Photos() {
                fileNamee = $"{NewNamw}{GetExt}",
                fileAddDate = daatetime,
                fileSize = FileSize,
                fileExtention = GetExt,
                fileLocation = $"demo/{FileLocation}",
                fileCategoryId = FindRightIndex

            };
            db.Photos.Add(PhotoFileExample);
            db.SaveChanges();
            return PhotoFileExample;

        }
        public void AddingCategoryToPane()
        {
            int left2 = 30;
            foreach (var click in db.Categories.ToList())
            {
                Button label = new Button();
                label.Text = click.CategoryName;
                label.Top = 20;
                label.Left = left2;
                left2 += label.Width + 20;
                panelForCategories.Controls.Add(label);
               
                label.Click += Clickoncategory;

            }
        }



        public Form1()
        {
            InitializeComponent();
            ComboList();
            AddingCategoryToPane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var click in db.Categories.ToList())
                if (comboBox.SelectedItem.ToString() == click.CategoryName)
                {
                    FindRightIndex = click.id;
                }



            var OFD = new OpenFileDialog();
            OFD.ShowDialog();

            var RootPath = OFD.FileName;
            var DestinationPath = $"{RootPathFolder}/demo/";
            var NewNamw = new Random().Next(0, 1000);
            var GetExt = Path.GetExtension(RootPath);
            DateTime daatetime = DateTime.Now;
            var FileSize = new FileInfo(RootPath).Length;
            var FileLocation = $"{NewNamw}{GetExt}";
            var FullnewName = DestinationPath + NewNamw + GetExt;
            File.Copy(RootPath, $"{DestinationPath}{NewNamw}{GetExt}");


            AddingPhoto(daatetime, FileSize, FileLocation, GetExt, NewNamw);
            InsertingPhotoToPanel(FullnewName, FileLocation);

        }


        private void category_button_Click(object sender, EventArgs e)
        {
            var insertedCategory = category_text.Text;
            var newCateg = new Categories() {
                CategoryName = insertedCategory,
            };

            db.Categories.Add(newCateg);
            db.SaveChanges();
            panelForCategories.Controls.Clear();
            AddingCategoryToPane();
            ComboList();

        }
        public void Clickoncategory(object sender, EventArgs e)
        {

            var btn = sender as Button;
            foreach (var category in db.Categories.ToList())
            {
                if (category.CategoryName == btn.Text)
                {
                    FindRightIndex = category.id;

                }
            }


            var SelectedPhotos = new List<Photos>();
            foreach (var photo in db.Photos.ToList())
            {
                if (FindRightIndex == photo.fileCategoryId)
                {
                    SelectedPhotos.Add(photo);

                }
            }

            panel1.Controls.Clear();
            left = 30;
            foreach (var photo in SelectedPhotos)
            {
                string fullynewname = $"{RootPathFolder}/{photo.fileLocation}";  //zdes ya demo uubral slovo
                string justnewnam = photo.fileNamee;
                InsertingPhotoToPanel(fullynewname, justnewnam);



            }


        }


        private void showTheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int left2 = 30;
            List<double> phtosize = new List<double>();
            List<Photos> phtosize2 = new List<Photos>();


            foreach (var photo in db.Photos.ToList())
            {
                var a = Convert.ToDouble(photo.fileSize);
                phtosize.Add(a);
            }

            for (int o = 0; o < 5; o++)
            {
                phtosize.Sort();
                phtosize.Reverse();

                foreach (var photo in db.Photos.ToList())
                {
                    if (photo.fileSize == phtosize[o])
                    {
                        phtosize2.Add(photo);
                    }
                }

            }

            foreach (var photo in phtosize2)
            {


                var pcb = new PictureBox();
                string fullyname = $"{RootPathFolder}/demo/{photo.fileNamee}";
                pcb.Image = Image.FromFile(fullyname);
                pcb.Top = top;
                pcb.Width = Image.FromFile(fullyname).Width / 10;
                pcb.Height = Image.FromFile(fullyname).Height / 10;
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Left = left2;
                left2 += pcb.Width + 20;
                panel1.Controls.Add(pcb);



            }



        }

        private void show5LastUploadedPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int left3 = 30;
            List<DateTime> dtm = new List<DateTime>();
            List<Photos> dtm2 = new List<Photos>(5);


            foreach (var photo in db.Photos.ToList())
            {
                var a = photo.fileAddDate.GetValueOrDefault();
                dtm.Add(a);

            }


            for (int o = 0; o < 5; o++)
            {
                dtm.Sort();
                dtm.Reverse();

                foreach (var photo in db.Photos.ToList())
                {

                    if (photo.fileAddDate == dtm[o])
                    {
                        dtm2.Add(photo);

                    }
                }

            }



            foreach (var photo in dtm2)
            {


                var pcb = new PictureBox();
                string fullyname = $"{RootPathFolder}/demo/{photo.fileNamee}";
                pcb.Image = Image.FromFile(fullyname);
                pcb.Top = top;
                pcb.Width = Image.FromFile(fullyname).Width / 10;
                pcb.Height = Image.FromFile(fullyname).Height / 10;
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Left = left3;
                left3 += pcb.Width + 20;
                panel1.Controls.Add(pcb);

                MessageBox.Show(photo.fileAddDate.ToString());


            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showPhotosWithjpgExtentionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int left4 = 30;

            List<string> phtosize = new List<string>() { ".JPG", ".jpg", ".Jpg" };
            List<Photos> phtosize2 = new List<Photos>();





            foreach (var str in phtosize)
            {
                foreach (var photo in db.Photos.ToList())
                {
                    if (photo.fileExtention == str)
                    {
                        phtosize2.Add(photo);
                    }
                }
            }





            foreach (var photo in phtosize2)
            {


                var pcb = new PictureBox();
                string fullyname = $"{RootPathFolder}/demo/{photo.fileNamee}";
                pcb.Image = Image.FromFile(fullyname);
                pcb.Top = top;
                pcb.Width = Image.FromFile(fullyname).Width / 10;
                pcb.Height = Image.FromFile(fullyname).Height / 10;
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Left = left4;
                left4 += pcb.Width + 20;
                panel1.Controls.Add(pcb);



            }

        }

        private void CategoryDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (var click in db.Categories.ToList())
            {
                if (ComboxobTodeleteCategory.SelectedItem.ToString() == click.CategoryName)
                {
                    FindRightIndex2 = click.id;
                    foreach (var click2 in db.Photos.ToList())
                    {
                        if (FindRightIndex2 == click2.fileCategoryId)
                        {
                            db.Photos.Remove(click2);
                            db.SaveChanges();
                        }
                    }

                    db.Categories.Remove(click);
                    db.SaveChanges();

                }

            }



            panelForCategories.Controls.Clear();
            AddingCategoryToPane();
            ComboList();






        }

        private void allPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int left5 = 30;
            foreach (var click in db.Photos.ToList())
            {
                

                var pcb = new PictureBox();
                string fullyname = $"{RootPathFolder}/demo/{click.fileNamee}";
                pcb.Image = Image.FromFile(fullyname);
                pcb.Top = top;

                pcb.Width = Image.FromFile(fullyname).Width/10;
                pcb.Height = Image.FromFile(fullyname).Height/10;
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Left = left5;
                left5 += pcb.Width + 20;
                panel1.Controls.Add(pcb);
            }
        }
    }
}
