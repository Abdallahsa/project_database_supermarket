using System;

using System.Windows.Forms;
using System.Data.SqlClient;
namespace hhh
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                new SqlConnection
                ("Data Source=DESKTOP-ONU7173;Initial Catalog=master;Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.CommandText = "update CUSTOMER set CUSTNAME='" + name.Text + "' where CUSTPASSWORD='" + password.Text + "';";
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
            sqlCommand.CommandText = "delete from CUSTOMER  where CUSTPASSWORD='" + password.Text + "';";
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("success");
        }
    }
}
