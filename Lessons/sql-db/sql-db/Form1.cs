using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sql_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //1.create connection
            //2. open connection
            //3. select, updsate, delete, insert (only select it is returned a object)
            //4. select data populate date

            // for selection

            var Connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var connection = new SqlConnection(Connectionstring);
            //opensiz

            var queryy = "select * from Rooms";
            var adapter = new SqlDataAdapter(queryy, connection); // random formada melumatlari db getirir


            var ds = new DataSet(); // melumatlar duzgun formada gelsin, butun TABLERI.. bosh ppolkalardi
        
            adapter.Fill(ds); // adapterle geler melumalari zehmet olsa fill ele Ds adinda polkalara
            MessageBox.Show(ds.Tables[0].Rows[2]["r_name"].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 step:
            var Connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // 2 step:
            var connection = new SqlConnection(Connectionstring);
            connection.Open();

            // 3 step: Insert data

            var insertedquerry = $"insert into rooms (r_name) values ('{textBox1.Text}')";
            var insertccomand = new SqlCommand(insertedquerry, connection); //c# bu sql kodu bawa duwmke ucun
            insertccomand.ExecuteNonQuery(); //komandanin icrasi
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
