using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chesttable
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            int x = 0;
           
            int x2 = 0;
            int y = 0;
           

            for (int j = 0; j < 4; j++)
            {
                x = 0;

                for (int i = 0; i < 8; i++)
                {
                    y++;
                    if (y % 2 == 0)
                    {
                        Button btn = new Button();
                        btn.BackColor = Color.Black;
                        btn.Size = new Size(50, 50);

                        btn.Left = x;
                        x += 50;
                        btn.Top = x2; 
                        Controls.Add(btn);
                        
                    }
                    if (y % 2 == 1)
                    {
                        Button btn = new Button();
                        btn.BackColor = Color.White;
                        btn.Size = new Size(50, 50);

                        btn.Left = x;
                        x += 50;
                        btn.Top= x2; 
                        Controls.Add(btn);
                        
                    }

                }
                x = 0;
                x2 += 50;
                
                

                //for (int k = 0; k < 8; k++)
                //{
                    
                //    y++;

                //    if (y % 2 == 0)
                //    {
                //        Button btn = new Button();
                //        btn.BackColor = Color.White;
                //        btn.Size = new Size(50, 50);
                //        btn.Left = x;
                //        x += 50;
                //        Controls.Add(btn);
                //        btn.Top = x2;                      
                //    }
                //    if (y % 2 == 1)
                //    {
                //        Button btn = new Button();
                //        btn.BackColor = Color.Black;
                //        btn.Size = new Size(50, 50);
                //        btn.Top = x2;
                //        btn.Left = x;
                //        x += 50;
                //        Controls.Add(btn);                   
                //    }
                   
                //}
                x2 += 50;
               

            }
          


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


    }


}

