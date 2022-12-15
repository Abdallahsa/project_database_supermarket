using System;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace hhh
{
    public partial class customerForm2 : Form
    {
        public customerForm2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string sendPassword;

            SqlConnection connection1 =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlDataAdapter da;
            DataSet ds;
            //checking if password already exists
            string q = "select  CUSTID, count(PRODID) as s from CUSTOMER_PRODUCT group by CUSTID order by s DESC";
            da = new SqlDataAdapter(q, connection1);
            ds = new DataSet();
            da.Fill(ds);
            connection1.Close();
            if (ds.Tables[0].Rows.Count == 0)
            {
                // making new customer
                SqlConnection connection =
                    new SqlConnection
                    ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                connection.Open();
                sqlCommand.CommandText = " insert into CUSTOMER values('" + textBox1.Text + "','" + textBox2.Text + "') ";
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("new customer added");
            }
            else
            {
                MessageBox.Show("login completed");
            }
            connection1.Close();
            /*if(x == 0)
            {
                // making new customer
                SqlConnection connection =
                    new SqlConnection
                    ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                connection.Open();
                sqlCommand.CommandText = " insert into CUSTOMER values('" + textBox1.Text + "','" + textBox2.Text + "') ";
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("new customer added");
            }
            else
            {
                MessageBox.Show("login completed");
            }*/




            

            OptianCustomerForm2 f = new OptianCustomerForm2(textBox2.Text);
            f.Show();
            //new OptianCustomerForm2().ShowDialog();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customerForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
