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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstpage = new FirstPageForm();
            firstpage.ShowDialog();

        }

        private void DaxilOlarken_Click(object sender, EventArgs e)
        {


            //var cpf = new ClientPageForm();
            //cpf.ShowDialog();
            foreach (var c in Database.DBmodel.clientList)
            {
                if (c.userName == textBoxLog.Text)
                {
                    var cpf = new ClientPageForm();
                    cpf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You have reg yet");
                }



            }

        }
    }
}
