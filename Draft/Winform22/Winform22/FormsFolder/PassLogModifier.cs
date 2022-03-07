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
    public partial class PassLogModifier : Form
    {
        public PassLogModifier()
        {
            InitializeComponent();
        }

        private void savebtnmodify_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Database.DBmodel.SelectedUser.userName = textBoxname.Text;
            Database.DBmodel.SelectedUser.usergenerpass = textBoxpass.Text;

            var firstpage = new FirstPageForm();
            firstpage.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
