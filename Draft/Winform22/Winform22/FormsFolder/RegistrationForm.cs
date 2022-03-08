using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform22.FormsFolder
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var firstpage = new FirstPageForm();
            firstpage.ShowDialog();

        }

        private void regbutoon_Click(object sender, EventArgs e)
        {
            
            if (textBoxName.Text != "" && textBoxEmail.Text != "" &&textBoxSurname.Text!="")
            {

                Random randomid = new Random();
                DateTime dateTime = DateTime.Now;

                var newclient = new User.UserClass();

                newclient.userName = textBoxName.Text;
                newclient.userSurName = textBoxSurname.Text;
                newclient.userEmailname = textBoxEmail.Text;
                newclient.userID = randomid.Next(1, 100);
                newclient.userDayofreg = dateTime.ToString();

                string pass = "12345"; /*Passcreator();*/
                newclient.usergenerpass = pass;
                Database.DBmodel.clientList.Add(newclient);

                
                

                MessageBox.Show($"You done! Your pass is {pass}   PLease memorise it");

            }
            else
            {
                MessageBox.Show("Fiels cannot be empty");
            }







        }
        private string Passcreator()
        {
            PassCreatorClass.PassCreator ppp = new PassCreatorClass.PassCreator();
            Random rand = new Random();
            int x = rand.Next(8, 12);
            string rs = ppp.GenerateRandomStrongPassword(x);
            return rs;
        }







    }
}
