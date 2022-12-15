using System;

using System.Windows.Forms;
using System.Data.SqlClient;
namespace hhh
{
    public partial class OptianCustomerForm2 : Form
    {
        string password;
        public OptianCustomerForm2(string password)
        {
            InitializeComponent();
            this.password = password;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void OptianCustomerForm2_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (password == "none")
                return;
            BuyForm2 f = new BuyForm2(password);
            f.Show();
            this.Hide();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = "update CUSTOMER set CUSTNAME='" + textBox2.Text + "' where CUSTPASSWORD='" + password + "';";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = "delete from CUSTOMER  where CUSTPASSWORD='" + password + "';";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            customerForm2 ff= new customerForm2();
            ff.Show();
            this.Hide();
           // MessageBox.Show("success");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
