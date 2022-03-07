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
    public partial class ClientPageForm : Form
    {
        //public static User.UserClass SelectedUser = new User.UserClass();
        public ClientPageForm()
        {
            InitializeComponent();
            
            
           
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            for (int v = 0; v < Database.DBmodel.clientList.Count; v++)
            {
                if(Database.DBmodel.clientList[v].userID== Database.DBmodel.SelectedUser.userID)
                {
                    Database.DBmodel.clientList.RemoveAt(v);
                }
            }

            var firstpage = new FirstPageForm();
            firstpage.ShowDialog();

        }

        private void mdfrBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var xxx=new PassLogModifier();
            xxx.Show();

            

          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
