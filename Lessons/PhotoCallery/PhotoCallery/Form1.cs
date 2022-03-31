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
        int left = 30;
        string RootPathFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
        PhotoCalleryEntities db = new PhotoCalleryEntities();
        int FindRightIndex;


        public void ComboList()
        {

            var comboboxlist = new List<string>();
            foreach (var category in db.Categories.ToList())
            {
                comboboxlist.Add(category.CategoryName);

            }

            comboBox.DataSource = comboboxlist;

        }
        public void InsertingPhotoToPanel(string fullyname)
        {
            var pcb = new PictureBox();
            pcb.Image = Image.FromFile(fullyname);
            pcb.Top = 5;
            pcb.Width = 160;
            pcb.Height = 160;
            pcb.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb.Left = left;
            left += pcb.Width + 20;
            panel1.Controls.Add(pcb);

            foreach(var x in panel1.Controls)
            {
                if (panel1.Controls.Count % 4 == 0)
                {
                    pcb.Top = 170;
                    pcb.Left = 30;
                }
            }
        }

        public object AddingPhoto(DateTime daatetime, float FileSize, string FileLocation, string GetExt, int NewNamw)
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


        public Form1()
        {
            InitializeComponent();
            ComboList();











            foreach (var click in db.Categories.ToList())
            {
                Button label = new Button();
                label.Text = click.CategoryName;
                label.Top = 80;
                label.Left = left;
                left += label.Width + 20;
                this.Controls.Add(label);
                label.Click += Clickoncategory;

            }

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
            InsertingPhotoToPanel(FullnewName);

        }


        private void category_button_Click(object sender, EventArgs e)
        {
            var insertedCategory = category_text.Text;
            var newCateg = new Categories() {
                CategoryName = insertedCategory,
            };

            db.Categories.Add(newCateg);
            db.SaveChanges();
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
                string fullynewname = $"{RootPathFolder}/demo/{photo.fileNamee}";
                InsertingPhotoToPanel(fullynewname);



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            foreach (var rw in db.Categories.ToList())
            {
                
              ToolStripMenuItem MnuStripItem = new ToolStripMenuItem();
                MnuStripItem.Text = rw.CategoryName;
            }

        }

        
    }
}
