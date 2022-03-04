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
            firstpage.Show();

        }
        private void buttondell_Click(object sender, EventArgs e)
        {
            for (int b = 0; b < Database.DBmodel.clientList.Count; b++)
            {
                if (Database.DBmodel.clientList[b].userName == Database.DBmodel.DeletededUserClass.userName)
                {
                    Database.DBmodel.clientList.RemoveAt(b);
                }
            }
                var fff=new AdminForm();
            fff.Show();

        }


        private void DaxilOlarken_Click(object sender, EventArgs e)
        {


            //var cpf = new ClientPageForm();
            //cpf.ShowDialog();

            if (textBoxLog.Text == "demo@example.com" && textBoxPass.Text == "Demo")
            {
                var xxx = new AdminForm();
                xxx.Show();
                int x = 20;
                int y = 1;

                for (int b = 0; b < Database.DBmodel.clientList.Count; b++)
                {
                    var lblb = new Label();
                    var lblb2= new Label();
                    var btn = new Button();
                    lblb.Text = $"{y}. {Database.DBmodel.clientList[b].userName}";
                    lblb2.Text = Database.DBmodel.clientList[b].userName;
                    lblb.Top = x;
                    lblb.Left = 20;
                    lblb2.Left = x;

                    btn.Text = "Delete";
                    btn.Top = x;
                    btn.Left = 170;

                    x += 25;
                    y++;
                    xxx.Controls.Add(lblb);
                    xxx.Controls.Add(lblb2);
                    xxx.Controls.Add(btn);

                    Database.DBmodel.DeletededUserClass.userName = Database.DBmodel.clientList[b].userName;    //bunu duzlet ID

                    //btn.Click += new System.EventHandler(this.buttondell_Click);
                }
            }

            for (int i = 0; i < Database.DBmodel.clientList.Count; i++)
            {

                if (textBoxLog.Text == Database.DBmodel.clientList[i].userName && textBoxPass.Text == Database.DBmodel.clientList[i].usergenerpass)
                {
                    var cpf = new ClientPageForm();
                    Database.DBmodel.SelectedUser = Database.DBmodel.clientList[i];


                    var lbl = new Label();
                    var lbl2 = new Label();
                    lbl.Top = 50;
                    lbl.Left = 150;
                    lbl2.Top = 100;
                    lbl.BackColor = Color.Red;
                    lbl.Text = Database.DBmodel.clientList[i].userName;
                    lbl2.Text = Database.DBmodel.clientList[i].usergenerpass;

                    cpf.Controls.Add(lbl);
                    cpf.Controls.Add(lbl2);
                    cpf.Show();


                }
                //if (textBoxLog.Text != Database.DBmodel.clientList[i].userName || textBoxPass.Text != Database.DBmodel.clientList[i].usergenerpass)
                //{
                //    MessageBox.Show(Database.DBmodel.clientList.Count.ToString());
                //    break;
                //}




            }



        }
    }
}
