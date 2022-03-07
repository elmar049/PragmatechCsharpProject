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
    public partial class FirstPageForm : Form
    {
        public FirstPageForm()
        {
            InitializeComponent();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginobject = new LoginForm();
            loginobject.Show();

        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regobject = new RegistrationForm();
            regobject.Show();

           
        }
    }
}
