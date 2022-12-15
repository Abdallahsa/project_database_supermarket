using System;

using System.Windows.Forms;
using System.Data.SqlClient;
namespace hhh
{
    public partial class BuyForm2 : Form
    {
        string password;
        public BuyForm2(string password)
        {
            InitializeComponent();
            this.password = password;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.masterDataSet.Product);
        }

        private void BuyForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.masterDataSet.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int id = proID.;
            int rr;
            /*if (!int.TryParse(proID.Text, out id))
            {
                MessageBox.Show("Icorrect value in field 'textBox1'");
                return;
            }*/


            //quantity after buying
            rr= int.Parse(proID.Text);
            //string qq;
            SqlConnection Sqlconnection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand Command = Sqlconnection.CreateCommand();
            Command.Connection = Sqlconnection;
            Sqlconnection.Open();
            Command.CommandText = "select PRODQUANTITY from PRODUCT where PRODID= " + proID.Text;
            SqlDataReader r=Command.ExecuteReader();
            //Command.ExecuteNonQuery();
            if (r.Read())
            {
                int q;
                q = int.Parse(qunatity.Text);
                string s = r["PRODQUANTITY"].ToString();
                rr = int.Parse(s) - q;
                if (rr < 0)
                {
                    MessageBox.Show("quantity not available");
                    return;
                }

                //MessageBox.Show("success");


                // rr = int.Parse( r["PRODQUANTITY"].ToString );

            }
            Sqlconnection.Close();



            /**/





            //MessageBox.Show("success");


            //getting customer id
            string customerID="1";
            Command.Connection = Sqlconnection;
            Sqlconnection.Open();
            Command.CommandText = "select CUSTID from CUSTOMER where CUSTPASSWORD= '" + password+"'";
            SqlDataReader re = Command.ExecuteReader();
            //Command.ExecuteNonQuery();
            if (re.Read())
            {
               
                string s = re["CUSTID"].ToString();
                customerID=s;
                
            }











                //MessageBox.Show("success");

            // changing quantity
                SqlConnection connection1 =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand1 = connection1.CreateCommand();
            sqlCommand1.Connection = connection1;
            connection1.Open();
            sqlCommand1.CommandText = "update PRODUCT set PRODQUANTITY= "+ rr + "where  PRODID="+ proID.Text;
            sqlCommand1.ExecuteNonQuery();
            connection1.Close();
            //MessageBox.Show("success");



            // saving bill
            SqlConnection connection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = " insert into CUSTOMER_PRODUCT values('" +customerID +"',"+proID.Text+",'"+ DateTime.UtcNow.ToString("MM-dd-yyyy") + "') ";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");

            /* Command.Connection = Sqlconnection;
             Sqlconnection.Open();
             Command.CommandText = "select PRODQUANTITY from PRODUCT where PRODID= " + proID.Text;
             SqlDataReader r = Command.ExecuteReader();
             //Command.ExecuteNonQuery();
             if (r.Read())
             {
                 int q;
                 q = int.Parse(qunatity.Text);
                 string s = r["PRODQUANTITY"].ToString();
                 rr = int.Parse(s) - q;
                 if (rr < 0)
                 {
                     MessageBox.Show("quntity not availabel");
                     return;
                 }

                 //MessageBox.Show("success");


                 // rr = int.Parse( r["PRODQUANTITY"].ToString );

             }

             Sqlconnection.Close();*/









            //MessageBox.Show("success");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n = proName.Text;
            SqlConnection Sqlconnection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
            int rr;
            SqlCommand Command = Sqlconnection.CreateCommand();
            Command.Connection = Sqlconnection;
            Sqlconnection.Open();
            Command.CommandText = "select PRODID from PRODUCT where PRODNAME= '" + n+ "'";
            SqlDataReader r = Command.ExecuteReader();
            //Command.ExecuteNonQuery();
            if (r.Read())
            {
                /*int q;
                q = int.Parse(qunatity.Text);*/
                string s = r["PRODID"].ToString();
                //rr = int.Parse(s) - q;
                //if (rr < 0)
                //{
                    MessageBox.Show("id is:"+s);
                    //return;
                //}

                //MessageBox.Show("success");


                // rr = int.Parse( r["PRODQUANTITY"].ToString );

            }

            Sqlconnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
