using System;
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
        private Form activeform;
        public Form1()
        {
            InitializeComponent();
            random = new Random();  //Why?
        }

        private Color selectthemcolor()
        {
            int index = random.Next(ColorChanger.ColorChangerColors.Count);
            while (tempindex == index)  // WHY?
            {
                index = random.Next(ColorChanger.ColorChangerColors.Count); // iff it was without index=, it would be infinite loop
            }
            tempindex = index; // WHY?
            string color = ColorChanger.ColorChangerColors[index];
            return ColorTranslator.FromHtml(color);

        }

        private void Activatebutton(object btnSender)
        {

            if (btnSender != null)
            {
                if (currentbutton != (Button)btnSender)
                {
                    Disabledbtn();
                    Color color = selectthemcolor();
                    currentbutton = (Button)btnSender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelLogo.BackColor = color;
                    panelToolbar.BackColor = ColorChanger.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void Disabledbtn()
        {
            foreach (Control prvsBtn in panelMenu.Controls)
            {
                if (prvsBtn.GetType() == typeof(Button))
                {
                    prvsBtn.BackColor = Color.DodgerBlue;
                    prvsBtn.ForeColor = Color.Black;
                    prvsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            Activatebutton(btnSender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labelHome.Text = childform.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormCustomers(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormNotification(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormOrders(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.FormProduct(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenChildForm(new forms.FormReports(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Formsetting(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (activeform != null)
 
                activeform.Close();
            reset();

        }

        private void reset()
        {
            Disabledbtn();
            labelHome.Text = "HOME";
            currentbutton = null;
            
            
        }
    }
}
